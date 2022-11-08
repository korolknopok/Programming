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
        private const int ElementsСount = 5;

        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random = new Random();
        
        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;
        
        private readonly Color _isNotCollisionColor = Color.FromArgb(127, 127, 255, 127);
        
        private readonly Color _isCollisionColor = Color.FromArgb(127, 255, 127, 127);
        
        private Rectangle _currentRectangle;
        
        private List<Rectangle> _rectangles;
        
        public MainForm()
        {
            InitializeComponent();
            Array seasons = Enum.GetValues(typeof(Season));
            foreach (Season value in seasons)
            {
                SeasonNamesComboBox.Items.Add(value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;

            Array initValues = Enum.GetValues(typeof(Enums));
            foreach (Enums value in initValues)
            {
                EnumsListBox.Items.Add(value);
            }

            EnumsListBox.SelectedIndex = 0;
            
            _rectangles = new List<Rectangle>();

            _random = new Random();

            CreateMovies();

        }

        private void CreateMovies()
        {

            _movies = new Movie[ElementsСount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsСount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1900, DateTime.Now.Year);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next(150);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }

            MovieListBox.SelectedIndex = 0;
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double maxValue = movies[0].Rating;
            for (int i = 0; i < ElementsСount; i++)
            {
                if (movies[i].Rating > maxValue)
                {
                    maxValue = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }

            return maxRatingIndex;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Season:
                    enumValues = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Manufactures:
                    enumValues = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm));
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
            if (Enum.TryParse(textWeekdayTextBox, out weekday))
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

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            NameMovieTextBox.Text = _currentMovie.Name;
            GenreMovieTextBox.Text = _currentMovie.Genre;
            YearReleaseMovieTextBox.Text = _currentMovie.ReleaseYear.ToString();
            DurationMinutesMovieTextBox.Text = _currentMovie.DurationMinutes.ToString();
            RatingMovieTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }

        private void NameMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string nameMovieValue = NameMovieTextBox.Text;
            _currentMovie.Name = nameMovieValue;
        }

        private void RatingMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingMovieTextBox.Text;
                double ratingMovieValue = double.Parse(currentRating);
                _currentMovie.Rating = ratingMovieValue;
            }
            catch
            {
                RatingMovieTextBox.BackColor = _errorColor;
                return;
            }

            RatingMovieTextBox.BackColor = _correctColor;
        }

        private void GenreMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovieValue = GenreMovieTextBox.Text;
            _currentMovie.Genre = genreMovieValue;
        }

        private void YearReleaseMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = YearReleaseMovieTextBox.Text;
                int yearReleaseMovieValue = int.Parse(currentYearRelease);
                _currentMovie.ReleaseYear = yearReleaseMovieValue;
            }
            catch
            {
                YearReleaseMovieTextBox.BackColor = _errorColor;
                return;
            }

            YearReleaseMovieTextBox.BackColor = _correctColor;
        }

        private void DurationMinutesMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = DurationMinutesMovieTextBox.Text;
                int durationMinutesMovieValue = int.Parse(currentDurationMinutes);
                _currentMovie.DurationMinutes = durationMinutesMovieValue;
            }
            catch
            {
                DurationMinutesMovieTextBox.BackColor = _errorColor;
                return;
            }

            DurationMinutesMovieTextBox.BackColor = _correctColor;
        }
    }
}
