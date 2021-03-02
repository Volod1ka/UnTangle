namespace UnTangle
{
    internal static class ProgramProcess
    {
        #region Variables

        public static int ButtonSelected { private set; get; }

        public static int IdPanel1 { private set; get; }

        public static int IdPanel2 { private set; get; }

        #endregion

        #region Constructors

        static ProgramProcess()
        {
            Input(Properties.Settings.Default.ButtonSelected, Properties.Settings.Default.IdPanel1, Properties.Settings.Default.IdPanel2);
        }

        #endregion

        #region Public Methods

        public static void SetButtonSelected(int button)
        {
            ButtonSelected = button;

            Properties.Settings.Default.ButtonSelected = button;
            Properties.Settings.Default.Save();
        }

        public static void SetIdPanel1(int panel)
        {
            IdPanel1 = panel;

            Properties.Settings.Default.IdPanel1 = panel;
            Properties.Settings.Default.Save();
        }

        public static void SetIdPanel2(int panel)
        {
            IdPanel2 = panel;

            Properties.Settings.Default.IdPanel2 = panel;
            Properties.Settings.Default.Save();
        }

        public static void Input(int buttonSelected, int idPanel1, int idPanel2)
        {
            ButtonSelected = buttonSelected;
            IdPanel1 = idPanel1;
            IdPanel2 = idPanel2;
        }
        
        #endregion
    }
}
