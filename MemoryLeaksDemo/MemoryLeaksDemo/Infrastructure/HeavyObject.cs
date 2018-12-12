using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksDemo.Infrastructure
{
    class HeavyObject : MyObservableObject
    {
        private readonly byte[] _trash = new byte[50 * 1024 * 1024];
    }
}
