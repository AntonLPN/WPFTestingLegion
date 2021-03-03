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
    /// Логика взаимодействия для Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        internal Frame frame;
        public Page10()
        {
            InitializeComponent();
        }

        public Page10(Page9 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        public Page10(Page11 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }
        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page9(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page11(this));
        }

   

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            if (Answer3.IsChecked == true && Answer4.IsChecked == true && Answer1.IsChecked!=true && Answer2.IsChecked!=true)
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
                this.Explication.Text = "Пояснение:\n3 и 4.";
            }
        }
    }
}
