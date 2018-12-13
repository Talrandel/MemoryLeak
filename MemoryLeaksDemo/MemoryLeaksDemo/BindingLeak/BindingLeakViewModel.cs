using GalaSoft.MvvmLight;

namespace MemoryLeaksDemo.BindingLeak
{
    class BindingLeakViewModel : ViewModelBase
    {
        public BindingLeakViewModel()
        {
            Person = new PersonLeaky();
            //Person = new PersonImmutable();
            //Person = new PersonNormal();
        }      

        public PersonLeaky Person { get; set; }
        //public PersonImmutable Person { get; set; }
        //public PersonNormal Person { get; set; }
    }
}