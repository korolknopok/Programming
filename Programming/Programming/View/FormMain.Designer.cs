using System.ComponentModel;

namespace Programming.View
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EnumTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GOButton = new System.Windows.Forms.Button();
            this.SeasonNamesComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueWeekdayBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumarationsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.EnumTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnumTabPage);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // EnumTabPage
            // 
            this.EnumTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumTabPage.Name = "EnumTabPage";
            this.EnumTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumTabPage.Size = new System.Drawing.Size(792, 459);
            this.EnumTabPage.TabIndex = 1;
            this.EnumTabPage.Text = "Enums";
            this.EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GOButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonNamesComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(412, 263);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(363, 187);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GOButton
            // 
            this.GOButton.Location = new System.Drawing.Point(188, 53);
            this.GOButton.Name = "GOButton";
            this.GOButton.Size = new System.Drawing.Size(89, 53);
            this.GOButton.TabIndex = 3;
            this.GOButton.Text = "GO!";
            this.GOButton.UseVisualStyleBackColor = true;
            this.GOButton.Click += new System.EventHandler(this.GOButton_Click);
            // 
            // SeasonNamesComboBox
            // 
            this.SeasonNamesComboBox.FormattingEnabled = true;
            this.SeasonNamesComboBox.Location = new System.Drawing.Point(16, 66);
            this.SeasonNamesComboBox.Name = "SeasonNamesComboBox";
            this.SeasonNamesComboBox.Size = new System.Drawing.Size(142, 24);
            this.SeasonNamesComboBox.TabIndex = 2;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(16, 39);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(149, 24);
            this.ChooseSeasonLabel.TabIndex = 1;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(6, 263);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(391, 187);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(236, 53);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(86, 53);
            this.ParseWeekdayButton.TabIndex = 4;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(19, 105);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(166, 46);
            this.OutputWeekdayLabel.TabIndex = 3;
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(19, 68);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(198, 22);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.Location = new System.Drawing.Point(19, 41);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(173, 24);
            this.TypeValueLabel.TabIndex = 0;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.ValueWeekdayBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumarationsLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(769, 251);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // ValueWeekdayBox
            // 
            this.ValueWeekdayBox.Location = new System.Drawing.Point(406, 58);
            this.ValueWeekdayBox.Name = "ValueWeekdayBox";
            this.ValueWeekdayBox.Size = new System.Drawing.Size(117, 22);
            this.ValueWeekdayBox.TabIndex = 9;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.Location = new System.Drawing.Point(406, 33);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(116, 22);
            this.IntValueLabel.TabIndex = 8;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.Location = new System.Drawing.Point(200, 33);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(132, 22);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumarationsLabel
            // 
            this.EnumarationsLabel.Location = new System.Drawing.Point(12, 33);
            this.EnumarationsLabel.Name = "EnumarationsLabel";
            this.EnumarationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnumarationsLabel.Size = new System.Drawing.Size(150, 22);
            this.EnumarationsLabel.TabIndex = 6;
            this.EnumarationsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(200, 58);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(132, 148);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(12, 58);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(132, 148);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.EnumTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox ValueWeekdayBox;

        private System.Windows.Forms.Label EnumarationsLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label IntValueLabel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label OutputWeekdayLabel;

        private System.Windows.Forms.ListBox ValuesListBox;

        private System.Windows.Forms.ListBox EnumsListBox;

        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.Button GOButton;

        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.ComboBox SeasonNamesComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label TypeValueLabel;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TabPage EnumTabPage;

        private System.Windows.Forms.TabControl tabControl1;

        private System.Windows.Forms.TabControl EnumTabControl;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}