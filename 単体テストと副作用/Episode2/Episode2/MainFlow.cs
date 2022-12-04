using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode2
{
    internal static class MainFlow
    {
        public static async Task Run()
        {
            var typeValues = ReadTypedValues();

            foreach (var typeValue in typeValues)
            {
                await Task.Delay(1000);
                typeValue.WriteLine();
            }
        }

        private static IEnumerable<TypedValue> ReadTypedValues()
        {
            Console.Write("カンマ区切りの値を入力：");
            var valueStrs = Console.ReadLine();

            return valueStrs.Split(',')
                .Select(x => new TypedValue(x));
        }
    }
}
