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
        public double initialRate;
        public double nextRate;
        public string userInput;
        public double[] convertedRate = { 1.0,131.04,.92,.83,1.44,1.34,.92,6.78,7.85,1.57};
        public string[] currencies = { "USD2","JPY2","EUR2","GBP2","AUD2","CAD2","HF2","CNH2","HK2","NZD2"};
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
            ComboBoxItem selected_value = (ComboBoxItem)left_combo_box.SelectedItem;
            currency1 = selected_value.Name;

            for (int i = 0; i < currencies.Length; i++)
            {
                if (currency2 == currencies[i])
                {
                    nextRate = convertedRate[i];
                }
            }

            switch (currency1)
            {
                case "USD1":
                    initialRate = convertedRate[0];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "JPY1":
                    initialRate = convertedRate[1];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "EUR1":
                    initialRate = convertedRate[2];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "GBP1":
                    initialRate = convertedRate[3];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "AUD1":
                    initialRate = convertedRate[4];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "CAD1":
                    initialRate = convertedRate[5];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "CHF1":
                    initialRate = convertedRate[6];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "CNH1":
                    initialRate = convertedRate[7];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "HKD1":
                    initialRate = convertedRate[8];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;
                case "NZD1":
                    initialRate = convertedRate[9];
                    Text_right.Text = converter(initialRate, userInput, nextRate).ToString();
                    break;

            }
        }

        private void right_combo_box_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value = (ComboBoxItem)right_combo_box.SelectedItem;
            currency2 = selected_value.Name;
            Text_right.Text = currency2;
        }

        private void left_combo_box_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }
        public static double converter(double initialRate, string userInput, double nextRate) 
        {
            double USDRate = Convert.ToDouble(userInput)/initialRate;

            return USDRate;
        }

    }
}
