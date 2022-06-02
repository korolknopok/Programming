using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению фильмов.
    /// </summary>
    public partial class MovieControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int ElementsСount = 5;
        
        /// <summary>
        /// Коллекция фильмов.
        /// </summary>
        private List<Movie> _movies;

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;
        
        /// <summary>
        /// Случайные значения.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MovieControl"/>.
        /// </summary>
        public MovieControl()
        {
            InitializeComponent();
            
            _movies = CreateMovies();

            MovieListBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Инициализирует коллекцию фильмов.
        /// </summary>
        /// <returns>Возвращает коллекцию фильмов.</returns>
        private List<Movie> CreateMovies()
        {

            List<Movie> _movies = new List<Movie>();
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsСount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1900, DateTime.Now.Year);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next(150);
                _movies.Add(_currentMovie); 
                MovieListBox.Items.Add($"Movie {i + 1}");
            }

            return _movies;
        }

        private int FindMovieWithMaxRating(List<Movie> movies)
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
                DurationMinutesMovieTextBox.BackColor = AppColors._errorColor;
                return;
            }

            DurationMinutesMovieTextBox.BackColor = AppColors._correctColor;
        }
        
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
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
                YearReleaseMovieTextBox.BackColor = AppColors._errorColor;
                return;
            }

            YearReleaseMovieTextBox.BackColor = AppColors._correctColor;
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
                RatingMovieTextBox.BackColor = AppColors._errorColor;
                return;
            }

            RatingMovieTextBox.BackColor = AppColors._correctColor;
        }

        private void GenreMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovieValue = GenreMovieTextBox.Text;
            _currentMovie.Genre = genreMovieValue;
        }
    }
}