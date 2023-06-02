using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
	public partial class NotePad : Form
	{
		public NotePad()
		{
			InitializeComponent();
		}

        public string TextBox
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                string path = "Text.txt";

                FileInfo file = new FileInfo(path);

                if (!file.Exists)
                {
                    using (StreamWriter sw = file.CreateText())
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }

                else
                {
                    using (StreamWriter sw = file.AppendText())
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }
            }

            richTextBox1.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                string path = "Text.txt";

                FileInfo file = new FileInfo(path);

                if (!file.Exists)
                {
                    using (StreamWriter sw = file.CreateText())
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }

                else
                {
                    using (StreamWriter sw = file.AppendText())
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }
            }

            Application.Exit();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                richTextBox1.SelectAll();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                try
                {
                    richTextBox1.Copy();
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("Error");
                }
            }           
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                try
                {
                    richTextBox1.Cut();              
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException("Error");
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void insertDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                buttons: MessageBoxButtons.OK,
                text: "Microsoft Windows\nВерсия 21H2 (сборка ОС 19044.1526)\nКорпорация Microsoft. Все права защищены",
                caption: "Information",
                icon: MessageBoxIcon.Information
            );
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bing.com/search?q=get+help+with+notepad+in+windows&filters=guid:%224466414-en-dia%22%20lang:%22en%22&form=T00032&ocid=HelpPane-BingIA");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = !toolStripMenuItem2.Checked;

            if (!toolStripMenuItem2.Checked)
            {
                statusStrip1.Hide();
            }

            else
            {
                statusStrip1.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                string path = "Text.txt";

                FileInfo file = new FileInfo(path);

                if (!file.Exists)
                {
                    using (StreamWriter sw = file.CreateText())
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }

                else
                {
                    using (StreamWriter sw = file.AppendText())
                    {
                        sw.WriteLine(richTextBox1.Text);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "text file(*.txt)|*.txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    File.WriteAllText(dialog.FileName, richTextBox1.Text);
                }
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("WindowsFormsApp.exe");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "text file(*.txt)|*.txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    string info = File.ReadAllText(dialog.FileName);
                    richTextBox1.Text = info;
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = richTextBox1.Font;

                fontDialog.ShowDialog();

                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Checked = !toolStripMenuItem1.Checked;

            if (!toolStripMenuItem1.Checked)
            {
                richTextBox1.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Both;
            }

            else
            {
                richTextBox1.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Vertical;
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                Replace formReplace = new Replace(this);
                formReplace.Show();
            }
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                string input = Interaction.InputBox("Line Number:", "Go To", "1");

                // Приведенный выше синтаксис взят из vb.net.

                try
                {
                    if (Convert.ToInt32(input) > richTextBox1.Lines.Length)
                    {
                        MessageBox.Show
                    (
                        buttons: MessageBoxButtons.OK,
                        text: $"Total lines in the NotePad are less than {Convert.ToInt32(input)}!",
                        caption: "Information",
                        icon: MessageBoxIcon.Information
                    );
                    }

                    else
                    {
                        string[] lines = richTextBox1.Lines;
                        int len = 0;
                        for (int i = 0; i < Convert.ToInt32(input) - 1; i++)
                        {
                            len += lines[i].Length + 1;
                        }

                        richTextBox1.Focus();
                        richTextBox1.Select(len, 0);
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show
                (
                    buttons: MessageBoxButtons.OK,
                    text: "You can input only digits!",
                    caption: "Information",
                    icon: MessageBoxIcon.Information
                );
                }
            }
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fIndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                string str = Interaction.InputBox("Enter text:", "Find", "");

                // Приведенный выше синтаксис взят из vb.net.

                int foundAt = richTextBox1.Find(str);

                if (foundAt < 0)
                {
                    MessageBox.Show
                (
                    buttons: MessageBoxButtons.OK,
                    text: "This symbol is not found!",
                    caption: "Information",
                    icon: MessageBoxIcon.Information
                );
                }
            }
        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel6.Text = $"Language: {InputLanguage.CurrentInputLanguage.Culture}";

            int lineNumber = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);

            if (richTextBox1.Text != string.Empty)
            {
                toolStripStatusLabel1.Text = $"Row: {richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1}";
                toolStripStatusLabel2.Text = $"Column: {richTextBox1.Lines[lineNumber].Length}";
                toolStripStatusLabel7.Text = $"Total Lines: {richTextBox1.Lines.Length}";
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == (Keys.Control | Keys.Shift))
            {
                newWindowToolStripMenuItem_Click(sender, e);
            }

            if (e.KeyCode == Keys.CapsLock)
            {
                if (toolStripStatusLabel4.Text == "CapsLock: Off")
                {
                    toolStripStatusLabel4.Text = "CapsLock: On";
                }

                else
                {
                    toolStripStatusLabel4.Text = "CapsLock: Off";
                }
            }

            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                newToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                openToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                saveToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Shift))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.Escape)
            {
                exitToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.F5)
            {
                insertDateToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                fIndToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.F3)
            {
                findNextToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.F3 && e.Modifiers == Keys.Shift)
            {
                findPreviousToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.H && e.Modifiers == Keys.Control)
            {
                replaceToolStripMenuItem_Click(sender, e);
            }

            else if (e.KeyCode == Keys.G && e.Modifiers == Keys.Control)
            {
                goToToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
                                                                                                  