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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void txt1Changed(object sender, TextChangedEventArgs e)
        {
            if (txt1.Text.Length == 2)
            {
                txt2.Focus();
            }
        }

        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt2.Text.Length == 2)
            {
                txt3.Focus();
            }
        }

        private void txt3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt3.Text.Length == 2)
            {
                txt4.Focus();
            }
        }

        private void txt4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt4.Text.Length == 2)
            {
                txt5.Focus();
            }
        }

        private void txt5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt5.Text.Length == 2)
            {
                cmdOK.Focus();
            }
        }

        private void cmdOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
