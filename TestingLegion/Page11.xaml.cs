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
    /// Логика взаимодействия для Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        internal Frame frame;
        public Page11()
        {
            InitializeComponent();


        }
        public Page11(Page10 obj)
        {
            InitializeComponent();

            this.frame = obj.frame;
        }
        public Page11(PageEnd obj)
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
        //corect answer
        private void Answer2_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
            this.Answer5.IsChecked = false;
        }

        private void Answer3_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer2.IsChecked = false;
            this.Answer1.IsChecked = false;
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

        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page10(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new PageEnd(this));
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
                this.Explication.Text = "Пояснение:\nЗдесь идет последовательность: (7 + 5) - (8 - 2) ÷ 2 = 9; (8 + 5) - (9 - 3) ÷ 2 = 10;\n(12 + 11) - (15 - 3) ÷ 2 = 17.";
            }
        }
    }
}
