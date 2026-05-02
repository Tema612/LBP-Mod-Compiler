using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Media;



namespace ModernDesign.MVVM.View
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class ConfigView : UserControl
    {
        public ConfigView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filter to show text files and all files
            openFileDialog.Filter = "Workbench Config (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Show the dialog
            if (openFileDialog.ShowDialog() == true)
            {
                // Read the file content and set it to AvalonEdit
                string filePath = openFileDialog.FileName;
                textEditor.Text = File.ReadAllText(filePath);

                // Optional: Set highlighting based on file type
                // textEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("C#");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.DefaultExt = ".json";
            dlg.Filter = "Workbench Config (*.json)|*.json|All Files (*.*)|*.*";
            dlg.FileName = "config";

            if (dlg.ShowDialog() == true)
            {
                // Save the content of the AvalonEdit component
                textEditor.Save(dlg.FileName);
            }
        }
    }
}
