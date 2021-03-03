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
    /// Логика взаимодействия для PageEnd.xaml
    /// </summary>
    public partial class PageEnd : Page
    {
        internal Frame frame;
        public PageEnd()
        {
            InitializeComponent();
        }
        public PageEnd(Page11 obj)
        {
            InitializeComponent();
            this.frame = obj.frame;
        }

        private void ButtonPrew_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Page11(this));
        }
    }
}
