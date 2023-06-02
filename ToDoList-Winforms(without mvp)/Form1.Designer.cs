namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.removeButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.undoneButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.priorityComboBox1 = new System.Windows.Forms.ComboBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.urgentlyCheckBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.loadInfoButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TODO LIST";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(666, 409);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.Location = new System.Drawing.Point(25, 402);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 24);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.remove_Click);
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.Location = new System.Drawing.Point(134, 402);
            this.doneButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(98, 24);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.done_Click);
            // 
            // undoneButton
            // 
            this.undoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undoneButton.Location = new System.Drawing.Point(247, 402);
            this.undoneButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.undoneButton.Name = "undoneButton";
            this.undoneButton.Size = new System.Drawing.Size(98, 24);
            this.undoneButton.TabIndex = 4;
            this.undoneButton.Text = "UNDONE";
            this.undoneButton.UseVisualStyleBackColor = true;
            this.undoneButton.Click += new System.EventHandler(this.undone_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(25, 42);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(320, 326);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            this.checkedListBox1.Leave += new System.EventHandler(this.checkedListBox1_Leave);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(570, 456);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 24);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(663, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "* Expires:";
            // 
            // priorityComboBox1
            // 
            this.priorityComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.priorityComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.priorityComboBox1.FormattingEnabled = true;
            this.priorityComboBox1.Location = new System.Drawing.Point(425, 407);
            this.priorityComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priorityComboBox1.Name = "priorityComboBox1";
            this.priorityComboBox1.Size = new System.Drawing.Size(92, 21);
            this.priorityComboBox1.TabIndex = 9;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityLabel.Location = new System.Drawing.Point(425, 377);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(75, 19);
            this.priorityLabel.TabIndex = 10;
            this.priorityLabel.Text = "* Priority";
            // 
            // urgentlyCheckBox2
            // 
            this.urgentlyCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urgentlyCheckBox2.ForeColor = System.Drawing.Color.Black;
            this.urgentlyCheckBox2.Location = new System.Drawing.Point(536, 377);
            this.urgentlyCheckBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urgentlyCheckBox2.Name = "urgentlyCheckBox2";
            this.urgentlyCheckBox2.Size = new System.Drawing.Size(112, 50);
            this.urgentlyCheckBox2.TabIndex = 13;
            this.urgentlyCheckBox2.Text = "Urgently";
            this.urgentlyCheckBox2.UseVisualStyleBackColor = true;
            this.urgentlyCheckBox2.CheckedChanged += new System.EventHandler(this.urgentlyCheckBox2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(425, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 323);
            this.textBox1.TabIndex = 14;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(743, 377);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(112, 19);
            this.timeLabel.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(879, 7);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(135, 19);
            this.descriptionLabel.TabIndex = 16;
            this.descriptionLabel.Text = "DESCRIPTION";
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveInfoButton.Location = new System.Drawing.Point(25, 456);
            this.saveInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(140, 24);
            this.saveInfoButton.TabIndex = 17;
            this.saveInfoButton.Text = "SAVE INFO";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // loadInfoButton
            // 
            this.loadInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadInfoButton.Location = new System.Drawing.Point(179, 457);
            this.loadInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadInfoButton.Name = "loadInfoButton";
            this.loadInfoButton.Size = new System.Drawing.Size(142, 24);
            this.loadInfoButton.TabIndex = 18;
            this.loadInfoButton.Text = "LOAD INFO";
            this.loadInfoButton.UseVisualStyleBackColor = true;
            this.loadInfoButton.Click += new System.EventHandler(this.loadInfoButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(764, 42);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 323);
            this.textBox2.TabIndex = 19;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 512);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.loadInfoButton);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.urgentlyCheckBox2);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.priorityComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.undoneButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button undoneButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox priorityComboBox1;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.CheckBox urgentlyCheckBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.Button loadInfoButton;
        private System.Windows.Forms.TextBox textBox2;
    }
}

