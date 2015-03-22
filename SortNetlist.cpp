// SortNetlist.cpp : main project file.

#include "stdafx.h"
#include "Form1.h"
#include <iostream>
#include <fstream>
#include <cstring>
#include <vector>
#include <sstream>
#include <stdlib.h>

using namespace SortNetlist;
using namespace std;

// @return bool whether strings of the same size differ by 1 char AND if they differ by a n/p or a +/-
bool stringsDifferByOne(string string1, string string2) {
    int amtDiffer = 0;
    int difference = 0;

    if (string1.size() != string2.size())
        return false;

    for (unsigned int i=0; i<=string1.size(); i++) {
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

// for pairs of n/p and +/-, adds a field of their difference
void deltaAdd(std::string filename) {
   char* cstr1 = new char[filename.size()+1];
   strcpy(cstr1,filename.c_str());
   ifstream fileInput;
   fileInput.open(cstr1);

   filename.replace(filename.size() - 4, 4,"_delta.txt");
   char* cstr2 = new char[filename.size()+1];
   strcpy(cstr2,filename.c_str());
   ofstream fileOutput;
   fileOutput.open(cstr2);

   string stringPrevious = "", dataPrevious = "", stringCurrent, dataCurrent, line;

   if (fileInput) {
      while (getline(fileInput,line)) {
         stringCurrent = line.substr(0,int(line.find("\t")));
         dataCurrent = line.substr(int(line.find("\t"))+1,line.size()-int(line.find("\t")));
         if (stringsDifferByOne(stringCurrent,stringPrevious)) {
            float delta = atof(dataPrevious.c_str()) - atof(dataCurrent.c_str());
            fileOutput << line << "\t";
            fileOutput << delta << endl;
         }
         else
            fileOutput << line << endl;
        stringPrevious = stringCurrent;
        dataPrevious = dataCurrent;
      }
   }
}

// sorts the netlist by checking the left column to see if strings are different by 1
// outputs the sorted list into a new file called sortedNetlist.txt
void sortNetlist(string filename) {
   char* cstr1 = new char[filename.size()+1];
   strcpy(cstr1,filename.c_str());
   ifstream fileInput;
   fileInput.open(cstr1);

   filename.replace(filename.size() - 4, 4,"_sorted.txt");
   char* cstr2 = new char[filename.size()+1];
   strcpy(cstr2,filename.c_str());
   ofstream fileOutput;
   fileOutput.open(cstr2);

   int totalbytes = 0;
   vector<string> stringsUsed;

   string line, stringPrevious, stringCurrent;

   if (fileInput) {
      while (getline(fileInput,line))
      {
         stringPrevious = line.substr(0,int(line.find("\t")));
         totalbytes += line.size() + 1;

         streampos pos = fileInput.tellg();

         bool inStringsUsed = false;

         for (unsigned int i=0; i<stringsUsed.size(); i++) {
            if (stringsUsed[i].compare(stringPrevious) == 0) {
               inStringsUsed = true;
               break;
            }
         }

         if (!inStringsUsed) {
            if (stringPrevious.compare("\n") != 0) {
               if (line.compare("") != 0)
                  fileOutput << line << endl;
               stringsUsed.push_back(stringPrevious);

               while (getline(fileInput,line)) {
                  stringCurrent = line.substr(0,int(line.find("\t")));

                  if (stringsDifferByOne(stringPrevious,stringCurrent)) {
                     fileOutput << line << endl;
                     stringsUsed.push_back(stringCurrent);
                     break;
                  }
               }
            }
         }
         fileInput.clear();
         fileInput.seekg(totalbytes, ios::beg);
      }
   }

   fileInput.close();
   fileOutput.close();
}

[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	// Enabling Windows XP visual effects before any controls are created
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	//cout << "Enter your filename:\n";
	//string filename;
	//cin >> filename;

	//sortNetlist(filename);
	//string newFilename = filename.replace(filename.size() - 4, 4,"_sorted.txt");
	//deltaAdd(newFilename);

	//cout << "Done sorting.";

	// Create the main window and run it
	Application::Run(gcnew Form1());
	return 0;
}