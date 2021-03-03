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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        internal Frame frame;
        public Page6()
        {
            InitializeComponent();
        }
        public Page6(Page5 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        public Page6(Page7 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        //correct answer
        private void BoxAnswer1_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer2.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
           
        }

        private void BoxAnswer2_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer4.IsChecked = false;
           
        }

        private void BoxAnswer3_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer2.IsChecked = false;
            this.Answer4.IsChecked = false;
        }

        private void BoxAnswer4_Checked(object sender, RoutedEventArgs e)
        {
            this.Answer1.IsChecked = false;
            this.Answer3.IsChecked = false;
            this.Answer2.IsChecked = false;
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            if (this.Answer1.IsChecked == true)
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
                this.Explication.Text = "Пояснение:\nКаждая строка и каждый столбец содержит: одно изображение с горизонтальным полукругом и\n два изображения с вертикальными полукругами; горизонтальные полукруги окрашены в\n одинаковый цвет; в каждом изображении вертикальные полукруги окрашены в разный цвет";
            }
        }

        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page5(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page7(this));
        }
    }
}
