using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project02_piglatin
{
    public partial class Form1 : Form
    {
        // constant because we are adding ay to each word
        const string EXTENSION = "ay";
        const string VOWELEXTENSION = "way";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string translation = "";
            string input = textBox1.Text;
            string[] tempInput = input.Split(' ');

            // loop through the array of words
            for (int i = 0; i < tempInput.Length; i++)
            {
                // adds words with space delimiter
                translation += getPigLatin(tempInput[i]);
            }
            textBox2.Text = translation;
        }

        private string getPigLatin(string input)
        {
            string word;
            string pigLatinExtension;

            // im sure some fancy lambda expression can be used here, but this 
            // is just more readable to me
            if (input.Substring(0, 1) == "a" || input.Substring(0, 1) == "A"
                || input.Substring(0, 1) == "e" || input.Substring(0, 1) == "E"
                || input.Substring(0, 1) == "i" || input.Substring(0, 1) == "I"
                || input.Substring(0, 1) == "o" || input.Substring(0, 1) == "O"
                || input.Substring(0, 1) == "u" || input.Substring(0, 1) == "U"
                || input.Substring(0, 1) == "y" || input.Substring(0, 1) == "Y")
                pigLatinExtension = VOWELEXTENSION;
            else
                pigLatinExtension = EXTENSION;
                

            // 0 is the starting index, 1 is the ending element
            string firstLetter = input.Substring(0, 1);

            word = input.Substring(1) + firstLetter + pigLatinExtension + " ";

            return word;
        }
    }
}
