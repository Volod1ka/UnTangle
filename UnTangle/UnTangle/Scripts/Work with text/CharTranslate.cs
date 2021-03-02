using System.Collections.Generic;

namespace UnTangle
{
    internal static class CharTranslate
    {
        #region Variables

        private static Dictionary<string, string> chDictionary = new Dictionary<string, string>();

        #endregion

        #region Constructors

        static CharTranslate()
        {
            AddDictionaryList(Properties.Settings.Default.Language);
        }

        #endregion

        #region Public Methods

        public static void AddDictionaryList(int index)
        {
            chDictionary.Clear();

            if (index.Equals((int)Scripts.Language.Lang.Ua))
            {
                #region Eng => Ua
                #region Chars Down Eng => Ua
                chDictionary.Add("`", "'");
                chDictionary.Add("q", "й");
                chDictionary.Add("w", "ц");
                chDictionary.Add("e", "у");
                chDictionary.Add("r", "к");
                chDictionary.Add("t", "е");
                chDictionary.Add("y", "н");
                chDictionary.Add("u", "г");
                chDictionary.Add("i", "ш");
                chDictionary.Add("o", "щ");
                chDictionary.Add("p", "з");
                chDictionary.Add("[", "х");
                chDictionary.Add("]", "ї");
                chDictionary.Add("a", "ф");
                chDictionary.Add("s", "і");
                chDictionary.Add("d", "в");
                chDictionary.Add("f", "а");
                chDictionary.Add("g", "п");
                chDictionary.Add("h", "р");
                chDictionary.Add("j", "о");
                chDictionary.Add("k", "л");
                chDictionary.Add("l", "д");
                chDictionary.Add(";", "ж");
                chDictionary.Add("'", "є");
                chDictionary.Add("z", "я");
                chDictionary.Add("x", "ч");
                chDictionary.Add("c", "с");
                chDictionary.Add("v", "м");
                chDictionary.Add("b", "и");
                chDictionary.Add("n", "т");
                chDictionary.Add("m", "ь");
                chDictionary.Add(",", "б");
                chDictionary.Add(".", "ю");
                chDictionary.Add("/", ".");
                #endregion

                #region Chars Up Eng => Ua
                chDictionary.Add("~", "₴");
                chDictionary.Add("Q", "Й");
                chDictionary.Add("W", "Ц");
                chDictionary.Add("E", "У");
                chDictionary.Add("R", "К");
                chDictionary.Add("T", "Е");
                chDictionary.Add("Y", "Н");
                chDictionary.Add("U", "Г");
                chDictionary.Add("I", "Ш");
                chDictionary.Add("O", "Щ");
                chDictionary.Add("P", "З");
                chDictionary.Add("{", "Х");
                chDictionary.Add("}", "Ї");
                chDictionary.Add("A", "Ф");
                chDictionary.Add("S", "І");
                chDictionary.Add("D", "В");
                chDictionary.Add("F", "А");
                chDictionary.Add("G", "П");
                chDictionary.Add("H", "Р");
                chDictionary.Add("J", "О");
                chDictionary.Add("K", "Л");
                chDictionary.Add("L", "Д");
                chDictionary.Add(":", "Ж");
                chDictionary.Add("\"", "Є");
                chDictionary.Add("Z", "Я");
                chDictionary.Add("X", "Ч");
                chDictionary.Add("C", "С");
                chDictionary.Add("V", "М");
                chDictionary.Add("B", "И");
                chDictionary.Add("N", "Т");
                chDictionary.Add("M", "Ь");
                chDictionary.Add("<", "Б");
                chDictionary.Add(">", "Ю");
                chDictionary.Add("?", ",");
                #endregion

                #region SHIFT + NUMBERS
                chDictionary.Add("@", "\"");
                chDictionary.Add("#", "№");
                chDictionary.Add("$", ";");
                chDictionary.Add("^", ":");
                chDictionary.Add("&", "?");
                #endregion
                #endregion

                #region Ua => Eng 
                #region Chars Down Ua => Eng
                //chDictionary.Add("'", "`");
                chDictionary.Add("й", "q");
                chDictionary.Add("ц", "w");
                chDictionary.Add("у", "e");
                chDictionary.Add("к", "r");
                chDictionary.Add("е", "t");
                chDictionary.Add("н", "y");
                chDictionary.Add("г", "u");
                chDictionary.Add("ш", "i");
                chDictionary.Add("щ", "o");
                chDictionary.Add("з", "p");
                chDictionary.Add("х", "[");
                chDictionary.Add("ї", "]");
                chDictionary.Add("ф", "a");
                chDictionary.Add("і", "s");
                chDictionary.Add("ы", "s");
                chDictionary.Add("в", "d");
                chDictionary.Add("а", "f");
                chDictionary.Add("п", "g");
                chDictionary.Add("р", "h");
                chDictionary.Add("о", "j");
                chDictionary.Add("л", "k");
                chDictionary.Add("д", "l");
                chDictionary.Add("ж", ";");
                chDictionary.Add("є", "'");
                chDictionary.Add("я", "z");
                chDictionary.Add("ч", "x");
                chDictionary.Add("с", "c");
                chDictionary.Add("м", "v");
                chDictionary.Add("и", "b");
                chDictionary.Add("т", "n");
                chDictionary.Add("ь", "m");
                chDictionary.Add("б", ",");
                chDictionary.Add("ю", ".");
                //chDictionary.Add(".", "/");
                #endregion

                #region Chars Up Ua => Eng 
                chDictionary.Add("₴", "~");
                chDictionary.Add("Й", "Q");
                chDictionary.Add("Ц", "W");
                chDictionary.Add("У", "E");
                chDictionary.Add("К", "R");
                chDictionary.Add("Е", "T");
                chDictionary.Add("Н", "Y");
                chDictionary.Add("Г", "U");
                chDictionary.Add("Ш", "I");
                chDictionary.Add("Щ", "O");
                chDictionary.Add("З", "P");
                chDictionary.Add("Х", "{");
                chDictionary.Add("Ї", "}");
                chDictionary.Add("Ф", "A");
                chDictionary.Add("І", "S");
                chDictionary.Add("Ы", "S");
                chDictionary.Add("В", "D");
                chDictionary.Add("А", "F");
                chDictionary.Add("П", "G");
                chDictionary.Add("Р", "H");
                chDictionary.Add("О", "J");
                chDictionary.Add("Л", "K");
                chDictionary.Add("Д", "L");
                chDictionary.Add("Ж", ":");
                chDictionary.Add("Є", "\"");
                chDictionary.Add("Я", "Z");
                chDictionary.Add("Ч", "X");
                chDictionary.Add("С", "C");
                chDictionary.Add("М", "V");
                chDictionary.Add("И", "B");
                chDictionary.Add("Т", "N");
                chDictionary.Add("Ь", "M");
                chDictionary.Add("Б", "<");
                chDictionary.Add("Ю", ">");
                //chDictionary.Add(",", "?");
                #endregion

                #region SHIFT + NUMBERS
                //chDictionary.Add("\"", "@");
                chDictionary.Add("№", "#");
                //chDictionary.Add(";", "$");
                //chDictionary.Add(":", "^");
                //chDictionary.Add("?", "&");
                #endregion
                #endregion
            }
            else if (index.Equals((int)Scripts.Language.Lang.Ru))
            {
                #region Eng => Ru
                #region Chars Down Eng => Ru
                chDictionary.Add("`", "ё");
                chDictionary.Add("q", "й");
                chDictionary.Add("w", "ц");
                chDictionary.Add("e", "у");
                chDictionary.Add("r", "к");
                chDictionary.Add("t", "е");
                chDictionary.Add("y", "н");
                chDictionary.Add("u", "г");
                chDictionary.Add("i", "ш");
                chDictionary.Add("o", "щ");
                chDictionary.Add("p", "з");
                chDictionary.Add("[", "х");
                chDictionary.Add("]", "ъ");
                chDictionary.Add("a", "ф");
                chDictionary.Add("s", "ы");
                chDictionary.Add("d", "в");
                chDictionary.Add("f", "а");
                chDictionary.Add("g", "п");
                chDictionary.Add("h", "р");
                chDictionary.Add("j", "о");
                chDictionary.Add("k", "л");
                chDictionary.Add("l", "д");
                chDictionary.Add(";", "ж");
                chDictionary.Add("'", "э");
                chDictionary.Add("z", "я");
                chDictionary.Add("x", "ч");
                chDictionary.Add("c", "с");
                chDictionary.Add("v", "м");
                chDictionary.Add("b", "и");
                chDictionary.Add("n", "т");
                chDictionary.Add("m", "ь");
                chDictionary.Add(",", "б");
                chDictionary.Add(".", "ю");
                chDictionary.Add("/", ".");
                #endregion

                #region Chars Up Eng => Ru
                chDictionary.Add("~", "Ё");
                chDictionary.Add("Q", "Й");
                chDictionary.Add("W", "Ц");
                chDictionary.Add("E", "У");
                chDictionary.Add("R", "К");
                chDictionary.Add("T", "Е");
                chDictionary.Add("Y", "Н");
                chDictionary.Add("U", "Г");
                chDictionary.Add("I", "Ш");
                chDictionary.Add("O", "Щ");
                chDictionary.Add("P", "З");
                chDictionary.Add("{", "Х");
                chDictionary.Add("}", "Ъ");
                chDictionary.Add("A", "Ф");
                chDictionary.Add("S", "Ы");
                chDictionary.Add("D", "В");
                chDictionary.Add("F", "А");
                chDictionary.Add("G", "П");
                chDictionary.Add("H", "Р");
                chDictionary.Add("J", "О");
                chDictionary.Add("K", "Л");
                chDictionary.Add("L", "Д");
                chDictionary.Add(":", "Ж");
                chDictionary.Add("\"", "Э");
                chDictionary.Add("Z", "Я");
                chDictionary.Add("X", "Ч");
                chDictionary.Add("C", "С");
                chDictionary.Add("V", "М");
                chDictionary.Add("B", "И");
                chDictionary.Add("N", "Т");
                chDictionary.Add("M", "Ь");
                chDictionary.Add("<", "Б");
                chDictionary.Add(">", "Ю");
                chDictionary.Add("?", ",");
                #endregion

                #region SHIFT + NUMBERS
                chDictionary.Add("@", "\"");
                chDictionary.Add("#", "№");
                chDictionary.Add("$", ";");
                chDictionary.Add("^", ":");
                chDictionary.Add("&", "?");
                #endregion
                #endregion

                #region Ru => Eng 
                #region Chars Down Ru => Eng
                chDictionary.Add("ё", "`");
                chDictionary.Add("й", "q");
                chDictionary.Add("ц", "w");
                chDictionary.Add("у", "e");
                chDictionary.Add("к", "r");
                chDictionary.Add("е", "t");
                chDictionary.Add("н", "y");
                chDictionary.Add("г", "u");
                chDictionary.Add("ш", "i");
                chDictionary.Add("щ", "o");
                chDictionary.Add("з", "p");
                chDictionary.Add("х", "[");
                chDictionary.Add("ъ", "]");
                chDictionary.Add("ф", "a");
                chDictionary.Add("ы", "s");
                chDictionary.Add("в", "d");
                chDictionary.Add("а", "f");
                chDictionary.Add("п", "g");
                chDictionary.Add("р", "h");
                chDictionary.Add("о", "j");
                chDictionary.Add("л", "k");
                chDictionary.Add("д", "l");
                chDictionary.Add("ж", ";");
                chDictionary.Add("э", "'");
                chDictionary.Add("я", "z");
                chDictionary.Add("ч", "x");
                chDictionary.Add("с", "c");
                chDictionary.Add("м", "v");
                chDictionary.Add("и", "b");
                chDictionary.Add("т", "n");
                chDictionary.Add("ь", "m");
                chDictionary.Add("б", ",");
                chDictionary.Add("ю", ".");
                //chDictionary.Add(".", "/");
                #endregion

                #region Chars Up Ru => Eng 
                chDictionary.Add("Ё", "~");
                chDictionary.Add("Й", "Q");
                chDictionary.Add("Ц", "W");
                chDictionary.Add("У", "E");
                chDictionary.Add("К", "R");
                chDictionary.Add("Е", "T");
                chDictionary.Add("Н", "Y");
                chDictionary.Add("Г", "U");
                chDictionary.Add("Ш", "I");
                chDictionary.Add("Щ", "O");
                chDictionary.Add("З", "P");
                chDictionary.Add("Х", "{");
                chDictionary.Add("Ъ", "}");
                chDictionary.Add("Ф", "A");
                chDictionary.Add("Ы", "S");
                chDictionary.Add("В", "D");
                chDictionary.Add("А", "F");
                chDictionary.Add("П", "G");
                chDictionary.Add("Р", "H");
                chDictionary.Add("О", "J");
                chDictionary.Add("Л", "K");
                chDictionary.Add("Д", "L");
                chDictionary.Add("Ж", ":");
                chDictionary.Add("Э", "\"");
                chDictionary.Add("Я", "Z");
                chDictionary.Add("Ч", "X");
                chDictionary.Add("С", "C");
                chDictionary.Add("М", "V");
                chDictionary.Add("И", "B");
                chDictionary.Add("Т", "N");
                chDictionary.Add("Ь", "M");
                chDictionary.Add("Б", "<");
                chDictionary.Add("Ю", ">");
                //chDictionary.Add(",", "?");
                #endregion

                #region SHIFT + NUMBERS
                //chDictionary.Add("\"", "@");
                chDictionary.Add("№", "#");
                //chDictionary.Add(";", "$");
                //chDictionary.Add(":", "^");
                //chDictionary.Add("?", "&");
                #endregion
                #endregion
            }
        }

        public static string TranslateLangChar(string Text)
        {
            string info = "";

            foreach (var ch in Text)
            {
                var temp = "";

                if (chDictionary.TryGetValue(ch.ToString(), out temp))
                {
                    info += temp;
                }
                else
                {
                    info += ch;
                }
            }

            return info;
        }

        #endregion
    }
}
