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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectedBookGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.CountOfPagesTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.SelectedBookGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedBookGroupBox
            // 
            this.SelectedBookGroupBox.Controls.Add(this.AuthorTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.CountOfPagesTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.ReleaseDateTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.label4);
            this.SelectedBookGroupBox.Controls.Add(this.GenreComboBox);
            this.SelectedBookGroupBox.Controls.Add(this.label5);
            this.SelectedBookGroupBox.Controls.Add(this.label3);
            this.SelectedBookGroupBox.Controls.Add(this.label2);
            this.SelectedBookGroupBox.Controls.Add(this.label1);
            this.SelectedBookGroupBox.Location = new System.Drawing.Point(193, 17);
            this.SelectedBookGroupBox.Name = "SelectedBookGroupBox";
            this.SelectedBookGroupBox.Size = new System.Drawing.Size(358, 166);
            this.SelectedBookGroupBox.TabIndex = 1;
            this.SelectedBookGroupBox.TabStop = false;
            this.SelectedBookGroupBox.Text = "SelectedBook";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(105, 72);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(202, 20);
            this.AuthorTextBox.TabIndex = 15;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(105, 19);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(202, 20);
            this.FullNameTextBox.TabIndex = 14;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // CountOfPagesTextBox
            // 
            this.CountOfPagesTextBox.Location = new System.Drawing.Point(105, 97);
            this.CountOfPagesTextBox.Name = "CountOfPagesTextBox";
            this.CountOfPagesTextBox.Size = new System.Drawing.Size(202, 20);
            this.CountOfPagesTextBox.TabIndex = 13;
            this.CountOfPagesTextBox.TextChanged += new System.EventHandler(this.NumberOfPagesTextBox_TextChanged);
            // 
            // ReleaseDateTextBox
            // 
            this.ReleaseDateTextBox.Location = new System.Drawing.Point(105, 45);
            this.ReleaseDateTextBox.Name = "ReleaseDateTextBox";
            this.ReleaseDateTextBox.Size = new System.Drawing.Size(202, 20);
            this.ReleaseDateTextBox.TabIndex = 11;
            this.ReleaseDateTextBox.TextChanged += new System.EventHandler(this.ReleaseDateTextBox_TextChanged);
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
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (235)))), ((int) (((byte) (235)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::BookList.Properties.Resources.remove_24x24_uncolor;
            this.DeleteButton.Location = new System.Drawing.Point(69, 404);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 26);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.DeleteButton_MouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.DeleteButton_MouseLeave);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (235)))), ((int) (((byte) (235)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::BookList.Properties.Resources.add_24x24_uncolor;
            this.AddButton.Location = new System.Drawing.Point(13, 404);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 26);
            this.AddButton.TabIndex = 4;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.Location = new System.Drawing.Point(13, 17);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(174, 381);
            this.BookListBox.TabIndex = 5;
            this.BookListBox.SelectedIndexChanged += new System.EventHandler(this.BookListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.BookListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SelectedBookGroupBox);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Book list";
            this.SelectedBookGroupBox.ResumeLayout(false);
            this.SelectedBookGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox BookListBox;

        private System.Windows.Forms.TextBox FullNameTextBox;

        private System.Windows.Forms.TextBox CountOfPagesTextBox;

        private System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.Button DeleteButton;

        private System.Windows.Forms.TextBox ReleaseDateTextBox;
        private System.Windows.Forms.Label label4;
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

        private System.Windows.Forms.TextBox AuthorTextBox;
    }
}