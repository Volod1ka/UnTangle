using System;
using System.Collections.Generic;
using System.Threading;

namespace UnTangle.Scripts.Engine
{
    internal static class ClipboardData
    {
        #region Variables

        public static IDictionary<string, object> TempClipboard { get; set; }

        #endregion

        #region Public Methods

        public static bool ContainsText()
        {
            bool access = false;

            Thread STAThread = new Thread(
                delegate ()
                {
                    try
                    {
                        access = System.Windows.Forms.Clipboard.ContainsText();
                    }
                    catch (Exception)
                    {
                        access = false;
                    }
                });
            STAThread.SetApartmentState(ApartmentState.STA);
            STAThread.Start();
            STAThread.Join();

            return access;
        }
        
        public static void SetText(string p_Text)
        {
            Thread STAThread = new Thread(
                delegate ()
                {
                    try
                    {
                        System.Windows.Forms.Clipboard.SetText(p_Text);
                    }
                    catch (Exception) { }
                });
            STAThread.SetApartmentState(ApartmentState.STA);
            STAThread.Start();
            STAThread.Join();
        }
        
        public static string GetText()
        {
            string ReturnValue = string.Empty;

            Thread STAThread = new Thread(
                delegate ()
                {
                    try
                    {
                        ReturnValue = System.Windows.Forms.Clipboard.GetText();
                    }
                    catch (Exception)
                    {
                        ReturnValue = " ";
                    }
                });
            STAThread.SetApartmentState(ApartmentState.STA);
            STAThread.Start();
            STAThread.Join();

            return ReturnValue;
        }
        
        public static void ClipboardClear()
        {
            Thread STAThread = new Thread(
                delegate ()
                {
                    try
                    {
                        System.Windows.Forms.Clipboard.Clear();
                    }
                    catch (Exception) { }
                });
            STAThread.SetApartmentState(ApartmentState.STA);
            STAThread.Start();
            STAThread.Join();
        }
        
        public static IDictionary<string, object> GetClipboardData()
        {
            var dict = new Dictionary<string, object>();

            Thread STAThread = new Thread(
                delegate ()
                {
                    try
                    {
                        var dataObject = System.Windows.Forms.Clipboard.GetDataObject();

                        foreach (var format in dataObject.GetFormats())
                        {
                            dict.Add(format, dataObject.GetData(format));
                        }
                    }
                    catch (Exception) { }
                });
            STAThread.SetApartmentState(ApartmentState.STA);
            STAThread.Start();
            STAThread.Join();

            return dict;
        }
        
        public static void SetClipboardData(IDictionary<string, object> Dictionary)
        {
            try
            {
                System.Windows.Forms.IDataObject dataObject = new System.Windows.Forms.DataObject();

                foreach (var kvp in Dictionary)
                {
                    dataObject.SetData(kvp.Key, kvp.Value);
                }

                System.Windows.Forms.Clipboard.SetDataObject(dataObject);
            }
            catch (Exception) { }
        }

        #endregion
    }
}
