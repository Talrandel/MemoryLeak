using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MemoryLeaksDemo.MediaEffectLeak
{
    public partial class MediaEffectLeakView
    {
        public MediaEffectLeakView()
        {
            InitializeComponent();
        }

        private void MediaEffectLeakView_OnLoaded(object sender, RoutedEventArgs e)
        {
            var border = VisualTreeHelper.GetChild(CheckBox1, 0) as Border;
            var effect = border?.Effect;
            if (effect != null)
                TextBlock1.Text = $"Effect.IsFrozen = {effect.IsFrozen}";
        }
    }
}