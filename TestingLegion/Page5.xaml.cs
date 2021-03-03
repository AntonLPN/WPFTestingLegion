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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {

        internal Frame frame;
        public Page5()
        {
            InitializeComponent();
        }

        public Page5(Page4 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        public Page5(Page6 obj)
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
            if (this.Answer5.IsChecked == true)
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
                this.Explication.Text = "Пояснение:\nВнутри круга числа складываются, а числа вне круга вычитаются. Итоговая сумма равна числу\n внутри треугольника. 5 + 17 + 24 - 3 - 9 - 18 = 16; 7 + 15 + 35 - 8 - 14 - 23 = 12; 14 + 23 + 45 - 7\n - 26 - 39 = 10.";
            }
        }

        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page4(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page6(this));
        }
    }
}
