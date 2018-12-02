namespace MemoryLeaksDemo.BindingLeak
{
    class PersonLeaky
    {
        public string Name { get; set; }

        public readonly byte[] Trash = new byte[50 * 1024 * 1024];
    }
}