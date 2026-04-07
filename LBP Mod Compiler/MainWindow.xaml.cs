using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Net.WebRequestMethods;

namespace LBP_Mod_Compiler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", "/c node mod.js --build ctbx lbp1");
            Compile.Visibility = Visibility.Visible;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += (s, args) =>
            {
                Compile.Visibility = Visibility.Collapsed;
                timer.Stop();
            };
            timer.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", "/c node mod.js --build ctbx lbp1");
            Compile.Visibility = Visibility.Visible;
            LBP1.Visibility = Visibility.Collapsed;
            LBP1_Border.Visibility = Visibility.Collapsed;
            LBP2.Visibility = Visibility.Collapsed;
            Power.Visibility = Visibility.Collapsed;
            LBP3.Visibility = Visibility.Collapsed;
            PS4.Visibility = Visibility.Collapsed;
            PS4_text.Visibility = Visibility.Collapsed;
            Underscore.Visibility = Visibility.Collapsed;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += (s, args) =>
            {
                Compile.Visibility = Visibility.Collapsed;
                LBP1.Visibility = Visibility.Visible;
                LBP1_Border.Visibility = Visibility.Visible;
                LBP2.Visibility = Visibility.Visible;
                Power.Visibility = Visibility.Visible;
                Underscore.Visibility = Visibility.Visible;
                LBP3.Visibility = Visibility.Visible;
                PS4.Visibility = Visibility.Visible;
                PS4_text.Visibility = Visibility.Visible;
                timer.Stop();
            };
            timer.Start();
        }

        private void LBP2_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", "/c node mod.js --build ctbx lbp2");
            Compile.Visibility = Visibility.Visible;
            LBP1.Visibility = Visibility.Collapsed;
            LBP1_Border.Visibility = Visibility.Collapsed;
            LBP2.Visibility = Visibility.Collapsed;
            Power.Visibility = Visibility.Collapsed;
            LBP3.Visibility = Visibility.Collapsed;
            PS4.Visibility = Visibility.Collapsed;
            PS4_text.Visibility = Visibility.Collapsed;
            Underscore.Visibility = Visibility.Collapsed;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += (s, args) =>
            {
                Compile.Visibility = Visibility.Collapsed;
                LBP1.Visibility = Visibility.Visible;
                LBP1_Border.Visibility = Visibility.Visible;
                LBP2.Visibility = Visibility.Visible;
                Power.Visibility = Visibility.Visible;
                Underscore.Visibility = Visibility.Visible;
                LBP3.Visibility = Visibility.Visible;
                PS4.Visibility = Visibility.Visible;
                PS4_text.Visibility = Visibility.Visible;
                timer.Stop();
            };
            timer.Start();
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LBP3_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", "/c node mod.js --build ctbx lbp3");
            Compile.Visibility = Visibility.Visible;
            LBP1.Visibility = Visibility.Collapsed;
            LBP1_Border.Visibility = Visibility.Collapsed;
            LBP2.Visibility = Visibility.Collapsed;
            Power.Visibility = Visibility.Collapsed;
            LBP3.Visibility = Visibility.Collapsed;
            PS4.Visibility = Visibility.Collapsed;
            PS4_text.Visibility = Visibility.Collapsed;
            Underscore.Visibility = Visibility.Collapsed;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += (s, args) =>
            {
                Compile.Visibility = Visibility.Collapsed;
                LBP1.Visibility = Visibility.Visible;
                LBP1_Border.Visibility = Visibility.Visible;
                LBP2.Visibility = Visibility.Visible;
                Power.Visibility = Visibility.Visible;
                Underscore.Visibility = Visibility.Visible;
                LBP3.Visibility = Visibility.Visible;
                PS4.Visibility = Visibility.Visible;
                PS4_text.Visibility = Visibility.Visible;
                timer.Stop();
            };
            timer.Start();
        }

        private void PS4_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", "/c node mod.js --build ctbx lbp3ps4");
            Compile.Visibility = Visibility.Visible;
            LBP1.Visibility = Visibility.Collapsed;
            LBP1_Border.Visibility = Visibility.Collapsed;
            LBP2.Visibility = Visibility.Collapsed;
            Power.Visibility = Visibility.Collapsed;
            LBP3.Visibility = Visibility.Collapsed;
            PS4.Visibility = Visibility.Collapsed;
            PS4_text.Visibility = Visibility.Collapsed;
            Underscore.Visibility = Visibility.Collapsed;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += (s, args) =>
            {
                Compile.Visibility = Visibility.Collapsed;
                LBP1.Visibility = Visibility.Visible;
                LBP1_Border.Visibility = Visibility.Visible;
                LBP2.Visibility = Visibility.Visible;
                Power.Visibility = Visibility.Visible;
                Underscore.Visibility = Visibility.Visible;
                LBP3.Visibility = Visibility.Visible;
                PS4.Visibility = Visibility.Visible;
                PS4_text.Visibility = Visibility.Visible;
                timer.Stop();
            };
            timer.Start();
        }
    }
}


















