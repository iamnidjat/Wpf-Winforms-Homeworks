using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string writeTask = "Write a task to add (fields marked with * are required!)...";
        private const string writeDescription = "Write a description of a task...";
        private DateTime diff;
        private List<string> descriptions = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diff = DateTime.Now;

            textBox1.Text = writeTask;
            textBox2.Text = writeDescription;
            priorityComboBox1.Items.Add("Low");
            priorityComboBox1.Items.Add("Medium");
            priorityComboBox1.Items.Add("High");
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text != String.Empty)
            {
                try
                {
                    checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);              
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException("Incorrect datas!");
                }
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text != String.Empty && checkedListBox1.SelectedIndex != -1 && !checkedListBox1.Text.Contains(" [V]"))
            {
                checkedListBox1.Items[checkedListBox1.SelectedIndex] += " [V]";                            
            }
        }

        private void undone_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text != String.Empty && checkedListBox1.SelectedIndex != -1 && !checkedListBox1.Text.Contains(" [X]"))
            {
                checkedListBox1.Items[checkedListBox1.SelectedIndex] += " [X]";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == writeTask || textBox2.Text == writeDescription || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || priorityComboBox1.SelectedIndex == -1 || timeLabel.Text == String.Empty || (dateTimePicker1.Value - diff).Days < 0)  
            {
                return;
            }

            else
            {
                try
                {
                    checkedListBox1.Items.Add(textBox1.Text);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException("Incorrect datas!");
                }

                descriptions.Add(textBox2.Text);
                priorityComboBox1.SelectedIndex = -1;
                urgentlyCheckBox2.Checked = false;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                timeLabel.Text = string.Empty;
            }

            textBox1.Text = writeTask;
            textBox2.Text = writeDescription;
        }

        private void urgentlyCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (urgentlyCheckBox2.Checked)
            {
                MessageBox.Show
                (
                   text: "Do it urgently!",
                   caption: "Information",
                   buttons: MessageBoxButtons.OK,
                   icon: MessageBoxIcon.Information
                );
            }          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             timeLabel.Text = dateTimePicker1.Value.ToShortDateString();            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text != writeTask)
            {
                return;
            }

            textBox1.Text = string.Empty;
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            textBox2.Text = descriptions[checkedListBox1.SelectedIndex];

            priorityComboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            urgentlyCheckBox2.Enabled = false;
            addButton.Enabled = false;
        }

        private void checkedListBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = writeTask;
            textBox2.Text = writeDescription;

            priorityComboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            urgentlyCheckBox2.Enabled = true;
            addButton.Enabled = true;
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("text.txt"))
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    sw.WriteLine($"{checkedListBox1.Items[i]} Priority: {priorityComboBox1.Items[i]}");
                }                    
            }
        }

        private void loadInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("text.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        checkedListBox1.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch(FileNotFoundException)
            {
                throw new FileNotFoundException("Incorrect datas!");
            }
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }
    }
}
