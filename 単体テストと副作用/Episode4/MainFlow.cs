using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Episode4
{
    public sealed class MainFlow
    {
        [Dependency]
        public IConsoleWrapper ConsoleWrapper { get; set; }

        [Dependency]
        public ITaskWrapper TaskWrapper { get; set; }

        public async Task Run()
        {
            var typedValues = ReadTypedValues();

            foreach (var typedValue in typedValues)
            {
                await TaskWrapper.Delay(1000);
                ConsoleWrapper.WriteLine(typedValue.ToString());
            }
        }

        private IEnumerable<TypedValue> ReadTypedValues()
        {
            var valueStrs = ConsoleWrapper.ReadLine("カンマ区切りの値を入力:");
            return valueStrs.Split(',').Select(x => new TypedValue(x));
        }
    }
}
