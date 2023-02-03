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

namespace Multi_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currency1;
        public string currency2;
        public string stringconvertedRate;
        public double userInput;
        public double[] convertedRate = { 1.0,.92103,129.53,.80640,1.43465,1.33761,.91998,
                                6.78136,7.82839,1.54436};
        public MainWindow()
        {
            InitializeComponent();
        }

        private void minimize_win(object sender, RoutedEventArgs e)
        {

        }
        private void resize_win(object sender, RoutedEventArgs e)
        {

        }
        private void close_win(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Text_right_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Text_left_TextChanged(object sender, TextChangedEventArgs e)
        {
            Text_right.Text = Text_left.Text;
        }

        private void right_combo_box_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value = (ComboBoxItem)right_combo_box.SelectedItem;
            currency2 = selected_value.Name;
            Text_right.Text = currency2;
        }

        private void left_combo_box_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value = (ComboBoxItem)left_combo_box.SelectedItem;
            currency1 = selected_value.Name;
            switch (currency1)
            {
                case "USD1":
                    double resultedRate = convertedRate[0] * userInput;
                    stringconvertedRate = resultedRate.ToString();
                    Text_right.Text = stringconvertedRate;
                    break;
                case "EUR1":
                    stringconvertedRate = convertedRate[1].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "GBP1":
                    stringconvertedRate = convertedRate[2].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "JPY1":
                    stringconvertedRate = convertedRate[3].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "AUD1":
                    stringconvertedRate = convertedRate[4].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "CAD1":
                    stringconvertedRate = convertedRate[5].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "CHF1":
                    stringconvertedRate = convertedRate[6].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "CNH1":
                    stringconvertedRate = convertedRate[7].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "HKD1":
                    stringconvertedRate = convertedRate[8].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;
                case "NZD1":
                    stringconvertedRate = convertedRate[9].ToString();
                    Text_left.Text = stringconvertedRate;
                    break;

            }
        }

    }
}
