namespace MemoryLeaksDemo.Infrastructure
{
    class HeavyObject
    {
        private readonly byte[] _trash = new byte[50 * 1024 * 1024];
    }
}