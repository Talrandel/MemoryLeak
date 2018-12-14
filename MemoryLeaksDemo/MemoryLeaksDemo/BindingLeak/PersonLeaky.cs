using MemoryLeaksDemo.Infrastructure;

namespace MemoryLeaksDemo.BindingLeak
{
    class PersonLeaky : HeavyObject
    {
        public PersonLeaky(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}