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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        internal Frame frame;
        public Page4()
        {
            InitializeComponent();
        }
        public Page4(Page3 obj)
        {
            InitializeComponent();
            frame = obj.frame;
        }

        public Page4(Page5 obj)
        {
            InitializeComponent();
            frame = obj.frame;
        }
        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page3(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page5(this));
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
                this.Explication.Text = "Поснение:\nЗдесь присутствует чередующаяся последовательность: +5, -2, +5, -2, ... (12 + 5 = 17; 17 - 2 =\n 15; ... 18 + 5 = 23; 23 - 2 = 21).";
            }
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

        private void Answer4_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer2.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer5.IsChecked = false;
        }

        private void Answer5_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer2.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer3.IsChecked = false;
        }
    }
}
