using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortNetlist
{

    static class Program
    {
        // return whether strings of the same size differ by 1 char AND if they differ by a n/p or a +/-
        static bool stringsDifferByOne(string string1, string string2) {
            int amtDiffer = 0;
            int difference = 0;

            if (string1.Length != string2.Length)
                return false;
            
            for (int i=0; i<string1.Length; i++) {
                if (string1[i] != string2[i]) {
                    amtDiffer+=1;
                    if ((string1[i] == 'N' && string2[i] == 'P') || (string2[i] == 'N' && string1[i] == 'P'))
                        difference += 1;
                    else if ((string1[i] == '+' && string2[i] == '-') || (string2[i] == '+' && string1[i] == '-'))
                        difference += 1;
                }
                if (amtDiffer > 1 || difference > 1)
                    return false;
            }

            if (amtDiffer == 0)
                return false;
            else {
                if (difference == 1)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mf = new MainForm();
            //Application.Run(mf);

            Console.WriteLine(stringsDifferByOne("FMC2_LA_N26", "FMC2_LA_P26"));
        }
    }
}
