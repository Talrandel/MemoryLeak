using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksDemo.EventHandlerLeak
{
    class StaticSampleObject
    {
        public static event Action StaticSampleEvent;
    }
}
