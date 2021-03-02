using System.Linq;

namespace UnTangle
{
    internal static class TextChange
    {
        #region Variables

        public static string TempText { get; set; }

        #endregion

        #region Constructors

        static TextChange()
        {
            TempText = string.Empty;
        }

        #endregion

        #region Public Methods

        public static string CharToLower(string Other)
        {
            return Other.ToLower();
        }

        public static string CharToUpper(string Other)
        {
            return Other.ToUpper();
        }

        public static string CharToTitleCase(string Other)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Other.ToLower());
        }

        public static string CharReverse(string Other)
        {
            return new string(Other.Reverse().ToArray());
        }

        #endregion
    }

}
