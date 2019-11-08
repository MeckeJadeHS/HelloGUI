using System;
using System.Windows;
using System.Windows.Controls;

namespace HalloGUI2
{
    /// <summary>
    /// Interaktionslogik für GuiUC.xaml
    /// </summary>
    public partial class GuiUC : UserControl
    {
        public GuiUC()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_hide_Click(object sender, RoutedEventArgs e)
        {
            tb_wertx.Visibility = Visibility.Hidden;
            lab_wertx.Content = "Knpof gedrückt!";
        }

    }
}
