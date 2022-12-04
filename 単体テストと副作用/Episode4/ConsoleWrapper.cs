using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode4
{
    public sealed class ConsoleWrapper : IConsoleWrapper
    {
        public string ReadLine(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.Write(message);
            }

            return Console.ReadLine();
        }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
