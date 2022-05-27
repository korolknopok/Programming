using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Хранение данных об используемых цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static readonly Color _errorColor = Color.LightPink;
        
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static readonly Color _correctColor = Color.White;
        
        /// <summary>
        /// Цвет непересекающихся прямоугольников.
        /// </summary>
        public static readonly Color _isNotCollisionColor = Color.FromArgb(127, 127, 255, 127);
        
        /// <summary>
        /// Цвет пересекающихся прямоугольников.
        /// </summary>
        public static readonly Color _isCollisionColor = Color.FromArgb(127, 255, 127, 127);
        
        /// <summary>
        /// Цвет при выборе Spring из списка.
        /// </summary>
        public static readonly Color Spring = ColorTranslator.FromHtml("#559c45");
        
        /// <summary>
        /// Цвет при выборе Autumn из списка.
        /// </summary>
        public static readonly Color Autumn = ColorTranslator.FromHtml("#e29c45");
    }
}