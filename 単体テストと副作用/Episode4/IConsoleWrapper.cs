using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode4
{
    public interface IConsoleWrapper
    {
        string ReadLine(string message);
        void WriteLine(string str);
    }
}
