using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PS3Lib;

namespace GhostShtuff
{
    public sealed class Manager
    {
        private static readonly Lazy<Manager> lazy =
        new Lazy<Manager>
            (() => new Manager());

        public static Manager Instance { get { return lazy.Value; } }

        public PS3API PS3 { get; set; }

        public Definitions def { get; set; }

        private Manager()
        {
            PS3 = new PS3API(SelectAPI.TargetManager);

            def = new Definitions();
        }

        public enum LogType
        {
            DEFAULT,
            WARNING,
            ERROR
        }

        //Change how logging works, this is gross but its just for initial testing. I could just use Console.WriteLine 
        public void Log(RichTextBox r, string output, LogType type = LogType.DEFAULT)
        {
            string tmp = string.Empty;
            tmp += (type == LogType.DEFAULT ? "" : "[ " + type.ToString() + " ] ") + "@" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "\t";
            tmp += output + Environment.NewLine;

            Application.Current.Dispatcher.Invoke(() =>
           {
               r.AppendText(tmp);
           });
        }
    }
}
