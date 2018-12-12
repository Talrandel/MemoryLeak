using MemoryLeaksDemo.Infrastructure;

namespace MemoryLeaksDemo.BindingLeak
{
    class PersonLeaky : HeavyObject
    {
        public string Name { get; set; }
    }
}