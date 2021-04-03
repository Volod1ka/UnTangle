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

        public static string CharToLower(string Text)
        {
            return Text.ToLower();
        }

        public static string CharToUpper(string Text)
        {
            return Text.ToUpper();
        }

        public static string CharToTitleCase(string Text)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Text.ToLower());
        }

        public static string CharReverse(string Text)
        {
            return new string(Text.Reverse().ToArray());
        }

        #endregion
    }
}
