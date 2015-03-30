﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace SortNetlist
{
    static class Program
    {
        static Dictionary<string, double> netlist = new Dictionary<string, double>();

        static void convertRawToProcessed(string fileName) {
            var lines = System.IO.File.ReadAllLines(fileName);
            StreamWriter fileOutput = new StreamWriter(fileName.Substring(0, fileName.Length - 4) + "_processed.txt");

            int counter = 0;
            string[] separators = { ",", "\t" };

            foreach (string line in lines) {
                if (counter >= 7 && counter < lines.Length - 1) {
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int i=0; i<words.Length; i++) {
                        if (i == 0) {
                            fileOutput.Write(words[i].Substring(4) + "\t");
                        }
                        else if (i == 2) {
                            fileOutput.Write(words[i].Substring(0, words[i].Length - 2));
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

        static void addToDictionary(string fileName) {
            var lines = System.IO.File.ReadAllLines(fileName);

            string[] separators = { "\t" };

            foreach (string line in lines) {
                string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                netlist[words[0]] = Convert.ToDouble(words[1]);
            }
        }



        // sorts the netlist by checking the left column to see if strings are different by 1
        // outputs the sorted list into a new file called sortedNetlist.txt
        // also adds the deltas in a new column
        static void sortNetlistAddDelta(string fileName) {
            StreamWriter fileOutput = new StreamWriter(fileName);
            Dictionary<string, double> addedKeys = new Dictionary<string, double>();

            foreach (KeyValuePair<string, double> entry in netlist) {
                if (!addedKeys.ContainsKey(entry.Key)) {
                    fileOutput.WriteLine(entry.Key + "\t" + entry.Value);
                    addedKeys[entry.Key] = entry.Value;
                }

                string key_with_p = entry.Key.Replace("_N", "_P");
                if (netlist.ContainsKey(key_with_p) && !addedKeys.ContainsKey(key_with_p)) {
                    fileOutput.WriteLine(key_with_p + "\t" + netlist[key_with_p] + "\t" + (netlist[key_with_p] - netlist[entry.Key]));
                    addedKeys[key_with_p] = netlist[key_with_p];
                }
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

            //Console.WriteLine(stringsDifferByOne("FMC2_LA_N26", "FMC2_LA_P26"));
            convertRawToProcessed(@"C:\Users\Chris\Desktop\SortNetlist\netlist_raw.txt");
            addToDictionary(@"C:\Users\Chris\Desktop\SortNetlist\netlist_raw_processed.txt");
            sortNetlistAddDelta(@"C:\Users\Chris\Desktop\SortNetlist\netlist_raw_processed_sorted.txt");
        }
    }
}
