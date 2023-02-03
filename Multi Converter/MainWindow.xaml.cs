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
        public string userInput;
        public double[] convertedRate = { 1.0,131.04,.92,.83,1.44,1.34,.92,6.78,7.85,1.57};
        public string[] currencies = { "USD",};
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
            userInput = Text_left.Text;
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
                    for (int i = 0; i < convertedRate.Length; i++)
                    {
                        if (currencies[i] == currency2)
                            //double resultedRate = convertedRate[i] * Convert.ToDouble(userInput);
                            //stringconvertedRate = resultedRate.ToString();
                            Text_right.Text = stringconvertedRate;
                    }
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
