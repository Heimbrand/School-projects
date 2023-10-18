using System;
using System.Collections.Generic;
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
using Microsoft.Win32;
using Path = System.IO.Path;

namespace textläsning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _filePath = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
            var dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TextDemo");
            Directory.CreateDirectory(dirPath);
            _filePath = Path.Combine(dirPath, "Demo.Txt");

        }
        private void SaveFileBtn_OnClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                var stream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                var text = new TextRange(MainTextBox.Document.ContentStart, MainTextBox.Document.ContentEnd);
                text.Save(stream, DataFormats.Text);

                //var text = MainTextBox.Text;
                //using var sw = new StreamWriter(saveFileDialog.FileName);
                //sw.Write(text);
            }

        }
        private void OpenFileBtn_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                using var sr = new StreamReader(openFileDialog.FileName);
                var text = sr.ReadToEnd();
                MainTextBox.Text = text;
            }


        }
        private void ToggleBoldBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (ToggleBoldBtn.IsChecked == true)
            {
                MainTextBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                MainTextBox.FontWeight = FontWeights.Normal;
            }
        }
    }
}
