// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bicep.SerializedTypes.Concrete;

namespace Bicep.SerializedTypes.Az
{
    public class TypeLoader : ITypeLoader
    {
        private const string TypeContainerName = "types.json";
        private const string TypeIndexResourceName = "index.json";

        private static string GetTypeContainerResourceName(string providerNamespace, string apiVersion)
            => $"{providerNamespace}/{apiVersion}/{TypeContainerName}".ToLowerInvariant();

        public IEnumerable<TypeBase> LoadTypes(string providerNamespace, string apiVersion)
        {
            var streamName = GetTypeContainerResourceName(providerNamespace, apiVersion);
            var fileStream = typeof(TypeLoader).Assembly.GetManifestResourceStream(streamName);

            if (fileStream == null)
            {
                return Enumerable.Empty<TypeBase>();
            }

            using (fileStream)
            using (var streamReader = new StreamReader(fileStream))
            {
                var content = streamReader.ReadToEnd();

                return TypeSerializer.Deserialize(content);
            }
        }

        public ResourceType LoadResourceType(TypeLocation typeLocation)
        {
            var fileStream = typeof(TypeLoader).Assembly.GetManifestResourceStream(typeLocation.RelativePath);
            if (fileStream == null)
            {
                throw new ArgumentException($"Unable to locate type \"{typeLocation.RelativePath}\" resource");
            }

            using (fileStream)
            using (var streamReader = new StreamReader(fileStream))
            {
                var content = streamReader.ReadToEnd();

                var types = TypeSerializer.Deserialize(content);
                if (!(typeLocation.Index is int intIndex && types[intIndex] is ResourceType resourceType))
                {
                    throw new ArgumentException($"Unable to locate resource type at index {typeLocation.Index} in \"{typeLocation.RelativePath}\" resource");
                }

                return resourceType;
            }
        }

        public IReadOnlyDictionary<string, TypeLocation> ListAllAvailableTypes()
        {
            var fileStream = typeof(TypeLoader).Assembly.GetManifestResourceStream(TypeIndexResourceName);
            if (fileStream == null)
            {
                throw new ArgumentException("Unable to locate type index resource");
            }

            using (fileStream)
            using (var streamReader = new StreamReader(fileStream))
            {
                var content = streamReader.ReadToEnd();

                return TypeIndexer.DeserializeIndex(content);
            }
        }
    }
}