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

namespace ModernDesign.MVVM.View
{
    /// <summary>
    /// Interaction logic for ThemeView.xaml
    /// </summary>
    public partial class ThemeView : UserControl
    {
        public ThemeView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Clear existing merged dictionaries
            Application.Current.Resources.MergedDictionaries.Clear();

            // Create and add the new theme dictionary
            ResourceDictionary newTheme = new ResourceDictionary()
            {
                Source = new Uri("/Theme/MenuButton.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Clear existing merged dictionaries
            Application.Current.Resources.MergedDictionaries.Clear();

            // Create and add the new theme dictionary
            ResourceDictionary newTheme = new ResourceDictionary()
            {
                Source = new Uri("/Theme/MenuButton-LBP3.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Clear existing merged dictionaries
            Application.Current.Resources.MergedDictionaries.Clear();

            // Create and add the new theme dictionary
            ResourceDictionary newTheme = new ResourceDictionary()
            {
                Source = new Uri("/Theme/MenuButton-LBP2.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }
    }
}
