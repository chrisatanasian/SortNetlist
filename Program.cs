using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SortNetlist {
    static class Program {
        private static Dictionary<string, double> netlist = new Dictionary<string, double>();
        private static Dictionary<string, double> groupMaxs = new Dictionary<string, double>();
        private static List<string> groups = new List<string> { "FMC_LA", "FMC_HA", "FMC_HB" };

        /// <summary>
        /// Adds contents of fileName to netlist data
        /// </summary>
        public static void AddToDictionary(string fileName) {
            var lines = System.IO.File.ReadAllLines(fileName);

            string[] separators = { "\t" };

            foreach (string line in lines) {
                string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                netlist[words[0]] = Convert.ToDouble(words[1]);
            }
        }

        /// <summary>
        /// Removes all elements from the netlist dictionary.
        /// </summary>
        public static void ClearDictionaries() {
            netlist.Clear();
            groupMaxs.Clear();
        }

        public static void ChangeGroups(string groupTextBox) {
            string[] groupNames = groupTextBox.Split(',');

            groups.Clear();
            foreach (string groupName in groupNames) {
                groups.Add(groupName.Replace(" ", ""));
            }
        }

        /// <summary>
        /// Determines whether strings of the same size differ by 1 char AND if they differ by a n/p or a +/-.
        /// </summary>
        public static bool StringsDifferByOne(string string1, string string2) {
            int amtDiffer = 0;
            int difference = 0;

            if (string1.Length != string2.Length) {
                return false;
            }

            for (int i = 0; i < string1.Length; i++) {
                if (string1[i] != string2[i]) {
                    amtDiffer += 1;

                    if ((string1[i] == 'N' && string2[i] == 'P') || (string2[i] == 'N' && string1[i] == 'P')) {
                        difference++;
                    }
                    else if ((string1[i] == '+' && string2[i] == '-') || (string2[i] == '+' && string1[i] == '-')) {
                        difference++;
                    }
                }
                if (amtDiffer > 1 || difference > 1)
                    return false;
            }

            if (amtDiffer == 0) {
                return false;
            }
            else {
                return (difference == 1);
            }
        }

        /// <summary>
        /// Takes a raw netlist file, which contains useless data in the beginning and end, and removes it.
        /// Also removes data except for the first and last parts.
        /// Outputs the new file with _sorted.txt at the end.
        /// If first line of file is not "Net Status Report",
        /// then it copies all the data into the _sorted file.
        /// </summary>
        /// <param name="fileName">Name of the file to process.</param>
        public static void ConvertRawToProcessed(string fileName) {
            var lines = System.IO.File.ReadAllLines(fileName);

            if (lines[0].Equals("Net Status Report")) {
                int counter = 0;
                StreamWriter fileOutput = new StreamWriter(fileName.Replace(".txt", "_sorted.txt"));
                string[] separators = { ",", "\t" };

                foreach (string line in lines) {
                    if (counter >= 7 && counter < lines.Length - 1) {
                        string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < words.Length; i++) {
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
            else {
                System.IO.File.Copy(fileName, fileName.Replace(".txt", "_sorted.txt"), true);
            }

        }

        /// <summary>
        /// Sorts the netlist by checking the left column to see if strings are different by 1.
        /// Outputs into a new file.
        /// Also adds the deltas in a new column.
        /// </summary>
        public static void SortNetlistAddDelta(string fileName) {
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

            fileOutput.Close();
        }

        /// <summary>
        /// Goes through all groups, finds the maximums, and adds the key-value pair to groupMaxs.
        /// </summary>
        public static void FindGroupMaxs() {
            foreach (string group in groups) {
                double max = -1;

                foreach (KeyValuePair<string, double> entry in netlist) {
                    // See if the current key matches to any group.
                    if (entry.Key.Length > group.Length) {
                        string keySubstring = entry.Key.Substring(0, group.Length);

                        if (group.Equals(keySubstring) && entry.Value > max) {
                            max = entry.Value;
                        }
                    }
                }

                groupMaxs.Add(group, max);
            }
        }

        /// <summary>
        /// Adds differences between N/P and group maximums and current key.
        /// </summary>
        public static void AddDeltaGroupMaxDiffs(string fileName) {
            StreamWriter fileOutput = new StreamWriter(fileName);
            Dictionary<string, double> addedKeys = new Dictionary<string, double>();

            foreach (KeyValuePair<string, double> entry in netlist) {
                if (!addedKeys.ContainsKey(entry.Key)) {
                    int len = groups[0].Length;

                    if (entry.Key.Length >= len) {
                        string key = entry.Key.Substring(0, len);

                        if (!groups.Contains(key)) {
                            fileOutput.WriteLine(entry.Key + "\t" + entry.Value);
                        }
                        else {
                            double diff = groupMaxs[key] - entry.Value;
                            fileOutput.WriteLine(entry.Key + "\t" + entry.Value + "\t\t" + diff);
                        }
                    }
                    else {
                        fileOutput.WriteLine(entry.Key + "\t" + entry.Value);
                    }

                    addedKeys[entry.Key] = entry.Value;
                }

                string key_with_p = entry.Key.Replace("_N", "_P");
                if (netlist.ContainsKey(key_with_p) && !addedKeys.ContainsKey(key_with_p)) {
                    int len = groups[0].Length;

                    if (key_with_p.Length >= len) {
                        string key = key_with_p.Substring(0, len);

                        if (!groups.Contains(key)) {
                            fileOutput.WriteLine(key_with_p + "\t" + netlist[key_with_p] + "\t" + (netlist[key_with_p] - netlist[entry.Key]));
                        }
                        else {
                            double diff = groupMaxs[key] - entry.Value;
                            fileOutput.WriteLine(key_with_p + "\t" + netlist[key_with_p] + "\t" + (netlist[key_with_p] - netlist[entry.Key]) + "\t" + diff);
                        }
                    }
                    else {
                        fileOutput.WriteLine(key_with_p + "\t" + netlist[key_with_p] + "\t" + (netlist[key_with_p] - netlist[entry.Key]));
                    }
                    addedKeys[key_with_p] = netlist[key_with_p];
                }
            }

            fileOutput.Close();
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mf = new MainForm();
            Application.Run(mf);
        }
    }
}