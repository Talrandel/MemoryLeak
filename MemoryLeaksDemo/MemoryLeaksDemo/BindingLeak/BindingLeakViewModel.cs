using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MemoryLeaksDemo.BindingLeak
{
    class BindingLeakViewModel : ViewModelBase
    {
        public BindingLeakViewModel()
        {
            PersonLeaky = new PersonLeaky();
        }      

        public PersonLeaky PersonLeaky { get; set; }        
    }
}