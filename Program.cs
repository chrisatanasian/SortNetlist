using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SortNetlist
{
    static class Program
    {
        static void convertRawToProcessed(string fileName) {
            StreamWriter fileOutput = new StreamWriter(fileName.Substring(0, fileName.Length - 4) + "_processed.txt");

            var lines = System.IO.File.ReadAllLines(fileName);
            int counter = 0;
            string[] separators = { "," };

            foreach (string line in lines) {
                if (counter >= 7 && counter < lines.Length - 1) {
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int i=0; i<words.Length; i++) {
                        if (i != 1) {
                            if (i == 2) {
                                fileOutput.Write(words[i].Substring(0, words[i].Length - 2));
                            }
                            else {
                                fileOutput.Write(words[i] + "\t");
                            }
                        }
                    }
                    fileOutput.WriteLine();
                }
                counter++;
            }

            fileOutput.Close();
        }

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

        // sorts the netlist by checking the left column to see if strings are different by 1
        // outputs the sorted list into a new file called sortedNetlist.txt
        //static void sortNetlist(string filename) {
        //    StreamReader fileInput = new StreamReader(filename);
        //    StreamWriter fileOutput = new StreamWriter(filename.Substring(0, filename.Length - 4) + "_sorted.txt");

            
        //}

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

            //Console.WriteLine(stringsDifferByOne("FMC2_LA_N26", "FMC2_LA_P26"));
            convertRawToProcessed(@"C:\Users\Chris\Desktop\SortNetlist\netlist_raw.txt");
        }
    }
}
