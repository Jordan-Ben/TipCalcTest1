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

namespace TipCalcTest1
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
            double billAmount;
            double tipPercentage;
            double tipAmount;
            double total;

            billAmount = Convert.ToDouble (BillTotalInput.Text);
            tipPercentage = Convert.ToDouble(TipPercentageInput.Text);
            tipAmount = (billAmount * tipPercentage) / 100;
            total = tipAmount + billAmount;

            ResultTextBox.Text = "You should leave " + tipAmount.ToString("C") + ". Your total will be " + total.ToString("C");
      
        }

        
    }
}
