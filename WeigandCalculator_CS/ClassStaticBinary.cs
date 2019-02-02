using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeigandCalculator_CS
{
    public static class ClassStaticBinary
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
            bool boolNextIteration_NotFirst = false;

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
                //1/29 td''intPowerOf2 -= 1;
                if (boolNextIteration_NotFirst) intPowerOf2 -= 1;
                //longPowerOf2_calculated = (2 ^ intPowerOf2);
                longPowerOf2_calculated = (long)System.Math.Pow(2, intPowerOf2);
                multiplicand = long.Parse(each_char.ToString());
                //System.Diagnostics.Debugger.Log(0, "", " ... " + longPowerOf2_calculated.ToString());
                longSum += (multiplicand * longPowerOf2_calculated);
                //Prepare for the next iteration. 
                boolNextIteration_NotFirst = true;

            }

            return longSum;

        }

        public static string ConvertLongIntegerToBinaryString(long par_longInteger)
        {
            //
            //Added 1/28/2019 td
            //
            // Example input integer:  int huge = 0b1_10010111_0000011001111011_1; 
            //  Example result:    "11001011100000110011110111"
            return System.Convert.ToString(par_longInteger, 2).ToString();

        }

        public static string ConvertLongIntegerToBinaryString(long par_longInteger, int par_lengthOfString)
        {
            //
            //Added 1/28/2019 td
            //
            string strTempOutput = ConvertLongIntegerToBinaryString(par_longInteger);
            int lengthOfTempOutput = strTempOutput.Length;

            if (lengthOfTempOutput < par_lengthOfString)
            {
                while (strTempOutput.Length < par_lengthOfString) strTempOutput = ("0" + strTempOutput);
                return strTempOutput;
            }
            else
            {
                return strTempOutput;
            }

        }

        public static char GetParityBit_Odd(string par_strHugeBinary)
        {
            //Added 1/28/2019 td
            return GetOddParityBit(par_strHugeBinary);
        }

        public static char GetParityBit_Odd(string par_strHugeBinary, ref int pref_intNumOnes)
        {
            //Added 1/28/2019 td
            return GetOddParityBit(par_strHugeBinary, ref pref_intNumOnes);
        }

        //public static char GetParityBit_Even(string par_strHugeBinary) // , ref int pref_intNumOnes)
        //{
        //    //Added 1/28/2019 td
        //    return GetEvenParityBit(par_strHugeBinary);
        //}

        public static char GetParityBit_Even(string par_strHugeBinary, ref int pref_intNumOnes)
        {
            //Added 1/28/2019 td
            return GetEvenParityBit(par_strHugeBinary, ref pref_intNumOnes);
        }

        public static char GetParityBit_Even(string par_strHugeBinary)
        {
            //Added 1/28/2019 td
            int int_dummy = 0; 

            return GetEvenParityBit(par_strHugeBinary, ref int_dummy);
        }

        public static char GetEvenParityBit(string par_strHugeBinary, ref int pref_intNumOnes)
        {
            //  1/29 td''public static char GetEvenParityBit(string par_strHugeBinary)
            //
            //
            //Added 1/28/2019 td
            //
            //string strHuge = par_strHugeBinary;
            //strHuge = strHuge.Replace("0b", "");
            //strHuge = strHuge.Replace(" ", "");
            //strHuge = strHuge.Replace("-", "");
            //strHuge = strHuge.Replace("_", "");

            //string strHugeBinary_NoZeros;
            //strHugeBinary_NoZeros = strHuge.Replace("0", "");
            int intNumberOfOnes = 0;
            bool boolEvenNumber = false;
            bool boolParityBitMustBe1 = false; // Added 1/29/2019 td

            //intNumberOfOnes = strHugeBinary_NoZeros.Length;
            intNumberOfOnes = GetNumberOfDigit1s(par_strHugeBinary);

            boolEvenNumber = (0 == (intNumberOfOnes % 2));
            boolParityBitMustBe1 = (false == boolEvenNumber);

            //Added 1/29/2019 thomas downes
            //   Note the number of non-Parity-positive bits, 
            //   and add the value of 1 if the Boolean is False, 
            //   because a positive-value Parity bit will be 
            //   needeed.---1/29/2019 td  
            //
            //pref_intNumOnes = (intNumberOfOnes + (int)(boolEvenNumber ? 0 : 1));
            pref_intNumOnes = (intNumberOfOnes + (int)(boolParityBitMustBe1 ? 1 : 0));

            //If the number of "1"s is 122 (intNumberOfOnes = 122, for example), then
            //   __zero(0) more__ "1"s are needed (to create an even-numbered set of 1s). 
            //
            //If the number of "1"s is 133 (intNumberOfOnes = 133, for example), then
            //   __one(1) more__ "1" is needed (to create an even-numbered set of 1s). 
            //
            //return (boolEvenNumber ? '0' : '1');
            return (boolParityBitMustBe1 ? '1' : '0');

        }

        public static char GetOddParityBit(string par_strHugeBinary)
        {
            //
            //Added 1/29/2019 td
            //
            int int_dummy = 0;
            return GetOddParityBit(par_strHugeBinary, ref int_dummy);

        }

        public static char GetOddParityBit(string par_strHugeBinary, ref int pref_intNumOnes)
        {
            //
            //Added 1/28/2019 td
            //
            //Reverse the parity bit.  
            //
            //If the number of "1"s is 133 (intNumberOfOnes = 133, for example), then
            //   __zero(0) more__ "1"s are needed (to create an odd-numbered set of 1s). 
            //
            //If the number of "1"s is 124 (intNumberOfOnes = 124, for example), then
            //   __one(1) more__ "1" is needed (to create an odd-numbered set of 1s). 
            //
            //return (GetEvenParityBit(par_strHugeBinary) == '0' ? '1' : '0');

            int intNumberOfOnes = 0;
            bool boolOddNumber = false;
            bool boolParityBitMustBe1 = false; // Added 1/29/2019 td

            intNumberOfOnes = GetNumberOfDigit1s(par_strHugeBinary);
            boolOddNumber = (1 == (intNumberOfOnes % 2));
            boolParityBitMustBe1 = (false == boolOddNumber);

            //Added 1/29/2019 thomas downes
            //pref_intNumOnes = (intNumberOfOnes + (int)(boolOddNumber ? 0 : 1));
            pref_intNumOnes = (intNumberOfOnes + (int)(boolParityBitMustBe1 ? 1 : 0));

            //return (boolOddNumber ? '0' : '1');
            return (boolParityBitMustBe1 ? '1' : '0');

        }

        private static int GetNumberOfDigit1s(string par_strHugeBinary)
        {
            //
            //Added 1/28/2019 td
            //
            string strHuge = par_strHugeBinary;
            strHuge = strHuge.Replace("0b", "");
            strHuge = strHuge.Replace(" ", "");
            strHuge = strHuge.Replace("-", "");
            strHuge = strHuge.Replace("_", "");

            string strHugeBinary_NoZeros;
            strHugeBinary_NoZeros = strHuge.Replace("0", "");
            int intNumberOfOnes;
            intNumberOfOnes = strHugeBinary_NoZeros.Length;
            return intNumberOfOnes;

        }

    }
}
