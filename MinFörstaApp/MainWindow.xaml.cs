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

namespace MinFörstaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            HejText.Content = "(<´´<) (^´´^) (>´´>)";
            counterButton.Text = Counter.ToString();
            HejText.FontSize = 48;

            //TextBlock minText = new TextBlock();
            //minText.Text = "KIIIRRRBBBBYYY";
            //MinKirbyPanel.Children.Add(minText);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Counter++;
            counterButton.Text = Counter.ToString();

        }
        private void ellerHär(object sender, RoutedEventArgs e)
        {
            Counter--;
            counterButton.Text = Counter.ToString();
        }
        private void kirbyDance(object sender, RoutedEventArgs e)
        {




        }
    }
}
