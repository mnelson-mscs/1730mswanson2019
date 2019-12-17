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

namespace mswanson3c1
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                resultTextBox0.Text = Ex3cCalculations.Calc0(int.Parse(inputTextBox0a.Text)).ToString();
            }
            catch
            {
                resultTextBox1.Text = "Invalid input";
            }


            try
            {
                resultTextBox1.Text = Ex3cCalculations.Calc1(inputTextBox1a.Text.Trim().ToUpper());
            }
            catch
            {
                resultTextBox1.Text = "Invalid input";
            }

            try
            {
                int[] numbers2 = { 11, 22, 23, 34, 10 };
                resultTextBox2.Text = Ex3cCalculations.Calc2(numbers2).ToString();
            }
            catch
            {
                resultTextBox1.Text = "Invalid input";
            }
        }

        private void addItemButton4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");
        }
    }
}
