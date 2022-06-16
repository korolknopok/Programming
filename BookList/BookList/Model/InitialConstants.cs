using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

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

        /// <summary>
        /// Путь до AppData
        /// </summary>
        public static readonly string AppdataPath = Application.UserAppDataPath;

        /// <summary>
        /// Хранит путь до папки хранения.
        /// </summary>
        public static readonly string FilePath = AppdataPath + InitialConstants.SerializerResult;
    }
}