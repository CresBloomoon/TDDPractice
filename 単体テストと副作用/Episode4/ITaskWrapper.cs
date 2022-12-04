using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode4
{
    public interface ITaskWrapper
    {
        Task Delay(int milliseconds);
    }
}
