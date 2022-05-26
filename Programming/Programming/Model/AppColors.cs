using System.Drawing;

namespace Programming.Model
{
    public static class AppColors
    {
        public static readonly Color _errorColor = Color.LightPink;

        public static readonly Color _correctColor = Color.White;
        
        public static readonly Color _isNotCollisionColor = Color.FromArgb(127, 127, 255, 127);
        
        public static readonly Color _isCollisionColor = Color.FromArgb(127, 255, 127, 127);
        
        public static readonly Color Spring = ColorTranslator.FromHtml("#559c45");
        
        public static readonly Color Autumn = ColorTranslator.FromHtml("#e29c45");
    }
}