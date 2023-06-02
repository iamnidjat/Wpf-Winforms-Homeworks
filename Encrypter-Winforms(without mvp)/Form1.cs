using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private const string letters = "abcdefghijklmnopqrstuvwxy";
        private const string inputPath = "Input path...";
        private const string outputPath = "Output path...";
        private const string enterTextOrFile = "Enter a text..."; 

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modeComboBox1.Items.Add("ENCRYPT");
            modeComboBox1.Items.Add("DECRYPT");

            cyphertypeComboBox.Items.Add("Caesar Сipher");
            cyphertypeComboBox.Items.Add("XOR Сipher");
            cyphertypeComboBox.Items.Add("Bitwise Inversion");

            textBox3.Text = inputPath;
            textBox4.Text = outputPath;
            textBox1.Text = enterTextOrFile;

            checkBox1.Enabled = false;
        }

        private string caesarСipher(string text, int key)
        {
            var fullLetters = letters;
            var newText = "";
            var len = fullLetters.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var index = fullLetters.IndexOf(text[i]);

                if (index < 0)
                {
                    newText += text[i];
                }

                else
                {
                    int temp = (len + index + key) % len;
                    newText += fullLetters[temp];
                }

            }

            return newText;
        }

        private string xorСipher(string text, int key)
        {
            var newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                newText += (char)(text[i] ^ key);
            }

            return newText;
        }

        private string bitwiseInversion(string text)
        {
            var newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                newText += (char)~text[i];
            }

            return newText;
        }

        private void modeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeComboBox1.SelectedIndex == 0)
            {
                modeButton.Text = "ENCRYPT";
            }

            else if (modeComboBox1.SelectedIndex == 1)
            {
                modeButton.Text = "DECRYPT";
            }
        }


        private void modeButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            int len = textBox1.Text.Length * 2;

            if (modeComboBox1.SelectedIndex == 0 && cyphertypeComboBox.SelectedIndex == 0 && textBox1.Text != String.Empty && textBox1.Text != enterTextOrFile)
            {
                textBox2.AppendText(caesarСipher(textBox1.Text.ToLower(), 5));
                modeComboBox1.SelectedIndex = -1;
                cyphertypeComboBox.SelectedIndex = -1;
                modeButton.Text = String.Empty;

                if (progressBar1.Value + len >= 100)
                {
                    progressBar1.Value = 100;
                }

                else
                {
                    progressBar1.Value += len;
                }
               
                label1.Text = $"{progressBar1.Value}%";
            }

            else if (modeComboBox1.SelectedIndex == 0 && cyphertypeComboBox.SelectedIndex == 1 && textBox1.Text != String.Empty && textBox1.Text != enterTextOrFile)
            {
                textBox2.AppendText(xorСipher(textBox1.Text.ToLower(), 5));
                modeComboBox1.SelectedIndex = -1;
                cyphertypeComboBox.SelectedIndex = -1;
                modeButton.Text = String.Empty;

                if (progressBar1.Value + len >= 100)
                {
                    progressBar1.Value = 100;
                }

                else
                {
                    progressBar1.Value += len;
                }

                label1.Text = $"{progressBar1.Value}%";
            }

            else if (modeComboBox1.SelectedIndex == 0 && cyphertypeComboBox.SelectedIndex == 2 && textBox1.Text != String.Empty && textBox1.Text != enterTextOrFile)
            {
                textBox2.AppendText(bitwiseInversion(textBox1.Text.ToLower()));
                modeComboBox1.SelectedIndex = -1;
                cyphertypeComboBox.SelectedIndex = -1;
                modeButton.Text = String.Empty;

                if (progressBar1.Value + len >= 100)
                {
                    progressBar1.Value = 100;
                }

                else
                {
                    progressBar1.Value += len;
                }

                label1.Text = $"{progressBar1.Value}%";
            }

            else if (modeComboBox1.SelectedIndex == 1 && cyphertypeComboBox.SelectedIndex == 0 && textBox1.Text != String.Empty && textBox1.Text != enterTextOrFile)
            {
                textBox2.AppendText(caesarСipher(textBox1.Text.ToLower(), -5));
                modeComboBox1.SelectedIndex = -1;
                cyphertypeComboBox.SelectedIndex = -1;
                modeButton.Text = String.Empty;

                if (progressBar1.Value + len >= 100)
                {
                    progressBar1.Value = 100;
                }

                else
                {
                    progressBar1.Value += len;
                }

                label1.Text = $"{progressBar1.Value}%";
            }

            else if (modeComboBox1.SelectedIndex == 1 && cyphertypeComboBox.SelectedIndex == 1 && textBox1.Text != String.Empty && textBox1.Text != enterTextOrFile)
            {
                textBox2.AppendText(xorСipher(textBox1.Text.ToLower(), -5));
                modeComboBox1.SelectedIndex = -1;
                cyphertypeComboBox.SelectedIndex = -1;
                modeButton.Text = String.Empty;

                if (progressBar1.Value + len >= 100)
                {
                    progressBar1.Value = 100;
                }

                else
                {
                    progressBar1.Value += len;
                }

                label1.Text = $"{progressBar1.Value}%";
            }

            else if (modeComboBox1.SelectedIndex == 1 && cyphertypeComboBox.SelectedIndex == 2 && textBox1.Text != String.Empty && textBox1.Text != enterTextOrFile)
            {
                textBox2.AppendText(bitwiseInversion(textBox1.Text.ToLower()));
                modeComboBox1.SelectedIndex = -1;
                cyphertypeComboBox.SelectedIndex = -1;
                modeButton.Text = String.Empty;

                if (progressBar1.Value + len >= 100)
                {
                    progressBar1.Value = 100;
                }

                else
                {
                    progressBar1.Value += len;
                }

                label1.Text = $"{progressBar1.Value}%";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "0%";

            if (textBox3.Text != inputPath)
            {
                return;
            }

            textBox3.Text = string.Empty;

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {

            if (textBox4.Text != outputPath)
            {
                return;
            }

            textBox4.Text = string.Empty;

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >  0)
            {
                return;
            }

            textBox3.Text = inputPath;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                return;
            }
            textBox4.Text = outputPath;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "0%";

            if (textBox1.Text.Length > 0)
            {
                return;
            }

            textBox1.Text = enterTextOrFile;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text != enterTextOrFile)
            {
                return;
            }

            textBox1.Text = string.Empty;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != String.Empty && textBox3.Text != inputPath)
            {
                checkBox1.Enabled = true;

                if (File.Exists(textBox3.Text))
                {
                    string fileText = File.ReadAllText(textBox3.Text);
                    textBox1.Text = fileText;
                }

                else
                {
                    MessageBox.Show
                    (
                        text: "This file doesn`t exist!",
						caption: "Information",
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Information
                    );
                }
            }          
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && textBox2.Text != String.Empty)
            {
                using (StreamWriter writer = new StreamWriter(textBox3.Text, true))
                {
                    writer.WriteLine(textBox2.Text);
                }               
            }

            else if (!checkBox1.Checked && textBox2.Text != String.Empty)
            {
                string path = textBox4.Text;

                FileInfo file = new FileInfo(path);

                if (!file.Exists)
                {
                    using (StreamWriter sw = file.CreateText())
                    {
                        sw.WriteLine(textBox2.Text);
                    }
                }

                else
                {
                    MessageBox.Show
                   (
                       text: "This file has already exist!",
                       caption: "Information",
                       buttons: MessageBoxButtons.OK,
                       icon: MessageBoxIcon.Information
                   );
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Enabled = false;
                return;
            }

            textBox4.Enabled = true;          
        }
    }
}
