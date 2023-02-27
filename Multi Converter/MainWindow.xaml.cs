using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public string time;
        public double initialRate;
        public double nextRate;
        public string userInput;
        public double[] convertedRate = { 1.0,131.04,.92,.83,1.44,1.34,.92,6.78,7.85,1.57};
        public string[] currencies = { "USD2","JPY2","EUR2","GBP2","AUD2","CAD2","HF2","CNH2","HK2","NZD2"};
        public MainWindow()
        {
            InitializeComponent();

            optionsBox.SelectedIndex = 0;

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
        private void Options_combo_box(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value2 = (ComboBoxItem)optionsBox.SelectedItem;
            time = selected_value2.Name;
            Trace.WriteLine(time);
            if (optionsBox.SelectedIndex == 0 )
            {
                left_combo_box.Visibility = Visibility.Hidden;
                right_combo_box.Visibility = Visibility.Hidden;
                Text_left.Visibility = Visibility.Hidden;
                Text_right.Visibility = Visibility.Hidden;
                arrows.Visibility = Visibility.Hidden;

                time_text.Visibility = Visibility.Visible;
                hours_text.Visibility = Visibility.Visible;
                min_text.Visibility = Visibility.Visible;
                sec_text.Visibility = Visibility.Visible;
                t_convo_type.Visibility = Visibility.Visible;
                time_text_out.Visibility = Visibility.Visible;  
            }
            else if (optionsBox.SelectedIndex == 1)
            {
                time_text.Visibility = Visibility.Hidden;
                hours_text.Visibility = Visibility.Hidden;
                min_text.Visibility = Visibility.Hidden;
                sec_text.Visibility = Visibility.Hidden;
                t_convo_type.Visibility = Visibility.Hidden;
                time_text_out.Visibility = Visibility.Hidden;

                left_combo_box.Visibility = Visibility.Hidden;
                right_combo_box.Visibility = Visibility.Hidden;
                Text_left.Visibility = Visibility.Hidden;
                Text_right.Visibility = Visibility.Hidden;
                arrows.Visibility = Visibility.Hidden;
            }
            else if(optionsBox.SelectedIndex == 2)
            {

                time_text.Visibility = Visibility.Hidden;
                hours_text.Visibility = Visibility.Hidden;
                min_text.Visibility = Visibility.Hidden;
                sec_text.Visibility = Visibility.Hidden;
                t_convo_type.Visibility = Visibility.Hidden;
                time_text_out.Visibility = Visibility.Hidden;

                left_combo_box.Visibility = Visibility.Visible;
                right_combo_box.Visibility = Visibility.Visible;
                Text_left.Visibility = Visibility.Visible;
                Text_right.Visibility = Visibility.Visible;
                arrows.Visibility = Visibility.Visible;    
            }

            
        }

        private void right_combo_box_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value = (ComboBoxItem)right_combo_box.SelectedItem;
            currency2 = selected_value.Name;
        }

        private void left_combo_box_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selected_value = (ComboBoxItem)left_combo_box.SelectedItem;
            currency1 = selected_value.Name;
        }
        public static double converter(double initialRate, string userInput, double nextRate)
        {
   
            double USDRate;
            double.TryParse(userInput, out USDRate);
            double TempAmount = USDRate / initialRate;
            TempAmount = TempAmount * nextRate;
            TempAmount = Math.Round(TempAmount, 2);
            return TempAmount;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void time_convo_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (t_convo_type.SelectedIndex == 0)
            {
                temp_convo_name.Text = "Hours";
            }
            if (t_convo_type.SelectedIndex == 1)
            {
                temp_convo_name.Text = "Minutes";
            }
            if (t_convo_type.SelectedIndex == 2)
            {
                temp_convo_name.Text = "Seconds";
            }
            

            double result;

            double hour;
            double min;
            double sec;

            double.TryParse(hours_text.Text, out hour);
            double.TryParse(min_text.Text, out min);
            double.TryParse(sec_text.Text, out sec);

            if(t_convo_type.SelectedIndex == 0)
            {
                time_text_out.Text = Math.Round((hour + (min / 60) + (sec / 120)), 2).ToString();
            }
            if (t_convo_type.SelectedIndex == 1)
            {
                time_text_out.Text = Math.Round(((hour * 60) + min + (sec / 60)), 2).ToString();
            }
            if (t_convo_type.SelectedIndex == 2)
            {
                time_text_out.Text = Math.Round(((hour * 3600) + (min * 60) + sec), 2).ToString();
            }
        }
    }
}
