using System.Drawing;

namespace UnTangle
{
    internal static class ThemeColors
    {
        #region Variables

        public static Color BackGround { private set; get; }
        public static Color Workspace { private set; get; }
        public static Color Active { private set; get; }
        public static Color ForeGround { private set; get; }

        public static int IdTheme = 0;

        #endregion

        #region Delegates and Events

        public delegate void ThemeArgs(int theme);

        public static event ThemeArgs ChangeThemeEvents;

        #endregion

        #region Constructors

        static ThemeColors()
        {
            IdTheme = Properties.Settings.Default.IdTheme;

            SelectTheme();
        }

        #endregion

        #region Public Methods

        public static void ChangeTheme(int theme)
        {
            ChangeThemeEvents?.Invoke(theme);
        }

        public static void SelectTheme()
        {
            switch (IdTheme)
            {
                case 1:
                    {
                        DarkBlueTheme();
                    }
                    break;
                case 2:
                    {
                        DarkTheme();
                    }
                    break;
                default:
                    {
                        IdTheme = 0;

                        LightTheme();
                    }
                    break;
            }
        }

        #endregion

        #region Private Methods

        private static void LightTheme()
        {
            BackGround = Color.FromArgb(213, 213, 213);
            Workspace = Color.FromArgb(240, 240, 240);
            Active = Color.FromArgb(0, 122, 204); 
            ForeGround = Color.FromArgb(71, 71, 71);
        }

        private static void DarkBlueTheme()
        {
            BackGround = Color.FromArgb(8, 16, 39);
            Workspace = Color.FromArgb(13, 26, 52);
            Active = Color.FromArgb(0, 122, 204);
            ForeGround = Color.FromArgb(155, 180, 230);
        }

        private static void DarkTheme()
        {
            BackGround = Color.FromArgb(31, 32, 35);
            Workspace = Color.FromArgb(39, 41, 45); 
            Active = Color.FromArgb(0, 122, 204);
            ForeGround = Color.FromArgb(157, 174, 209);
        }

        #endregion
    }
}
