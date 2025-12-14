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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace WpfApp91
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string nickname;
        public int pobeda = 0;
        

        DispatcherTimer timer = new DispatcherTimer();
        public Window1()
        {          
            InitializeComponent();
           
            WindowState = WindowState.Maximized;
            POBEDA_label.Content = pobeda;
            
            timer.Interval = TimeSpan.FromMilliseconds(5000);
            timer.Tick += timer_Tick;
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            achievment.Visibility = Visibility.Hidden;
            timer.Stop();
        }
        
        private void AnimateSize(FrameworkElement target, double toW, double toH, double durationMs = 200, IEasingFunction easing = null)//gpt
        {
            var dur = TimeSpan.FromMilliseconds(durationMs);

            var animW = new DoubleAnimation
            {
                To = toW,
                Duration = new Duration(dur),
                EasingFunction = easing
            };

            var animH = new DoubleAnimation
            {
                To = toH,
                Duration = new Duration(dur),
                EasingFunction = easing
            };

            target.BeginAnimation(FrameworkElement.WidthProperty, animW);
            target.BeginAnimation(FrameworkElement.HeightProperty, animH);
        }
        private async void Button_Click(object sender, RoutedEventArgs e)//ножницы
        {
            AnimateSize(NOJNICI, 440, 278, durationMs: 80, easing: new CubicEase { EasingMode = EasingMode.EaseOut }); //gpt
            // подождать пока "вжатие" закончится
            await Task.Delay(100);//gpt
              // плавно вернуть исходный размер
            AnimateSize(NOJNICI, 470, 308, durationMs: 180, easing: new CubicEase { EasingMode = EasingMode.EaseOut });//gpt

            Random r = new Random();
            int r1 = r.Next(1, 4);
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ";
                nick_label.Visibility = Visibility.Visible;
                NICK_WIN.Content = "ПРОИГРАЛ";

            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ";
                nick_label.Visibility = Visibility.Visible;
                NICK_WIN.Content = "ВЫИГРАЛ";
                pobeda++;
                POBEDA_label.Content = pobeda ;
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ";
                nick_label.Visibility = Visibility.Hidden;
                NICK_WIN.Content = "НИЧЬЯ";
            }
           
            if (pobeda == 15)
            {
                timer.Start();
                achievment.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var form2 = new Window2();
            form2.Show();
            this.Close();

            Class1.vihodvmenu = true;
            
                form2.VernutsaVigruButton.Visibility = Visibility.Visible;
                form2.VernutsaVigruLabel.Visibility = Visibility.Visible;
            Class1.GGG = true;
            

        }
        
        private async void Button_Click3(object sender, RoutedEventArgs e) ////КАМЕНЬ
        {
            
            //gpt
            AnimateSize(KAMEN, 330, 278, durationMs: 80, easing: new CubicEase { EasingMode = EasingMode.EaseOut }); 
                 // подождать пока "вжатие" закончится
            await Task.Delay(100);
                 // плавно вернуть исходный размер
            AnimateSize(KAMEN, 360, 308, durationMs: 180, easing: new CubicEase { EasingMode = EasingMode.EaseOut });
            //

            Random r = new Random();
            int r1 = r.Next(1, 4);
            NICK_WIN.Content = nickname;
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ";
                nick_label.Visibility = Visibility.Hidden;
                NICK_WIN.Content = "НИЧЬЯ";
            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ";
                nick_label.Visibility = Visibility.Visible;
                NICK_WIN.Content = "ВЫИГРАЛ";
                POBEDA_label.Content = pobeda ++;
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ";
                nick_label.Visibility = Visibility.Visible;
                NICK_WIN.Content = "ПРОИГРАЛ";
            }
            
            if (pobeda == 15)
            {
                timer.Start();
                achievment.Visibility = Visibility.Visible;
            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e) //БУМАГА
        {
           
            //gpt
            AnimateSize(BUMAGA, 330, 278, durationMs: 80, easing: new CubicEase { EasingMode = EasingMode.EaseOut });
            // подождать пока "вжатие" закончится
            await Task.Delay(100);
            // плавно вернуть исходный размер
            AnimateSize(BUMAGA, 360, 308, durationMs: 180, easing: new CubicEase { EasingMode = EasingMode.EaseOut });
            //
           
            Random r = new Random();
            int r1 = r.Next(1, 4);
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ";
                nick_label.Visibility = Visibility.Visible;
                NICK_WIN.Content = "ВЫИГРАЛ";
                POBEDA_label.Content = pobeda ++;
            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ";
                nick_label.Visibility = Visibility.Hidden;
                NICK_WIN.Content = "НИЧЬЯ";
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ";
                nick_label.Visibility = Visibility.Visible;
                NICK_WIN.Content = "ПРОИГРАЛ";
            }
            

            if (pobeda == 15)
            {
                timer.Start();
                achievment.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            nick_label.Visibility = Visibility.Visible;
            nick_label.Content = textbox1.Text;
            if(textbox1.Text == "" || textbox1.Text == " " || textbox1.Text == "  " || textbox1.Text == "   " || textbox1.Text == "    " || textbox1.Text == "     " || textbox1.Text == "      " || textbox1.Text == "       " || textbox1.Text == "        ")
            {
                nick_label.Content = "            ТЫ";
            }
        }
        
        
    }
}
