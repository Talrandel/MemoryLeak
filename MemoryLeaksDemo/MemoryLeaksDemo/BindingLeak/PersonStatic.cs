using MemoryLeaksDemo.Infrastructure;

namespace MemoryLeaksDemo.BindingLeak
{
    static class PersonStatic
    {
        private static HeavyObject _heavyObject = new HeavyObject();

        public static string Name { get; set; }
    }
}