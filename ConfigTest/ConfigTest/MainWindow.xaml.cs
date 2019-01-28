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

using System.Configuration;

namespace ConfigTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var var1Value = ConfigurationManager.AppSettings["Var1"];
            var var2Value = ConfigurationManager.AppSettings["Var2"];
            var var3Value = ConfigurationManager.AppSettings["Var3"];
            var conn1 = ConfigurationManager.ConnectionStrings["SQLConnectionString01"];
            var conn2 = ConfigurationManager.ConnectionStrings["SQLConnectionString02"];

            Console.WriteLine("Values from config01.config and connString01.config files");

            Console.WriteLine("Var1={0}", var1Value);
            Console.WriteLine("Var2={0}", var2Value);
            Console.WriteLine("Var3={0}", var3Value);
            Console.WriteLine("ConnStr01={0}", conn1);
            Console.WriteLine("ConnStr01={0}", conn2);

            TBName.Text = Properties.Settings.Default.MyStringProperty;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.MyStringProperty = TBName.Text;
            Properties.Settings.Default.Save();
        }
    }
}
