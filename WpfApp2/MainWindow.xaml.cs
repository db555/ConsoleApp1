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

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format("Bonjour {0} {1} vous avez {2:0.00} ans", txtPrenom.Text, txtNom.Text, tool.CalcAge(dtNaissance.DisplayDate)));
        }

        private void cmdTel_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
            lblTel.Content = w1.txt1.Text + " " + w1.txt2.Text + " " + w1.txt3.Text + " " + w1.txt4.Text + " " + w1.txt5.Text;
            w1.Close();
        }
    }
}
public abstract class tool
{
    public static double CalcAge(DateTime DateNaiss)
    {
        return ((DateTime.Now - DateNaiss).Days / 365.242189);
    }
}