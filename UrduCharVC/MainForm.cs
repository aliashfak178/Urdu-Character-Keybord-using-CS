using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UrduCharVC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            EnglishTextBox.Clear();
            UrduTextBox.Clear();
            EnglishTextBox.Focus();
        }
        private void GetCharacters(String EngChar, String UrduChar)
        {
            EnglishTextBox.Text += EngChar;
            UrduTextBox.Text += UrduChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCharacters("A", "ا");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetCharacters("B", "ب");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetCharacters("C", "چ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetCharacters("D", "د");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetCharacters("E", "ے");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetCharacters("F", "ف");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetCharacters("G", "گ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetCharacters("H", "ح");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GetCharacters("I", "ی");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetCharacters("J", "ج");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            GetCharacters("K", "ک");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetCharacters("L", "ل");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetCharacters("M", "م");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetCharacters("N", "ن");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetCharacters("O", "او");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GetCharacters("P", "پ");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            GetCharacters("Q", "ق");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GetCharacters("R", "ر");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            GetCharacters("S", "س");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            GetCharacters("T", "ت");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            GetCharacters("U", "یو");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            GetCharacters("V", "وی");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            GetCharacters("W", "وا");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            GetCharacters("X", "خ");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            GetCharacters("Y", "ی");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            GetCharacters("Z", "ظ");
        }

        private void Space_button_Click(object sender, EventArgs e)
        {
            GetCharacters(" ", " ");
        }
      
    }
}
