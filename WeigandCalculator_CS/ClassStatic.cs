using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeigandCalculator_CS
{
    public static class ClassStatic
    {
        internal static void Main()
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

        //public static long ConvertBinaryToDecimal(string par_strBinary)
        //{
        //    return 0; 
        //}

        internal static string LongBinary_ToString()
        {
            //Added 1/28/2019  thomas downes 
            int huge = 0b1_10010111_0000011001111011_1;

            var binary = System.Convert.ToString(huge, 2);

            return binary.ToString();

        }

        internal static long LongBinary_ToLongInteger()
        {
            //Added 1/28/2019  thomas downes 
            //long huge = 0b1_10010111_0000011001111011_1;
            long huge = 0b11001011100000110011110111;

            //var binary = System.Convert.ToString(huge, 2);

            //Returns 53349623.  
            return huge;

        }

        internal static long LongBinaryString_ToLong()
        {
            //Added 1/28/2019  thomas downes 
            string strHuge = "0b11001011100000110011110111";  //  "0b11001011100000110011110111";
            strHuge = strHuge.Replace("0b", "");
            long longSum = 0;
            int intPowerOf2 = (-1 + strHuge.Length);
            long longPowerOf2_calculated = 0;
            long multiplicand = 0;
            bool boolNext = false; 

            //var binary = System.Convert.ToString(huge, 2);
            //return binary.ToString();

            foreach (char each_char in strHuge)
            {
                if (boolNext) intPowerOf2 -= 1;
                //longPowerOf2_calculated = (2 ^ intPowerOf2);
                longPowerOf2_calculated = (long)System.Math.Pow(2, intPowerOf2);
                multiplicand = long.Parse(each_char.ToString());
                //System.Diagnostics.Debugger.Log(0, "", " ... " + longPowerOf2_calculated.ToString());
                longSum += (multiplicand * longPowerOf2_calculated);
                boolNext = true;
            }

            return longSum;

        }

        public static long ConvertBinaryString_ToLong(string par_strHugeBinary)
        {
            //Added 1/28/2019  thomas downes 
            //string strHuge = "0b11001011100000110011110111";
            string strHuge = par_strHugeBinary;
            
            strHuge = strHuge.Replace("0b", "");
            strHuge = strHuge.Replace(" ", "");
            strHuge = strHuge.Replace("-", "");
            strHuge = strHuge.Replace("_", "");

            long longSum = 0;
            int intPowerOf2 = (-1 + strHuge.Length);
            long longPowerOf2_calculated = 0;
            long multiplicand = 0;

            //var binary = System.Convert.ToString(huge, 2);
            //return binary.ToString();

            foreach (char each_char in strHuge)
            {
                intPowerOf2 -= 1;
                //longPowerOf2_calculated = (2 ^ intPowerOf2);
                longPowerOf2_calculated = (long)System.Math.Pow(2, intPowerOf2);
                multiplicand = long.Parse(each_char.ToString());
                //System.Diagnostics.Debugger.Log(0, "", " ... " + longPowerOf2_calculated.ToString());
                longSum += (multiplicand * longPowerOf2_calculated);

            }

            return longSum;

        }

        public static string ConvertLongIntegerToBinaryString(long par_longInteger)
        {
            // Example input integer:  int huge = 0b1_10010111_0000011001111011_1; 
            //  Example result:    "11001011100000110011110111"
            return System.Convert.ToString(par_longInteger, 2).ToString();

        }


    }
}
