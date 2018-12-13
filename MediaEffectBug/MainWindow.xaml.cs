using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Controls;

namespace ShowEffectsBug
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            var border = VisualTreeHelper.GetChild(this.checkBox, 0) as Border;
            if (border != null)
            {
                Effect effect = border.Effect;
                if (effect != null)
                    textBlock.Text = $"Effect.IsFrozen = {effect.IsFrozen}";
            }
        }
    }
}