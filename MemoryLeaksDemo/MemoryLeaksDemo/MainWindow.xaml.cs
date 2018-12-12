using System.Windows;
using MemoryLeaksDemo.BindingLeak;
using System;

namespace MemoryLeaksDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlockMemory.Text = GC.GetTotalMemory(true).ToString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var w1 = new BindingLeakWindow();
            w1.ShowDialog();
            TextBlockMemory.Text = GC.GetTotalMemory(true).ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonGC_Click(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            GC.Collect();
            TextBlockMemory.Text = GC.GetTotalMemory(true).ToString();
        }
    }
}