using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sequence = txtInput.Text;

            string resultWithoutDigits = RemoveDigits(sequence);
            lblWithoutDigitsResult.Text = "Послідовність без цифр: " + resultWithoutDigits;

            string oldSubstring = "карб";
            string newSubstring = "грн";
            string resultReplacedSubstring = ReplaceSubstring(sequence, oldSubstring, newSubstring);
            lblReplaceResult.Text = "Результат заміни: " + resultReplacedSubstring;
        }
        private string RemoveDigits(string input)
        {
            return Regex.Replace(input, @"\d", "");
        }

        private string ReplaceSubstring(string input, string oldSubstring, string newSubstring)
        {
            return input.Replace(oldSubstring, newSubstring);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblReplaceResult.Text = "";
            lblWithoutDigitsResult.Text = "";

        }
    }
}






