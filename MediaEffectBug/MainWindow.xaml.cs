namespace ShowEffectsBug
{
    using System;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Effects;
    using System.Windows.Controls;

    public partial class MainWindow : Window
    {
        #region Constructor(s)/Destructor

        public MainWindow()
        {
            // Initialize component
            InitializeComponent();
        }

        #endregion

        #region Private event handlers

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            // The first visual child of the checkbox is the Border
            // which has the DropShadowEffect applied to it.
            Border border = VisualTreeHelper.GetChild(this.checkBox, 0) as Border;
            if (border != null)
            {
                Effect effect = border.Effect;
                if (effect != null)
                    textBlock.Text = string.Format("Effect.IsFrozen={0}", effect.IsFrozen);
            }
        }

        #endregion
    }
}
