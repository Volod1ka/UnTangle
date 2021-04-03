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
            var Settings = Properties.Settings.Default;

            Input(SelectedButton: Settings.ButtonSelected, idPanel1: Settings.IdPanel1, idPanel2: Settings.IdPanel2);
        }

        #endregion

        #region Public Methods

        public static void SetButtonSelected(int Button)
        {
            ButtonSelected = Button;

            Properties.Settings.Default.ButtonSelected = Button;
            Properties.Settings.Default.Save();
        }

        public static void SetIdPanel1(int Panel)
        {
            IdPanel1 = Panel;

            Properties.Settings.Default.IdPanel1 = Panel;
            Properties.Settings.Default.Save();
        }

        public static void SetIdPanel2(int Panel)
        {
            IdPanel2 = Panel;

            Properties.Settings.Default.IdPanel2 = Panel;
            Properties.Settings.Default.Save();
        }

        public static void Input(int SelectedButton, int idPanel1, int idPanel2)
        {
            ButtonSelected = SelectedButton;
            IdPanel1 = idPanel1;
            IdPanel2 = idPanel2;
        }
        
        #endregion
    }
}
