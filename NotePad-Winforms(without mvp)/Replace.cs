using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Replace : Form
    {
        private const string stringHolder = "Input...";

        NotePad np;

        public Replace(NotePad np2)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            np = np2;
        }

        private void Replace_Load(object sender, EventArgs e)
        {
            textBox1.Text = stringHolder;
            textBox2.Text = stringHolder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox1.Text != stringHolder && textBox2.Text != string.Empty && textBox2.Text != stringHolder && np.TextBox.Contains(textBox1.Text))
            {
                np.TextBox = np.TextBox.Replace(textBox1.Text, textBox2.Text);
            }

            else
            {
                MessageBox.Show
                (
                    buttons: MessageBoxButtons.OK,
                    text: $"{textBox1.Text} is not exist!",
                    caption: "Information",
                    icon: MessageBoxIcon.Information
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text != stringHolder)
            {
                return;
            }

            textBox1.Text = string.Empty;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text != stringHolder)
            {
                return;
            }

            textBox2.Text = string.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                return;
            }

            textBox1.Text = stringHolder;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                return;
            }

            textBox2.Text = stringHolder;
        }
    }
}
