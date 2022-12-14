using System.Collections.Generic;
using Episode4;
using Xunit;

namespace Episode4Test.Tests
{
    public class Test_TypedValue
    {
        [Theory]
        [MemberData(nameof(Constructor_Data))]
        public void Constructor(TypeKind expected, string value)
        {
            var typedValue = new TypedValue(value);

            Assert.Equal(value, typedValue.Value);
            Assert.Equal(expected, typedValue.TypeKind);
        }

        public static IEnumerable<object[]> Constructor_Data()
        {
            return new[]
            {
                new object[] { TypeKind.Null, "" },
                new object[] { TypeKind.Null, "null" },
                new object[] { TypeKind.Bool, "true" },
                new object[] { TypeKind.Bool, "false" },
                new object[] { TypeKind.Number, "0.0" },
                new object[] { TypeKind.Number, "789" },
                new object[] { TypeKind.Number, "-12.345" },
                new object[] { TypeKind.String, "a123" },
                new object[] { TypeKind.String, "$#@?+" }
            };
        }

        [Theory]
        [MemberData(nameof(ToString_Data))]
        public void ToString_(string expectedValue, string expectedType, string value)
        {
            var typedValue = new TypedValue(value);
            var str = typedValue.ToString();

            Assert.Equal($"{expectedValue} : {expectedType}", str);
        }

        public static IEnumerable<object[]> ToString_Data()
        {
            return new[]
            {
                new object[] { ""       , "null"  , ""        },
                new object[] { "null"   , "null"  , "null"    },
                new object[] { "true"   , "bool"  , "true"    },
                new object[] { "false"  , "bool"  , "false"   },
                new object[] { "0.0"    , "number", "0.0"     },
                new object[] { "789"    , "number", "789"     },
                new object[] { "-12.345", "number", "-12.345" },
                new object[] { "a123"   , "string", "a123"    },
                new object[] { "$#@?+"  , "string", "$#@?+"   }
            };
        }

    }
}