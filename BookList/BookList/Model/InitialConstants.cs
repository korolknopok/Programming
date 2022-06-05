using System.ComponentModel;

namespace BookList.Model
{
    /// <summary>
    /// Хранит данные о максимальных и минимальных константах.
    /// </summary>
    public static class InitialConstants
    {
        
        public const string SerializerResult = @"\DataUser.json";

        /// <summary>
        /// Максимальное количество символов для <see cref="Book.FullName"/>
        /// </summary>
        public const int MaxLenghtFullName = 100;
        
        /// <summary>
        /// Минимальное количество символов для <see cref="Book.FullName"/>
        /// </summary>
        public const int MinLenghtFullName = 1;
        
        /// <summary>
        /// Минимальное количество символов для <see cref="Book.ReleaseDate"/>
        /// </summary>
        public const int MinReleaseDate = 1700;
        

    }
}