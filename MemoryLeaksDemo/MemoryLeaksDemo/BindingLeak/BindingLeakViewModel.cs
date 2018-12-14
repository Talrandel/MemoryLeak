using GalaSoft.MvvmLight;

namespace MemoryLeaksDemo.BindingLeak
{
    class BindingLeakViewModel : ViewModelBase
    {
        private PersonLeaky _person;

        public BindingLeakViewModel()
        {
            Person = new PersonLeaky("John Doe");
            PersonStaticName = "Static John Doe";
            //Person = new PersonImmutable("John Doe");
            //Person = new PersonNormal("John Doe");
        }

        public PersonLeaky Person
        {
            get { return _person; }
            set { Set(ref _person, value); }
        }
        //public PersonImmutable Person { get; set; }
        //public PersonNormal Person { get; set; }

        public string PersonStaticName
        {
            get { return PersonStatic.Name; }
            set { PersonStatic.Name = value; }
        }
    }
}