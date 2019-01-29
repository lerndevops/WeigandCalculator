using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiegandCalculator
{
    public static class ClassStatic
    {
        public static void Main()
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

            //MessageBox.Show(binary.ToString());

            // results in:    11001011100000110011110111

        }

        internal static void scratchpad()
        {

            //Added 1/28/2019  thomas downes 
            int nineteen = 0b10011;

            nineteen += 1;

            //Added 1/28/2019  thomas downes 
            int Decimal1659 = 0b11001111011;

            Decimal1659 += 0;

            //Added 1/28/2019  thomas downes 
            int huge = 0b1_10010111_0000011001111011_1;

            huge += 0;

            var binary = System.Convert.ToString(huge, 2);

            //MessageBox.Show(binary.ToString());
            System.Diagnostics.Debugger.Log(0, "", binary.ToString());

            // results in:    11001011100000110011110111

        }

        public static double ConvertBinaryToDecimal(string par_strBinary)
        {


            return 0;  


        }

        public static string LongBinaryString()
        {
            //Added 1/28/2019  thomas downes 
            int huge = 0b1_10010111_0000011001111011_1;

            var binary = System.Convert.ToString(huge, 2);

            return binary.ToString();

        }

        public static string ConvertDoubleToBinaryString(int par_integer)
        {
            // input integer:  
            // results in:    "11001011100000110011110111"
            return System.Convert.ToString(par_integer, 2).ToString();

        }


    }
}
