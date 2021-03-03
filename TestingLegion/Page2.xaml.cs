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


//44
//43
//45
//46
//42
//Пояснение:
//Здесь заложена последовательность: +4 к каждому последующему числу. (25 + 4 = 29;
//29 + 4 = 33; 33 + 4 = 37; 37 + 4 = 41; 41 + 4 = 45).
namespace TestingLegion
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        internal Frame frame;
        bool match;
        public Page2()
        {
            InitializeComponent();
            match = false;
         
        }

        public Page2(MainWindow obj)
        {
            InitializeComponent();
            frame = obj.frame;
        }

        public Page2(Page3 obj)
        {
            InitializeComponent();
            frame = obj.frame;
        }
        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page3(this));
        }

        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Chek44_Checked(object sender, RoutedEventArgs e)
        {
            this.Chek42.IsChecked = false;
            this.Chek43.IsChecked = false;
            this.Chek45.IsChecked = false;
            this.Chek46.IsChecked = false;

        }

        private void Chek43_Checked(object sender, RoutedEventArgs e)
        {
            this.Chek42.IsChecked = false;
            this.Chek45.IsChecked = false;
            this.Chek46.IsChecked = false;
            this.Chek44.IsChecked = false;
        }
        //правильный ответ
        private void Chek45_Checked(object sender, RoutedEventArgs e)
        {
            match = true;
            this.Chek42.IsChecked = false;
            this.Chek43.IsChecked = false;
            this.Chek46.IsChecked = false;
            this.Chek44.IsChecked = false;

        }

        private void Chek46_Checked(object sender, RoutedEventArgs e)
        {
            this.Chek42.IsChecked = false;
            this.Chek43.IsChecked = false;
            this.Chek45.IsChecked = false;
            this.Chek44.IsChecked = false;
        }

        private void Chek42_Checked(object sender, RoutedEventArgs e)
        {
            this.Chek46.IsChecked = false;
            this.Chek43.IsChecked = false;
            this.Chek45.IsChecked = false;
            this.Chek44.IsChecked = false;
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            if (match==false)
            {
                this.LabelAnswer.Content = "Ответ не верный";
                this.LabelAnswer.Visibility = Visibility.Visible;
                this.Explication.Visibility = Visibility.Visible;
                this.Explication.Text = "Пояснение:\nЗдесь заложена последовательность: +4 к каждому последующему числу. (25 + 4 = 29\n29 + 4 = 33; 33 + 4 = 37; 37 + 4 = 41; 41 + 4 = 45).";

            }
            else
            {

                this.LabelAnswer.Content = "Поздравляем ответ правильный!";
                this.LabelAnswer.Foreground = Brushes.Black;
                this.LabelAnswer.Visibility = Visibility.Visible;
                this.Explication.Visibility = Visibility.Hidden;
                match = false;
            }
        }
    }
}
