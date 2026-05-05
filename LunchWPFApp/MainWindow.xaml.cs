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

namespace LunchWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wrapRadioButton.IsChecked == true)
            {
                MessageBox.Show("I am going to have a wrap for lunch today");
            }
            else if (burritoRadioButton.IsChecked == true)
            {
                MessageBox.Show("I am going to have a burrito for lunch today");
            }
            else if (tacoRadioButton.IsChecked == true)
            {
                MessageBox.Show("I am going to have a taco for lunch today");
            }
            else if (paniniRadioButton.IsChecked == true)
            {
                MessageBox.Show("I am going to have a panini for lunch today");
            }
            else if (burgerRadioButton.IsChecked == true)
            {
                MessageBox.Show("I am going to have a burger for lunch today");
            }
            else
            {
                MessageBox.Show("No lunch option has been selected");
            }
        }
    }
}
