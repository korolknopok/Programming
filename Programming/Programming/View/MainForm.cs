using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        const int CountElements = 5;

        private Color _errorColor = Color.LightPink;

        private Color _colorCorrect = Color.White;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private Film[] _films;

        private Film _currentFilm;

        private Random _randomValues;

        public MainForm()
        {
            InitializeComponent();
            Array seasons = System.Enum.GetValues(typeof(Season));
            foreach (Season value in seasons)
            {
                SeasonNamesComboBox.Items.Add(value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;
            Array initValues = System.Enum.GetValues(typeof(Enums));
            foreach (Enums value in initValues)
            {
                EnumsListBox.Items.Add(value);
            }

            EnumsListBox.SelectedIndex = 0;
            _randomValues = new Random();
            _rectangles = new Rectangle[CountElements];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _randomValues.Next(101);
                _currentRectangle.Length = _randomValues.Next(101);
                _currentRectangle.Color = colors.GetValue(_randomValues.Next(0, colors.Length)).ToString();
                _rectangles[i] = _currentRectangle;
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }

            RectangleListBox.SelectedIndex = 0;

            _films = new Film[CountElements];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < CountElements; i++)
            {
                _currentFilm = new Film();
                _currentFilm.Rating = _randomValues.Next(11);
                _currentFilm.YearRelease = _randomValues.Next(1900, 2023);
                _currentFilm.Genre = genres.GetValue(_randomValues.Next(0, genres.Length)).ToString();
                _currentFilm.Name = $"Film {_currentFilm.Genre} {_currentFilm.YearRelease}";
                _currentFilm.DurationMinutes = _randomValues.Next(150);
                _films[i] = _currentFilm;
                FilmListBox.Items.Add($"Film {i + 1}");
            }

            FilmListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    enumValues = System.Enum.GetValues(typeof(Colors));
                    break;
                case Enums.Weekday:
                    enumValues = System.Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Season:
                    enumValues = System.Enum.GetValues(typeof(Season));
                    break;
                case Enums.Manufactures:
                    enumValues = System.Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Genre:
                    enumValues = System.Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    enumValues = System.Enum.GetValues(typeof(EducationForm));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            ValueWeekdayTextBox.Text = ((int) item).ToString();
        }


        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday weekday;
            if (System.Enum.TryParse(textWeekdayTextBox, out weekday))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int) weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого для недели";
            }
        }

        private void GOButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!»");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            LengthRectangleTextBox.Text = _currentRectangle.Length.ToString();
            WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            ColorRectangleTextBox.Text = _currentRectangle.Color;
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentLengthLength = LengthRectangleTextBox.Text;
                double lengthRectangleValue = double.Parse(currentLengthLength);
                _currentRectangle.Length = lengthRectangleValue;
            }
            catch
            {
                LengthRectangleTextBox.BackColor = _errorColor;
                return;
            }

            LengthRectangleTextBox.BackColor = _colorCorrect;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidthRectangle = WidthRectangleTextBox.Text;
                double widthRectangleValue = double.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch
            {
                WidthRectangleTextBox.BackColor = _errorColor;
                return;
            }

            WidthRectangleTextBox.BackColor = _colorCorrect;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorRectangleTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < CountElements; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }

            return maxWidthIndex;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void FilmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexFilm = FilmListBox.SelectedIndex;
            _currentFilm = _films[selectedIndexFilm];
            NameFilmTextBox.Text = _currentFilm.Name;
            GenreFilmTextBox.Text = _currentFilm.Genre;
            YearReleaseFilmTextBox.Text = _currentFilm.YearRelease.ToString();
            DurationMinutesFilmTextBox.Text = _currentFilm.DurationMinutes.ToString();
            RatingFilmTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void NameFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            string nameFilmValue = NameFilmTextBox.Text;
            _currentFilm.Name = nameFilmValue;
        }

        private void GenreFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreFilmValue = GenreFilmTextBox.Text;
            _currentFilm.Genre = genreFilmValue;
        }

        private void YearReleaseFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = YearReleaseFilmTextBox.Text;
                int yearReleaseFilmValue = int.Parse(currentYearRelease);
                _currentFilm.YearRelease = yearReleaseFilmValue;
            }
            catch
            {
                YearReleaseFilmTextBox.BackColor = _errorColor;
                return;
            }

            YearReleaseFilmTextBox.BackColor = _colorCorrect;
        }

        private void DurationMinutesFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = DurationMinutesFilmTextBox.Text;
                int durationMinutesFilmValue = int.Parse(currentDurationMinutes);
                _currentFilm.DurationMinutes = durationMinutesFilmValue;
            }
            catch
            {
                DurationMinutesFilmTextBox.BackColor = _errorColor;
                return;
            }

            DurationMinutesFilmTextBox.BackColor = _colorCorrect;
        }

        private void RatingFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingFilmTextBox.Text;
                int ratingFilmValue = int.Parse(currentRating);
                _currentFilm.Rating = ratingFilmValue;
            }
            catch
            {
                RatingFilmTextBox.BackColor = _errorColor;
                return;
            }

            RatingFilmTextBox.BackColor = _colorCorrect;
        }

        private int FindFilmWithMaxRating(Film[] films)
        {
            int maxRatingIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < CountElements; i++)
            {
                if (films[i].Rating > maxValue)
                {
                    maxValue = films[i].Rating;
                    maxRatingIndex = i;
                }
            }

            return maxRatingIndex;
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindFilmWithMaxRating(_films);
            FilmListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}