using System.Text.RegularExpressions;

namespace Programming.Model
{
    
    public class Rectangle
    {
        private static int _allRectanglesCount;
        
        private double _height;
        
        private double _width;

        private int _id;

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(double height,
            double width,
            string color,
            Point2D center)
        
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        
        public Point2D Center { get; set; }

        public string Color { get; set; }

        public int Id
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public double Height
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

        public double Width
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