using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GhostShtuff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Manager.Instance;
        }

        private void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            Manager.Instance.Log(this.txtOutput, "Attempting to connect to the default target...");

            try
            {
                Manager.Instance.PS3.ConnectTarget();
                Manager.Instance.PS3.AttachProcess();
                Manager.Instance.Log(this.txtOutput, "Successfully connected to target and attached to current process.");
            }
            catch(Exception ee)
            {
                Manager.Instance.Log(this.txtOutput, ee.Message, Manager.LogType.ERROR);
            }
        }
    }
}
