using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Episode4
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IConsoleWrapper, ConsoleWrapper>();
            container.RegisterType<ITaskWrapper, TaskWrapper>();
            container.RegisterType<MainFlow>();

            var mainFlow = container.Resolve<MainFlow>();
            await mainFlow.Run();
        }
    }
}
