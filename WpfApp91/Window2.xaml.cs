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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp91
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            TextAnimation();
        }
        private void TextAnimation()
        {
            ColorAnimation textanim = new ColorAnimation
            {
                From = Colors.LightGray,
                To = Colors.Gray,
                Duration = new Duration(TimeSpan.FromMilliseconds(1000)),
                RepeatBehavior = RepeatBehavior.Forever,
                AutoReverse = true
            };

            label1.Foreground = new SolidColorBrush(Colors.DarkGray);
            label1.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, textanim);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //назад в игру
        {

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //в меню
        {

        }
    }

}
