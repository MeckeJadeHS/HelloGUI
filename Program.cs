using System;
using System.Windows;

namespace HalloGUI2
{
    class Program
    {
        public Program()
        {
            Window fenster =new Window();
            GuiUC myGUI = new GuiUC();

            fenster.Content = myGUI;
            fenster.Title = "Mein Fenster";
            fenster.SizeToContent = SizeToContent.WidthAndHeight;
            fenster.ResizeMode = ResizeMode.NoResize;

            fenster.ShowDialog();

        }

        [STAThread]
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
