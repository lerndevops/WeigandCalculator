using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Added 2/1/2019 td 

namespace WeigandCalculator_CS
{
    class ClassStaticHexadecimal
    {

        public static string ConvertLongIntegerToHexadecimal(long par_longInteger, int par_lengthOfString)
        {
            //
            //Added 2/1/2019 td
            //
            string strTempOutput = ConvertLongIntegerToHexadecimal(par_longInteger);
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

        public static string ConvertLongIntegerToHexadecimal(long par_longInteger)
        {
            //
            //Added 1/28/2019 td
            //
            // Example input integer:  int huge = 16; 
            //  Example result:    "10"
            //
            // 2-1-2019 td''return System.Convert.ToString(par_longInteger, 2).ToString();
            return System.Convert.ToString(par_longInteger, 8).ToString();

        }

        public static string ConvertDecimalToHex(string par_strDecimalValue)
        {
            //
            //Added 2/1/2019 thomas downes 
            //
            string strErrorMessage = "";
            string strOutputHexString = "";

            strOutputHexString = CIHexToDecimal_Strings.modDecToHexByStrings.ConvertDecToHex(par_strDecimalValue, ref strErrorMessage);

            //Added 2/1/2019 thomas downes 
            if (0 != strErrorMessage.Length) System.Windows.Forms.MessageBox.Show(strErrorMessage, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);

            return strOutputHexString;


        }

    }
}
