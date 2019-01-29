using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WiegandCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();

            //Added 1/28/2019  thomas downes 
            int nineteen = 0b10011;

            nineteen += 1;

            //Added 1/28/2019  thomas downes 
            int Decimal1659 = 0b11001111011;

            Decimal1659 += 0;

            //Added 1/28/2019  thomas downes 
            int huge = 0b1_10010111_0000011001111011_1;

            huge += 0;

            var binary = Convert.ToString(huge, 2);

            MessageBox.Show(binary.ToString());

            // results in:    11001011100000110011110111






        }
    }
}
