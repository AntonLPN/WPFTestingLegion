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
    /// Логика взаимодействия для Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        internal Frame frame;
        public Page9()
        {
            InitializeComponent();
        }
        public Page9(Page8 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }

        public Page9(Page10 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        private void Answer2_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer5.IsChecked = false;
        }

        private void Answer1_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer2.IsChecked = false;
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
            this.Answer3.IsChecked = false;
            this.Answer2.IsChecked = false;
            this.Answer5.IsChecked = false;
        }

        private void Answer5_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer2.IsChecked = false;
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            if (Answer2.IsChecked == true)
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
                this.Explication.Text = "Пояснение:\nВ первой строке: +2, +4, +8(это два в степени 1, 2, 3).Во второй строке: +3, +9, +27(это три в\n степени 1, 2, 3).В третьей строке: +4, +16, +64(это четыре в степени 1, 2, 3).\nВ итоге: 11 + 16 = 27.";
            }
        }

        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page8(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page10(this));
        }
    }
}
