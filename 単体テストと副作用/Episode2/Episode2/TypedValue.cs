using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Episode2
{
    public sealed class TypedValue
    {
        public string Value { get; }
        public TypeKind TypeKind { get; }

        public TypedValue(string value)
        {
            Value = value;
            if (Regex.IsMatch(Value, @"^(| null)$")) TypeKind = TypeKind.Null;
            else if (Regex.IsMatch(Value, @"^(true|false)$")) TypeKind = TypeKind.Bool;
            else if (Regex.IsMatch(Value, @"^-?[0-9]+(\.[0-9]+)?$")) TypeKind = TypeKind.Number;
            else TypeKind = TypeKind.String;
        }

        public void WriteLine()
        {
            Console.WriteLine($"{Value} : {ToString(TypeKind)}");
        }

        private string ToString(TypeKind typeKind)
        {
            switch (typeKind)
            {
                case TypeKind.Null:
                    return "null";
                case TypeKind.Bool:
                    return "bool";
                case TypeKind.Number:
                    return "number";
                case TypeKind.String:
                    return "string";
                default:
                    return string.Empty;
            }
        }
    }
}
