using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Episode3
{
    public sealed class Fuga
    {
        [Dependency]
        public IHoge Hoge { get; set; }

        public void Hello()
        {
            Hoge.Hello();
        }

    }
}
