using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Printer posPrinter;
        private Font printFont;

        public MainWindow()
        {
            InitializeComponent();
            this.posPrinter = new Printer();
        }
        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawString("just a test", printFont, System.Drawing.Brushes.Black, 0, 0, new StringFormat());
            ev.Graphics.DrawString("just a test2", printFont, System.Drawing.Brushes.Black, 0, printFont.GetHeight(ev.Graphics), new StringFormat());
            return;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                printFont = new Font("Arial", 10);
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler
                   (this.pd_PrintPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }

}
