namespace BookList.View
{
    partial class MainForm
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
            this.ListBoxBook = new System.Windows.Forms.ListBox();
            this.SelectedBookGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfPagesTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelet = new System.Windows.Forms.Button();
            this.SelectedBookGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxBook
            // 
            this.ListBoxBook.FormattingEnabled = true;
            this.ListBoxBook.Location = new System.Drawing.Point(13, 17);
            this.ListBoxBook.Name = "ListBoxBook";
            this.ListBoxBook.Size = new System.Drawing.Size(174, 381);
            this.ListBoxBook.TabIndex = 0;
            this.ListBoxBook.SelectedIndexChanged += new System.EventHandler(this.ListBoxBook_SelectedIndexChanged);
            // 
            // SelectedBookGroupBox
            // 
            this.SelectedBookGroupBox.Controls.Add(this.NumberOfPagesTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.AuthorTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.ReleaseDateTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.label4);
            this.SelectedBookGroupBox.Controls.Add(this.GenreComboBox);
            this.SelectedBookGroupBox.Controls.Add(this.label5);
            this.SelectedBookGroupBox.Controls.Add(this.label3);
            this.SelectedBookGroupBox.Controls.Add(this.label2);
            this.SelectedBookGroupBox.Controls.Add(this.label1);
            this.SelectedBookGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedBookGroupBox.Location = new System.Drawing.Point(193, 17);
            this.SelectedBookGroupBox.Name = "SelectedBookGroupBox";
            this.SelectedBookGroupBox.Size = new System.Drawing.Size(358, 166);
            this.SelectedBookGroupBox.TabIndex = 1;
            this.SelectedBookGroupBox.TabStop = false;
            this.SelectedBookGroupBox.Text = "SelectedBook";
            // 
            // NumberOfPagesTextBox
            // 
            this.NumberOfPagesTextBox.Location = new System.Drawing.Point(105, 97);
            this.NumberOfPagesTextBox.Name = "NumberOfPagesTextBox";
            this.NumberOfPagesTextBox.Size = new System.Drawing.Size(202, 20);
            this.NumberOfPagesTextBox.TabIndex = 13;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(105, 71);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(202, 20);
            this.AuthorTextBox.TabIndex = 12;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // ReleaseDateTextBox
            // 
            this.ReleaseDateTextBox.Location = new System.Drawing.Point(105, 45);
            this.ReleaseDateTextBox.Name = "ReleaseDateTextBox";
            this.ReleaseDateTextBox.Size = new System.Drawing.Size(202, 20);
            this.ReleaseDateTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of pages:";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(105, 123);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(202, 21);
            this.GenreComboBox.TabIndex = 9;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(58, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(56, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Date:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(202, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(13, 415);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "ButtonAdd";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelet
            // 
            this.ButtonDelet.Location = new System.Drawing.Point(112, 415);
            this.ButtonDelet.Name = "ButtonDelet";
            this.ButtonDelet.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelet.TabIndex = 3;
            this.ButtonDelet.Text = "ButtonDelet";
            this.ButtonDelet.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.ButtonDelet);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.SelectedBookGroupBox);
            this.Controls.Add(this.ListBoxBook);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.SelectedBookGroupBox.ResumeLayout(false);
            this.SelectedBookGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox ReleaseDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox NumberOfPagesTextBox;
        private System.Windows.Forms.ComboBox GenreComboBox;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label5;
        

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelet;
        

        private System.Windows.Forms.TextBox NameTextBox;

        private System.Windows.Forms.GroupBox SelectedBookGroupBox;

        private System.Windows.Forms.ListBox ListBoxBook;

        #endregion
    }
}