using MemoryLeaksDemo.Infrastructure;

namespace MemoryLeaksDemo.BindingLeak
{
    class PersonImmutable : HeavyObject
    {
        public PersonImmutable(string name)
        {
            Name = name;
        }

        public string Name { get; }        
    }
}