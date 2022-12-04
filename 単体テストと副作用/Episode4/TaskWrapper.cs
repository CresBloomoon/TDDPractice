using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode4
{
    public sealed class TaskWrapper : ITaskWrapper
    {
        public Task Delay(int milliseconds)
        {
            return Task.Delay(milliseconds);
        }
    }
}
