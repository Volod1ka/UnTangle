namespace UnTangle.Scripts
{
    internal static class Language
    {
        #region Variables

        public static int UILanguage;

        public enum Lang
        {
            Ua = 0,
            Ru = 1,
            En = 2
        }
        #endregion

        #region Public Methods

        public static void SetLanguage(int Language)
        {
            string culture = string.Empty;

            switch (Language)
            {
                case (int)Lang.Ua:
                    {
                        culture = "uk-Ua";
                    }
                    break;
                case (int)Lang.Ru:
                    {
                        culture = "ru-Ru";
                    }
                    break;
                case (int)Lang.En:
                    {
                        culture = "en-En";
                    }
                    break;
            }

            if (culture != string.Empty)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
                Properties.Settings.Default.Language = Language;
                Properties.Settings.Default.Save();
            }
        }

        #endregion
    }
}
