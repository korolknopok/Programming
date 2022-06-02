using System.Drawing;

namespace BookList.Model
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    internal class AppColors
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static Color _correctColor = Color.FromArgb(255, 255, 255);
        
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static Color _errorColor = Color.FromArgb(255, 182, 193);
    }
}