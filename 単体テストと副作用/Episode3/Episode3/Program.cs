using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Episode3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DIコンテナの設定
            var container = new UnityContainer();
            container.RegisterType<IHoge, Hoge>();
            container.RegisterType<Fuga>();

            //Fugaインスタンスの生成
            var fuga = container.Resolve<Fuga>();

            fuga.Hello();
        }
    }
}
