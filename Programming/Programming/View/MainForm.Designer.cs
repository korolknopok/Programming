using System.ComponentModel;

namespace Programming.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
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
            this.ValueWeekdayTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumarationsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.DurationMinutesMovieTextBox = new System.Windows.Forms.TextBox();
            this.YearReleaseMovieTextBox = new System.Windows.Forms.TextBox();
            this.GenreMovieTextBox = new System.Windows.Forms.TextBox();
            this.RatingMovieTextBox = new System.Windows.Forms.TextBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.NameMovieTextBox = new System.Windows.Forms.TextBox();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.NameFilmLabel = new System.Windows.Forms.Label();
            this.GenreFilmLabel = new System.Windows.Forms.Label();
            this.DurationMinutesFilmLabel = new System.Windows.Forms.Label();
            this.YearReleaseFilmLabel = new System.Windows.Forms.Label();
            this.RatingFilmLabel = new System.Windows.Forms.Label();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.YRectangleLable = new System.Windows.Forms.Label();
            this.XRectangleLabel = new System.Windows.Forms.Label();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleLabel = new System.Windows.Forms.Label();
            this.WidthRectangleLabel = new System.Windows.Forms.Label();
            this.LengthRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.RectangleTabPage = new System.Windows.Forms.TabPage();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.YSelectedTextBox = new System.Windows.Forms.TextBox();
            this.HeightSelectedTextBox = new System.Windows.Forms.TextBox();
            this.WidthSelectedTextBox = new System.Windows.Forms.TextBox();
            this.XSelectedTextBox = new System.Windows.Forms.TextBox();
            this.IdSelectedTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.EnumTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.RectangleTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Controls.Add(this.RectangleTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(600, 400);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumTabPage
            // 
            this.EnumTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumTabPage.Name = "EnumTabPage";
            this.EnumTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumTabPage.Size = new System.Drawing.Size(592, 374);
            this.EnumTabPage.TabIndex = 1;
            this.EnumTabPage.Text = "Enums";
            this.EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GOButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonNamesComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(300, 208);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(288, 161);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GOButton
            // 
            this.GOButton.Location = new System.Drawing.Point(121, 49);
            this.GOButton.Margin = new System.Windows.Forms.Padding(2);
            this.GOButton.Name = "GOButton";
            this.GOButton.Size = new System.Drawing.Size(71, 24);
            this.GOButton.TabIndex = 3;
            this.GOButton.Text = "GO!";
            this.GOButton.UseVisualStyleBackColor = true;
            this.GOButton.Click += new System.EventHandler(this.GOButton_Click);
            // 
            // SeasonNamesComboBox
            // 
            this.SeasonNamesComboBox.FormattingEnabled = true;
            this.SeasonNamesComboBox.Location = new System.Drawing.Point(4, 51);
            this.SeasonNamesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonNamesComboBox.Name = "SeasonNamesComboBox";
            this.SeasonNamesComboBox.Size = new System.Drawing.Size(113, 21);
            this.SeasonNamesComboBox.TabIndex = 2;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(5, 33);
            this.ChooseSeasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(112, 20);
            this.ChooseSeasonLabel.TabIndex = 1;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(4, 208);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(292, 161);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(121, 48);
            this.ParseWeekdayButton.Margin = new System.Windows.Forms.Padding(2);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(71, 24);
            this.ParseWeekdayButton.TabIndex = 4;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(14, 85);
            this.OutputWeekdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(124, 37);
            this.OutputWeekdayLabel.TabIndex = 3;
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(4, 49);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayTextBox.Multiline = true;
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(113, 21);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.Location = new System.Drawing.Point(4, 33);
            this.TypeValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(130, 20);
            this.TypeValueLabel.TabIndex = 0;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.ValueWeekdayTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumarationsLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(4, 0);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(584, 209);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // ValueWeekdayTextBox
            // 
            this.ValueWeekdayTextBox.Location = new System.Drawing.Point(253, 48);
            this.ValueWeekdayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValueWeekdayTextBox.Name = "ValueWeekdayTextBox";
            this.ValueWeekdayTextBox.Size = new System.Drawing.Size(89, 20);
            this.ValueWeekdayTextBox.TabIndex = 9;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.Location = new System.Drawing.Point(253, 28);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(87, 18);
            this.IntValueLabel.TabIndex = 8;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.Location = new System.Drawing.Point(129, 28);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(99, 18);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumarationsLabel
            // 
            this.EnumarationsLabel.Location = new System.Drawing.Point(4, 28);
            this.EnumarationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnumarationsLabel.Name = "EnumarationsLabel";
            this.EnumarationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnumarationsLabel.Size = new System.Drawing.Size(112, 18);
            this.EnumarationsLabel.TabIndex = 6;
            this.EnumarationsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(129, 48);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(100, 121);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(4, 48);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(100, 121);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MovieGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectangleGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(592, 374);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.DurationMinutesMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.YearReleaseMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Controls.Add(this.NameMovieTextBox);
            this.MovieGroupBox.Controls.Add(this.FindMovieButton);
            this.MovieGroupBox.Controls.Add(this.NameFilmLabel);
            this.MovieGroupBox.Controls.Add(this.GenreFilmLabel);
            this.MovieGroupBox.Controls.Add(this.DurationMinutesFilmLabel);
            this.MovieGroupBox.Controls.Add(this.YearReleaseFilmLabel);
            this.MovieGroupBox.Controls.Add(this.RatingFilmLabel);
            this.MovieGroupBox.Location = new System.Drawing.Point(292, 0);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(296, 369);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movie";
            // 
            // DurationMinutesMovieTextBox
            // 
            this.DurationMinutesMovieTextBox.Location = new System.Drawing.Point(123, 153);
            this.DurationMinutesMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DurationMinutesMovieTextBox.Name = "DurationMinutesMovieTextBox";
            this.DurationMinutesMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.DurationMinutesMovieTextBox.TabIndex = 21;
            this.DurationMinutesMovieTextBox.TextChanged += new System.EventHandler(this.DurationMinutesMovieTextBox_TextChanged);
            // 
            // YearReleaseMovieTextBox
            // 
            this.YearReleaseMovieTextBox.Location = new System.Drawing.Point(123, 114);
            this.YearReleaseMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YearReleaseMovieTextBox.Name = "YearReleaseMovieTextBox";
            this.YearReleaseMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.YearReleaseMovieTextBox.TabIndex = 20;
            this.YearReleaseMovieTextBox.TextChanged += new System.EventHandler(this.YearReleaseMovieTextBox_TextChanged);
            // 
            // GenreMovieTextBox
            // 
            this.GenreMovieTextBox.Location = new System.Drawing.Point(123, 75);
            this.GenreMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreMovieTextBox.Name = "GenreMovieTextBox";
            this.GenreMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.GenreMovieTextBox.TabIndex = 19;
            this.GenreMovieTextBox.TextChanged += new System.EventHandler(this.GenreMovieTextBox_TextChanged);
            // 
            // RatingMovieTextBox
            // 
            this.RatingMovieTextBox.Location = new System.Drawing.Point(123, 192);
            this.RatingMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RatingMovieTextBox.Name = "RatingMovieTextBox";
            this.RatingMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.RatingMovieTextBox.TabIndex = 18;
            this.RatingMovieTextBox.TextChanged += new System.EventHandler(this.RatingMovieTextBox_TextChanged);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(6, 19);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(112, 290);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // NameMovieTextBox
            // 
            this.NameMovieTextBox.Location = new System.Drawing.Point(123, 37);
            this.NameMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameMovieTextBox.Name = "NameMovieTextBox";
            this.NameMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.NameMovieTextBox.TabIndex = 17;
            this.NameMovieTextBox.TextChanged += new System.EventHandler(this.NameMovieTextBox_TextChanged);
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(123, 286);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(71, 23);
            this.FindMovieButton.TabIndex = 16;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // NameFilmLabel
            // 
            this.NameFilmLabel.Location = new System.Drawing.Point(123, 19);
            this.NameFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFilmLabel.Name = "NameFilmLabel";
            this.NameFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.NameFilmLabel.TabIndex = 8;
            this.NameFilmLabel.Text = "Name:";
            // 
            // GenreFilmLabel
            // 
            this.GenreFilmLabel.Location = new System.Drawing.Point(123, 58);
            this.GenreFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreFilmLabel.Name = "GenreFilmLabel";
            this.GenreFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.GenreFilmLabel.TabIndex = 5;
            this.GenreFilmLabel.Text = "Genre:";
            // 
            // DurationMinutesFilmLabel
            // 
            this.DurationMinutesFilmLabel.Location = new System.Drawing.Point(123, 136);
            this.DurationMinutesFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DurationMinutesFilmLabel.Name = "DurationMinutesFilmLabel";
            this.DurationMinutesFilmLabel.Size = new System.Drawing.Size(105, 15);
            this.DurationMinutesFilmLabel.TabIndex = 7;
            this.DurationMinutesFilmLabel.Text = "Duration in minutes:";
            // 
            // YearReleaseFilmLabel
            // 
            this.YearReleaseFilmLabel.Location = new System.Drawing.Point(123, 98);
            this.YearReleaseFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearReleaseFilmLabel.Name = "YearReleaseFilmLabel";
            this.YearReleaseFilmLabel.Size = new System.Drawing.Size(106, 15);
            this.YearReleaseFilmLabel.TabIndex = 6;
            this.YearReleaseFilmLabel.Text = "Year of release:";
            // 
            // RatingFilmLabel
            // 
            this.RatingFilmLabel.Location = new System.Drawing.Point(123, 175);
            this.RatingFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingFilmLabel.Name = "RatingFilmLabel";
            this.RatingFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.RatingFilmLabel.TabIndex = 4;
            this.RatingFilmLabel.Text = "Rating:";
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.IdRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.YRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.XRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.IdRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.YRectangleLable);
            this.RectangleGroupBox.Controls.Add(this.XRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectangleGroupBox.Controls.Add(this.WidthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.ColorRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.LengthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.ColorRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.WidthRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.LengthRectangleLabel);
            this.RectangleGroupBox.Controls.Add(this.RectangleListBox);
            this.RectangleGroupBox.Location = new System.Drawing.Point(4, 0);
            this.RectangleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Size = new System.Drawing.Size(284, 369);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Enabled = false;
            this.IdRectangleTextBox.Location = new System.Drawing.Point(122, 225);
            this.IdRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.IdRectangleTextBox.TabIndex = 13;
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Enabled = false;
            this.YRectangleTextBox.Location = new System.Drawing.Point(122, 189);
            this.YRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.YRectangleTextBox.TabIndex = 12;
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Enabled = false;
            this.XRectangleTextBox.Location = new System.Drawing.Point(122, 153);
            this.XRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.XRectangleTextBox.TabIndex = 11;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.Location = new System.Drawing.Point(122, 211);
            this.IdRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(35, 12);
            this.IdRectangleLabel.TabIndex = 10;
            this.IdRectangleLabel.Text = "Id:";
            // 
            // YRectangleLable
            // 
            this.YRectangleLable.Location = new System.Drawing.Point(122, 175);
            this.YRectangleLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YRectangleLable.Name = "YRectangleLable";
            this.YRectangleLable.Size = new System.Drawing.Size(35, 12);
            this.YRectangleLable.TabIndex = 9;
            this.YRectangleLable.Text = "Y:";
            // 
            // XRectangleLabel
            // 
            this.XRectangleLabel.Location = new System.Drawing.Point(122, 137);
            this.XRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XRectangleLabel.Name = "XRectangleLabel";
            this.XRectangleLabel.Size = new System.Drawing.Size(35, 14);
            this.XRectangleLabel.TabIndex = 8;
            this.XRectangleLabel.Text = "X:";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(122, 286);
            this.FindRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(71, 24);
            this.FindRectangleButton.TabIndex = 7;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(122, 76);
            this.WidthRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.WidthRectangleTextBox.TabIndex = 6;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // ColorRectangleTextBox
            // 
            this.ColorRectangleTextBox.Location = new System.Drawing.Point(122, 115);
            this.ColorRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColorRectangleTextBox.Name = "ColorRectangleTextBox";
            this.ColorRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.ColorRectangleTextBox.TabIndex = 5;
            this.ColorRectangleTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged);
            // 
            // LengthRectangleTextBox
            // 
            this.LengthRectangleTextBox.Location = new System.Drawing.Point(122, 37);
            this.LengthRectangleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            this.LengthRectangleTextBox.Size = new System.Drawing.Size(119, 20);
            this.LengthRectangleTextBox.TabIndex = 4;
            this.LengthRectangleTextBox.TextChanged += new System.EventHandler(this.LengthRectangleTextBox_TextChanged);
            // 
            // ColorRectangleLabel
            // 
            this.ColorRectangleLabel.Location = new System.Drawing.Point(122, 98);
            this.ColorRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorRectangleLabel.Name = "ColorRectangleLabel";
            this.ColorRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.ColorRectangleLabel.TabIndex = 3;
            this.ColorRectangleLabel.Text = "Color:";
            // 
            // WidthRectangleLabel
            // 
            this.WidthRectangleLabel.Location = new System.Drawing.Point(122, 59);
            this.WidthRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthRectangleLabel.Name = "WidthRectangleLabel";
            this.WidthRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.WidthRectangleLabel.TabIndex = 2;
            this.WidthRectangleLabel.Text = "Width:";
            // 
            // LengthRectangleLabel
            // 
            this.LengthRectangleLabel.Location = new System.Drawing.Point(122, 20);
            this.LengthRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthRectangleLabel.Name = "LengthRectangleLabel";
            this.LengthRectangleLabel.Size = new System.Drawing.Size(49, 15);
            this.LengthRectangleLabel.TabIndex = 1;
            this.LengthRectangleLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.Location = new System.Drawing.Point(6, 20);
            this.RectangleListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(112, 290);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // RectangleTabPage
            // 
            this.RectangleTabPage.Controls.Add(this.CanvasPanel);
            this.RectangleTabPage.Controls.Add(this.YSelectedTextBox);
            this.RectangleTabPage.Controls.Add(this.HeightSelectedTextBox);
            this.RectangleTabPage.Controls.Add(this.WidthSelectedTextBox);
            this.RectangleTabPage.Controls.Add(this.XSelectedTextBox);
            this.RectangleTabPage.Controls.Add(this.IdSelectedTextBox);
            this.RectangleTabPage.Controls.Add(this.HeightLabel);
            this.RectangleTabPage.Controls.Add(this.WidthLabel);
            this.RectangleTabPage.Controls.Add(this.YLabel);
            this.RectangleTabPage.Controls.Add(this.XLabel);
            this.RectangleTabPage.Controls.Add(this.IdLabel);
            this.RectangleTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectangleTabPage.Controls.Add(this.RectanglesListBox);
            this.RectangleTabPage.Controls.Add(this.RectangleLabel);
            this.RectangleTabPage.Controls.Add(this.RemoveRectangleButton);
            this.RectangleTabPage.Controls.Add(this.AddRectangleButton);
            this.RectangleTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectangleTabPage.Name = "RectangleTabPage";
            this.RectangleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectangleTabPage.Size = new System.Drawing.Size(592, 374);
            this.RectangleTabPage.TabIndex = 3;
            this.RectangleTabPage.Text = "Rectangle";
            this.RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(230, 5);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(358, 364);
            this.CanvasPanel.TabIndex = 17;
            // 
            // YSelectedTextBox
            // 
            this.YSelectedTextBox.Location = new System.Drawing.Point(59, 251);
            this.YSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YSelectedTextBox.Name = "YSelectedTextBox";
            this.YSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.YSelectedTextBox.TabIndex = 16;
            this.YSelectedTextBox.TextChanged += new System.EventHandler(this.YSelectedTextBox_TextChanged);
            // 
            // HeightSelectedTextBox
            // 
            this.HeightSelectedTextBox.Location = new System.Drawing.Point(59, 297);
            this.HeightSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightSelectedTextBox.Name = "HeightSelectedTextBox";
            this.HeightSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.HeightSelectedTextBox.TabIndex = 15;
            this.HeightSelectedTextBox.TextChanged += new System.EventHandler(this.HeightSelectedTextBox_TextChanged);
            // 
            // WidthSelectedTextBox
            // 
            this.WidthSelectedTextBox.Location = new System.Drawing.Point(59, 275);
            this.WidthSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthSelectedTextBox.Name = "WidthSelectedTextBox";
            this.WidthSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.WidthSelectedTextBox.TabIndex = 14;
            this.WidthSelectedTextBox.TextChanged += new System.EventHandler(this.WidthSelectedTextBox_TextChanged);
            // 
            // XSelectedTextBox
            // 
            this.XSelectedTextBox.Location = new System.Drawing.Point(59, 228);
            this.XSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.XSelectedTextBox.Name = "XSelectedTextBox";
            this.XSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.XSelectedTextBox.TabIndex = 12;
            this.XSelectedTextBox.TextChanged += new System.EventHandler(this.XSelectedTextBox_TextChanged);
            // 
            // IdSelectedTextBox
            // 
            this.IdSelectedTextBox.Enabled = false;
            this.IdSelectedTextBox.Location = new System.Drawing.Point(59, 204);
            this.IdSelectedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IdSelectedTextBox.Name = "IdSelectedTextBox";
            this.IdSelectedTextBox.Size = new System.Drawing.Size(92, 20);
            this.IdSelectedTextBox.TabIndex = 11;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(17, 300);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(35, 23);
            this.HeightLabel.TabIndex = 10;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(17, 277);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(47, 23);
            this.WidthLabel.TabIndex = 9;
            this.WidthLabel.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.Location = new System.Drawing.Point(34, 254);
            this.YLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(35, 23);
            this.YLabel.TabIndex = 8;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.Location = new System.Drawing.Point(34, 231);
            this.XLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(35, 23);
            this.XLabel.TabIndex = 7;
            this.XLabel.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(34, 208);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(35, 23);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(5, 189);
            this.SelectedRectangleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(120, 19);
            this.SelectedRectangleLabel.TabIndex = 5;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(5, 26);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(218, 121);
            this.RectanglesListBox.TabIndex = 3;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectangleLabel
            // 
            this.RectangleLabel.Location = new System.Drawing.Point(3, 5);
            this.RectangleLabel.Name = "RectangleLabel";
            this.RectangleLabel.Size = new System.Drawing.Size(64, 19);
            this.RectangleLabel.TabIndex = 2;
            this.RectangleLabel.Text = "Rectangles:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (250)))), ((int) (((byte) (250)))), ((int) (((byte) (250)))));
            this.RemoveRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = ((System.Drawing.Image) (resources.GetObject("RemoveRectangleButton.Image")));
            this.RemoveRectangleButton.Location = new System.Drawing.Point(148, 146);
            this.RemoveRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(75, 30);
            this.RemoveRectangleButton.TabIndex = 1;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (250)))), ((int) (((byte) (250)))), ((int) (((byte) (250)))));
            this.AddRectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = ((System.Drawing.Image) (resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(5, 146);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(75, 30);
            this.AddRectangleButton.TabIndex = 0;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.MainTabControl.ResumeLayout(false);
            this.EnumTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            this.RectangleTabPage.ResumeLayout(false);
            this.RectangleTabPage.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel CanvasPanel;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox YSelectedTextBox;

        private System.Windows.Forms.TextBox WidthSelectedTextBox;

        private System.Windows.Forms.TextBox Y;

        private System.Windows.Forms.TextBox XSelectedTextBox;

        private System.Windows.Forms.TextBox HeightSelectedTextBox;

        private System.Windows.Forms.TextBox IdSelectedTextBox;

        private System.Windows.Forms.TextBox WidthSelectedRectangleTextBox;

        private System.Windows.Forms.TextBox IdSelectedRectangleTextBox;
        private System.Windows.Forms.TextBox YSelectedRectangleTextBox;

        private System.Windows.Forms.TextBox HeightSelectedRectangleTextBox;
        private System.Windows.Forms.TextBox XSelectedRectangleTextBox;

        private System.Windows.Forms.Button RemoveRectangleButton;

        private System.Windows.Forms.Button AddRectangleButton;

        private System.Windows.Forms.ListBox RectanglesListBox;

        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label RectangleLabel;

        private System.Windows.Forms.TabPage RectangleTabPage;

        private System.Windows.Forms.Label XRectangleLabel;
        private System.Windows.Forms.Label YRectangleLable;
        private System.Windows.Forms.Label IdRectangleLabel;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.TextBox IdRectangleTextBox;

        private System.Windows.Forms.TextBox YearReleaseMovieTextBox;

        private System.Windows.Forms.TextBox RatingMovieTextBox;

        private System.Windows.Forms.TextBox RatingMovie;

        private System.Windows.Forms.TextBox DurationMinutesMovieTextBox;

        private System.Windows.Forms.TextBox GenreMovieTextBox;

        private System.Windows.Forms.TextBox NameMovieTextBox;

        private System.Windows.Forms.Button FindMovieButton;

        private System.Windows.Forms.GroupBox MovieGroupBox;

        private System.Windows.Forms.TextBox RatingFilmTextBox;

        private System.Windows.Forms.TextBox DurationMinutesFilmTextBox;

        private System.Windows.Forms.TextBox GenreFilmTextBox;

        private System.Windows.Forms.TextBox NameFilmTextBox;

        private System.Windows.Forms.TextBox ColorRectangleTextBox;

        private System.Windows.Forms.TextBox WidthRectangleTextBox;

        private System.Windows.Forms.TextBox LengthRectangleTextBox;

        private System.Windows.Forms.Button FindRectangleButton;

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button FindRactangleButton;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label GenreFilmLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label YearReleaseFilmLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label DurationMinutesFilmLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label RatingFilmLabel;

        private System.Windows.Forms.Label NameFilmLabel;

        private System.Windows.Forms.Label WidthRectangleLabel;
        private System.Windows.Forms.Label ColorRectangleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LengthRectangleLabel;

        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.ListBox FilmListBox;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox FilmGroupBox;
        private System.Windows.Forms.GroupBox RectangleGroupBox;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TabPage ClassesTabPage;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.TextBox ValueWeekdayTextBox;

        private System.Windows.Forms.TabControl MainTabControl;

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

        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabControl EnumTabControl;
        private System.Windows.Forms.TabPage tabPage2;

        

        private System.Windows.Forms.ListBox MovieListBox;
        #endregion
    }
}