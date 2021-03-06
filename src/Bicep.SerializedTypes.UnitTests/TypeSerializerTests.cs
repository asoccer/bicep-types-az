// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System.Collections.Generic;
using System.Linq;
using Bicep.SerializedTypes.Concrete;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bicep.SerializedTypes.UnitTests
{
    [TestClass]
    public class TypeSerializerTests
    {
        [TestMethod]
        public void BuiltInType_can_be_serialized_and_deserialized()
        {
            var builtIns = new []
            {
                new BuiltInType { Kind = BuiltInTypeKind.Any },
                new BuiltInType { Kind = BuiltInTypeKind.Null },
                new BuiltInType { Kind = BuiltInTypeKind.Bool },
                new BuiltInType { Kind = BuiltInTypeKind.Int },
                new BuiltInType { Kind = BuiltInTypeKind.String },
                new BuiltInType { Kind = BuiltInTypeKind.Object },
                new BuiltInType { Kind = BuiltInTypeKind.Array },
                new BuiltInType { Kind = BuiltInTypeKind.ResourceRef },
            };

            var serialized = TypeSerializer.Serialize(builtIns);
            var deserializedBuiltIns = TypeSerializer.Deserialize(serialized);

            for (var i = 0; i < builtIns.Length; i++)
            {
                deserializedBuiltIns[i].Should().BeOfType<BuiltInType>();
                var deserializedBuiltIn = (BuiltInType)deserializedBuiltIns[i];

                deserializedBuiltIn.Kind.Should().Be(builtIns[i].Kind);
            }
        }

        [TestMethod]
        public void Circular_references_are_allowed()
        {
            var factory = new TypeFactory(Enumerable.Empty<TypeBase>());
            var typeA = factory.Create(() => new ObjectType { Name = "typeA", Properties = new Dictionary<string, ObjectProperty>() });
            var typeB = factory.Create(() => new ObjectType { Name = "typeB", Properties = new Dictionary<string, ObjectProperty>() });

            typeA.Properties!["typeB"] = new ObjectProperty { Type = factory.GetReference(typeB), Flags = ObjectPropertyFlags.None, };
            typeB.Properties!["typeA"] = new ObjectProperty { Type = factory.GetReference(typeA), Flags = ObjectPropertyFlags.None, };

            var serialized = TypeSerializer.Serialize(factory.GetTypes());
            var deserialized = TypeSerializer.Deserialize(serialized);

            deserialized[0].Should().BeOfType<ObjectType>();
            deserialized[1].Should().BeOfType<ObjectType>();

            var deserializedTypeA = (ObjectType)deserialized[0];
            var deserializedTypeB = (ObjectType)deserialized[1];

            deserializedTypeA.Properties!["typeB"].Type!.Type.Should().Be(deserializedTypeB);
            deserializedTypeB.Properties!["typeA"].Type!.Type.Should().Be(deserializedTypeA);
        }

        [TestMethod]
        public void Different_types_can_be_serialized_and_deserialized()
        {
            var factory = new TypeFactory(Enumerable.Empty<TypeBase>());

            var intType = factory.Create(() => new BuiltInType { Kind = BuiltInTypeKind.Int });
            var objectType = factory.Create(() => new ObjectType { Name = "steven", Properties = new Dictionary<string, ObjectProperty>() });
            var arrayType = factory.Create(() => new ArrayType { ItemType = factory.GetReference(objectType) });
            var resourceType = factory.Create(() => new ResourceType { Name = "gerrard", Body = factory.GetReference(objectType) });
            var unionType = factory.Create(() => new UnionType { Elements = new [] { factory.GetReference(intType), factory.GetReference(objectType) } });
            var stringLiteralType = factory.Create(() => new StringLiteralType { Value = "abcdef" });
            var discriminatedObjectType = factory.Create(() => new DiscriminatedObjectType { Name = "disctest" });

            var serialized = TypeSerializer.Serialize(factory.GetTypes());
            var deserialized = TypeSerializer.Deserialize(serialized);

            deserialized[0].Should().BeOfType<BuiltInType>();
            deserialized[1].Should().BeOfType<ObjectType>();
            deserialized[2].Should().BeOfType<ArrayType>();
            deserialized[3].Should().BeOfType<ResourceType>();
            deserialized[4].Should().BeOfType<UnionType>();
            deserialized[5].Should().BeOfType<StringLiteralType>();
            deserialized[6].Should().BeOfType<DiscriminatedObjectType>();

            ((BuiltInType)deserialized[0]).Kind.Should().Be(intType.Kind);
            ((ObjectType)deserialized[1]).Name.Should().Be(objectType.Name);
            ((ArrayType)deserialized[2]).ItemType!.Type.Should().Be(deserialized[1]);
            ((ResourceType)deserialized[3]).Name.Should().Be(resourceType.Name);
            ((UnionType)deserialized[4]).Elements![0].Type.Should().Be(deserialized[0]);
            ((UnionType)deserialized[4]).Elements![1].Type.Should().Be(deserialized[1]);
            ((StringLiteralType)deserialized[5]).Value.Should().Be(stringLiteralType.Value);
            ((DiscriminatedObjectType)deserialized[6]).Name.Should().Be(discriminatedObjectType.Name);
        }
    }
}