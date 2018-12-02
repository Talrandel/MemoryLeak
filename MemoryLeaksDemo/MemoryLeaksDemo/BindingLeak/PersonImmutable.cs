namespace MemoryLeaksDemo.BindingLeak
{
    class PersonImmutable
    {
        public PersonImmutable(string name)
        {
            Name = name;
        }

        public string Name { get; }        
    }
}