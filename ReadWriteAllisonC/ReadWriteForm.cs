/*
 * Created by: Allison Cook
 * Created on: 10 May, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - String Equality with File read/write
 * This program parses a file and reads it runs through the string equality code 
 * Then out puts if the string is equal or not to a text file
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteAllisonC
{
    public partial class frmReadWrite : Form
    {
        public frmReadWrite()
        {
            InitializeComponent();

            //hide done label
            lblDone.Hide();
        }

        private bool StringsAreEqual(string string1, string string2)
        {
            //declare variable
            bool isEqual;

            //set the strings to upper case
            string1 = string1.ToUpper();
            string2 = string2.ToUpper();

            //check if the strings are equal
            if (string1 == string2)
            {
                //set the bool to true
                isEqual = true;
            }
            else
            {
                //set the bool to false
                isEqual = false;
            }

            //retrun the bool
            return isEqual;

        }

        private void btnFile_Click(object sender, EventArgs e)
        {

            //hide done label
            lblDone.Hide();

            //read each line into an array
            //each element of the array is one line of the file
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            //array of characters for when i split each line by spaces/ tabs
            char[] charSaparators = new char[] { ' ', '\t' };

            //the output where the results will go
            string output = "";

            //go through each line in the lines array
            foreach (string line in lines)
            {
                //split each line by character and put them into an array
                //for now it's only two words per line
                string[] words = line.Split(charSaparators, StringSplitOptions.RemoveEmptyEntries);


                //checking if the strings are equal
                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    //set the output to true and print it to a text file
                    output = output + "True\r\n";
                }
                else
                {
                    //set the output to false and print it to a text file
                    output = output + "False\r\n";
                }

            }

            //creating the output file and printing the output
            System.IO.File.WriteAllText(@"output.txt", output);

            //showing the label saying the checking is done
            lblDone.Show();
        }
    }
}
