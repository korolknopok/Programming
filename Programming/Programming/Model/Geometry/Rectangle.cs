using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        
        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private int _height;
        
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота. Должна быть положительным числом.</param>
        /// <param name="width">Ширина. Должна быть положительным числом.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра.</param>
        public Rectangle(int height,
            int width,
            string color,
            Point2D center)
        
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="Id"> Айди.</param>
        /// <param name="height">Высота. Должна быть положительным числом.</param>
        /// <param name="width">Ширина. Должна быть положительным числом.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра.</param>
        public Rectangle(Rectangle rectangle)
        {
            Id = rectangle.Id;
            Height = rectangle.Height;
            Width = rectangle.Width;
            Color = rectangle.Color;
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);
        }
        
        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт высоту прямоугольника. Должна быть положительным числом.
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должна быть положительным числом.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }
    }
}