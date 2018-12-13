using System.Text;

namespace MemoryLeaksDemo.TextBoxUndoLeak
{
    public partial class TextBoxUndoLeakView
    {
        public TextBoxUndoLeakView()
        {
            InitializeComponent();

            var sb = new StringBuilder(10000);
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(1);
            }
            var longString = sb.ToString();

            for (int i = 0; i < 100000; i++)
            {
                SampleTextBox.Text = longString;
            }
        }        
    }
}