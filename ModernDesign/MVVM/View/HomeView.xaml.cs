using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Collections.ObjectModel;
using ModernDesign.MVVM.ViewModel;

namespace ModernDesign.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {

        public static string SelectedFolder { get; set; }
        public static string SelectedFolderName { get; set; }



        public ObservableCollection<DirectoryInfo> Folders { get; set; }
        public HomeView()
        {
            InitializeComponent();
            string root = AppDomain.CurrentDomain.BaseDirectory;

            // Define your target path
            string path = $@"{root}/mods/";
            DirectoryInfo directory = new DirectoryInfo(path);

            // Get subdirectories and initialize the collection
            var Folders = new ObservableCollection<DirectoryInfo>(directory.GetDirectories());

            // Set the DataContext so the XAML can find the "Folders" property
            this.DataContext = this;

        }

        public ObservableCollection<FileInfo> Files { get; set; }




            private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", $"/c node mod.js --build {HomeView.SelectedFolderName} lbp1");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", $"/c node mod.js --build {HomeView.SelectedFolderName} lbp2");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", $"/c node mod.js --build {HomeView.SelectedFolderName} lbp3ps4");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", $"/c node mod.js --build {HomeView.SelectedFolderName} lbp3");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SelectedFolder = dialog.SelectedPath; // Stored here
                SelectedFolderName = System.IO.Path.GetFileName(dialog.SelectedPath);

            }
        }
    }
}
