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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
       internal Frame frame;
        public Page3()
        {
            InitializeComponent();
        }
        public Page3(Page2 obj)
        {
            InitializeComponent();
            frame = obj.frame;
        }
        public Page3(Page4 obj)
        {
            InitializeComponent();
            frame = obj.frame;
        }
        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page2(this));
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page4(this));
        }

        private void BoxAnswer1_Checked(object sender, RoutedEventArgs e)
        {
            this.BoxAnswer2.IsChecked = false;
            this.BoxAnswer3.IsChecked = false;
            this.BoxAnswer4.IsChecked = false;

        }
        //whrite answer
        private void BoxAnswer2_Checked(object sender, RoutedEventArgs e)
        {
            this.BoxAnswer1.IsChecked = false;
            this.BoxAnswer3.IsChecked = false;
            this.BoxAnswer4.IsChecked = false;

        }

        private void BoxAnswer3_Checked(object sender, RoutedEventArgs e)
        {
            this.BoxAnswer1.IsChecked = false;
            this.BoxAnswer2.IsChecked = false;
            this.BoxAnswer4.IsChecked = false;
        }

        private void BoxAnswer4_Checked(object sender, RoutedEventArgs e)
        {
            this.BoxAnswer1.IsChecked = false;
            this.BoxAnswer2.IsChecked = false;
            this.BoxAnswer3.IsChecked = false;
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            if (this.BoxAnswer2.IsChecked==true)
            {
                this.LabelAnswer.Content = "Поздравляем ответ правильный!";
                this.LabelAnswer.Foreground = Brushes.Black;
                this.LabelAnswer.Visibility = Visibility.Visible;
                this.Explication.Visibility = Visibility.Hidden;
                this.BoxAnswer2.IsChecked = false;//обнуляем ячейку для повторного использования
            }
            else
            {
                this.LabelAnswer.Content = "Ответ не верный";
                this.LabelAnswer.Foreground = Brushes.Red;
                this.LabelAnswer.Visibility = Visibility.Visible;
                this.Explication.Visibility = Visibility.Visible;
                this.Explication.Text = "Пояснение:\nФигуры перемещаются в противоположные ячейки наискосок. При этом фигуры изменяют:\nили свой размер, или цвет, или угол.В каждой из четырех клеток свои правила изменения фигуры.";
            }
        }
    }
}
