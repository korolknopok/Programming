using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;
        
        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;
        
        /// <summary>
        /// Коллекция отображаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;
        
        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            RectanglesListBox.SelectionMode = SelectionMode.One;
            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
            
        }
        
        /// <summary>
        /// Находит пересекающиеся прямоугольники и окрашивает их.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = AppColors._isNotCollisionColor;
            }

            for (int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors._isCollisionColor;
                        CanvasPanel.Controls[j].BackColor = AppColors._isCollisionColor;
                    }
                }
            }
        }
        
        /// <summary>
        /// Обновляет информацию в панели.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdatePanel(Rectangle rectangle, int index)
        {
            var control = CanvasPanel.Controls[index];
            control.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            control.Width = rectangle.Width;
            control.Height = rectangle.Height;
        }
        
        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
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
                    XSelectedTextBox.Text = copyRectangle.Center.X.ToString();
                    

                    copyRectangle.Center.Y = oldRectangle.Height >= copyRectangle.Height
                        ? oldRectangle.Center.Y + differenceHeight
                        : oldRectangle.Center.Y - differenceHeight;
                    YSelectedTextBox.Text = copyRectangle.Center.Y.ToString();
                }


                var index = _rectangles.FindIndex(r => r.Equals(copyRectangle));
                _rectangles[index] = copyRectangle;

                UpdatePanel(copyRectangle, index);
                FindCollisions();
            }
        }
        
        /// <summary>
        /// Удаляет информацию о текущем прямоугольнике.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
            IdSelectedTextBox.Clear();
            XSelectedTextBox.Clear();
            YSelectedTextBox.Clear();
            WidthSelectedTextBox.Clear();
            HeightSelectedTextBox.Clear();
        }
       
        /// <summary>
        /// Из данных о прямоугольнике возвращает текст.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns> Возвращает информацию о текущем прямоугольнике.</returns>
        private string GetInfoOfRectangle(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var colors = Enum.GetValues(typeof(Colors));
            var rectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            RectanglesListBox.Items.Add(GetInfoOfRectangle(rectangle));
            _rectangles.Add(rectangle);
            
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = rectangle.Width;
            rectanglePanel.Height = rectangle.Height;
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = AppColors._isNotCollisionColor;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
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

        private void XSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XSelectedTextBox.BackColor = AppColors._correctColor;
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
                XSelectedTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void YSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YSelectedTextBox.BackColor = AppColors._correctColor;
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
                YSelectedTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void WidthSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthSelectedTextBox.BackColor = AppColors._correctColor;
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
                
                WidthSelectedTextBox.BackColor = AppColors._errorColor;
            }
        }

        private void HeightSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightSelectedTextBox.BackColor = AppColors._correctColor;
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
                HeightSelectedTextBox.BackColor = AppColors._errorColor;
            }
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
    }
}