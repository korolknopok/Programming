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

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private readonly Color _isNotCollisionColor = Color.FromArgb(127, 127, 255, 127);
        
        private readonly Color _isCollisionColor = Color.FromArgb(127, 255, 127, 127);

        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random = new Random();

        private List<Panel> _rectanglePanels;

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

            RectangleListBox.SelectionMode = SelectionMode.One;
            
            EnumsListBox.SelectedIndex = 0;

            _random = new Random();

            _rectangles = new List<Rectangle>();

            CreateMovies();
                
            _rectanglePanels = new List<Panel>();
            
        }
        
        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
            IdSelectedTextBox.Clear();
            XSelectedTextBox.Clear();
            YSelectedTextBox.Clear();
            WidthSelectedTextBox.Clear();
            HeightSelectedTextBox.Clear();
        }
       
        private string GetInfoOfRectangle(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
        }
        
        
        
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                var copyRectangle = new Rectangle(rectangle);
                var oldRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                var differenceWidth = Math.Abs(oldRectangle.Width - copyRectangle.Width) / 2;
                var differenceHeight = Math.Abs(oldRectangle.Height - copyRectangle.Height) / 2;

                if (copyRectangle.Center.X == oldRectangle.Center.X && copyRectangle.Center.Y == oldRectangle.Center.Y)
                {
                    copyRectangle.Center.X = oldRectangle.Width >= copyRectangle.Width
                        ? oldRectangle.Center.X + differenceWidth
                        : oldRectangle.Center.X - differenceWidth;

                    copyRectangle.Center.Y = oldRectangle.Height >= copyRectangle.Height
                        ? oldRectangle.Center.Y + differenceHeight
                        : oldRectangle.Center.Y - differenceHeight;
                }


                var index = _rectangles.FindIndex(r => r.Equals(copyRectangle));
                _rectangles[index] = copyRectangle;

                UpdatePanel(copyRectangle, index);
                FindCollisions();
            }
        }

        private void UpdatePanel(Rectangle rectangle, int index)
        {
            var control = CanvasPanel.Controls[index];
            control.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            control.Width = rectangle.Width;
            control.Height = rectangle.Height;
        }
        
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = _isNotCollisionColor;
            }

            for (int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = _isCollisionColor;
                        CanvasPanel.Controls[j].BackColor = _isCollisionColor;
                    }
                }
            }
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

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = rectangles[0].Width;
            for (int i = 0; i < ElementsСount; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }

            return maxWidthIndex;
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

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            // _currentRectangle = _rectangles[selectedIndexRectangle];
            // LengthRectangleTextBox.Text = _currentRectangle.Height.ToString();
            // WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            // ColorRectangleTextBox.Text = _currentRectangle.Color;
            // XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            // YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
            // IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentLengthLength = LengthRectangleTextBox.Text;
                int lengthRectangleValue = int.Parse(currentLengthLength);
                _currentRectangle.Height = lengthRectangleValue;
            }
            catch
            {
                LengthRectangleTextBox.BackColor = _errorColor;
                return;
            }

            LengthRectangleTextBox.BackColor = _correctColor;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidthRectangle = WidthRectangleTextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch
            {
                WidthRectangleTextBox.BackColor = _errorColor;
                return;
            }

            WidthRectangleTextBox.BackColor = _correctColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorRectangleTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = findMaxWidthIndex;
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var colors = Enum.GetValues(typeof(Colors));
            var rectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            RectanglesListBox.Items.Add(GetInfoOfRectangle(rectangle));
            _rectangles.Add(rectangle);

            //RectangleListBox.Items.Add(rectangle.Id);
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = rectangle.Width;
            rectanglePanel.Height = rectangle.Height;
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = _isNotCollisionColor;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;

        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle != -1)
            {
                _rectanglePanels.RemoveAt(indexSelectedRectangle);
                _rectangles.RemoveAt(indexSelectedRectangle);
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectanglesListBox.Items.Add(GetInfoOfRectangle(_rectangles[i]));
                    RectanglesListBox.SelectedIndex = 0;
                }

                CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
                FindCollisions();
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = new Rectangle(_rectangles[indexSelectedRectangle]);
            IdSelectedTextBox.Text = _currentRectangle.Id.ToString();
            XSelectedTextBox.Text = _currentRectangle.Center.X.ToString();
            YSelectedTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthSelectedTextBox.Text = _currentRectangle.Width.ToString();
            HeightSelectedTextBox.Text = _currentRectangle.Height.ToString();
        }

        private void XSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XSelectedTextBox.BackColor = _correctColor;
                if (XSelectedTextBox.Text != string.Empty)
                {
                    var xValue = int.Parse(XSelectedTextBox.Text);
                    if (_currentRectangle.Center.X != xValue)
                    {
                        _currentRectangle.Center.X = xValue;
                        UpdateRectangleInfo(_currentRectangle);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                XSelectedTextBox.BackColor = _errorColor;
            }
        }

        private void YSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YSelectedTextBox.BackColor = _correctColor;
                if (YSelectedTextBox.Text != string.Empty)
                {
                    var yValue = int.Parse(YSelectedTextBox.Text);
                    if (_currentRectangle.Center.Y != yValue)
                    {
                        _currentRectangle.Center.Y = yValue;
                        UpdateRectangleInfo(_currentRectangle);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                YSelectedTextBox.BackColor = _errorColor;
            }
        }

        private void WidthSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthSelectedTextBox.BackColor = _correctColor;
                if (WidthSelectedTextBox.Text != string.Empty)
                {
                    var widthValue = int.Parse(WidthSelectedTextBox.Text);
                    if (_currentRectangle.Width != widthValue)
                    {
                        _currentRectangle.Width = widthValue;
                        UpdateRectangleInfo(_currentRectangle);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
                WidthSelectedTextBox.BackColor = _errorColor;
            }
        }

        private void HeightSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightSelectedTextBox.BackColor = _correctColor;
                if (HeightSelectedTextBox.Text != string.Empty)
                {
                    var heightValue = int.Parse(HeightSelectedTextBox.Text);
                    if (_currentRectangle.Height != heightValue)
                    {
                        _currentRectangle.Height = heightValue;
                        UpdateRectangleInfo(_currentRectangle);
                        
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                HeightSelectedTextBox.BackColor = _errorColor;
            }
        }
    }
}
