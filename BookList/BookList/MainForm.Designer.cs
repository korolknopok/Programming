namespace BookList
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
            this.ListBoxBook = new System.Windows.Forms.ListBox();
            this.SelectedBookGroupBox = new System.Windows.Forms.GroupBox();
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
            this.ListBoxBook.Size = new System.Drawing.Size(136, 381);
            this.ListBoxBook.TabIndex = 0;
            this.ListBoxBook.SelectedIndexChanged += new System.EventHandler(this.ListBoxBook_SelectedIndexChanged);
            // 
            // SelectedBookGroupBox
            // 
            this.SelectedBookGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedBookGroupBox.Location = new System.Drawing.Point(181, 17);
            this.SelectedBookGroupBox.Name = "SelectedBookGroupBox";
            this.SelectedBookGroupBox.Size = new System.Drawing.Size(370, 204);
            this.SelectedBookGroupBox.TabIndex = 1;
            this.SelectedBookGroupBox.TabStop = false;
            this.SelectedBookGroupBox.Text = "SelectedBook";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(6, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(248, 20);
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
            this.ButtonDelet.Location = new System.Drawing.Point(110, 415);
            this.ButtonDelet.Name = "ButtonDelet";
            this.ButtonDelet.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelet.TabIndex = 3;
            this.ButtonDelet.Text = "ButtonDelet";
            this.ButtonDelet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.ButtonDelet);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.SelectedBookGroupBox);
            this.Controls.Add(this.ListBoxBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SelectedBookGroupBox.ResumeLayout(false);
            this.SelectedBookGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelet;

        private System.Windows.Forms.TextBox NaextBox;

        private System.Windows.Forms.TextBox NameTextBox;

        private System.Windows.Forms.GroupBox SelectedBookGroupBox;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListBox ListBoxBook;
        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}