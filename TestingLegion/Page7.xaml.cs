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

namespace TestingLegion
{
    /// <summary>
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        internal Frame frame;
        public Page7()
        {
            InitializeComponent();
            
        }
        public Page7(Page6 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        public Page7(Page8 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        private void Answer1_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer2.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer5.IsChecked = false;
        }

        private void Answer2_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer5.IsChecked = false;
        }

        private void Answer3_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer2.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer5.IsChecked = false;
        }
        //correct answer
        private void Answer4_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer2.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer1.IsChecked = false;
            this.Answer5.IsChecked = false;
        }

        private void Answer5_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer2.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer1.IsChecked = false;
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            if (this.Answer4.IsChecked == true)
            {
                this.LabelAnswer.Content = "Поздравляем ответ правильный!";
                this.LabelAnswer.Foreground = Brushes.Black;
                this.LabelAnswer.Visibility = Visibility.Visible;
                this.Explication.Visibility = Visibility.Hidden;

            }
            else
            {
                this.LabelAnswer.Content = "Ответ не верный";
                this.LabelAnswer.Foreground = Brushes.Red;
                this.LabelAnswer.Visibility = Visibility.Visible;
                this.Explication.Visibility = Visibility.Visible;
                this.Explication.Text = "Пояснение:\nПротивоположные числа отличаются в 3 раза.";
            }
        }

        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page6(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page8(this));
        }
    }
}
