using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode3
{
    public sealed class Hoge : IHoge
    {
        public void Hello()
        {
            Console.WriteLine("Hello world");
        }
    }
}
