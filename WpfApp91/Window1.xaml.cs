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
            if (Razreshenie.a == 1)
            {
                this.Width = 1920;
                this.Height = 1080;
            }
            WindowState = WindowState.Maximized;
            POBEDA_label.Content = pobeda;

            achievments();


            
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += timer_Tick;
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            NOJNICI.Width = 470;
            NOJNICI.Height = 308;

            KAMEN.Width = 360;
            KAMEN.Height = 308;

            BUMAGA.Width = 360;
            BUMAGA.Height = 308;
            timer.Stop();
        }
        private void Button_Click(object sender, RoutedEventArgs e)//ножницы
        {
            timer.Start();
            NOJNICI.Width = 440;
            NOJNICI.Height = 278;
            Random r = new Random();
            int r1 = r.Next(1, 4);
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ";
                NICK_WIN.Content = nickname + " ПРОИГРАЛ";

            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ";
                NICK_WIN.Content = nickname + " ВЫИГРАЛ";
                POBEDA_label.Content = pobeda ++ ;
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ";
                NICK_WIN.Content = "           НИЧЬЯ";
            }
            nickname = textbox1.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var form2 = new Window2();
            form2.Show();
            this.Close();

            Class1.vihodvmenu = true;
            
                form2.VernutsaVigruButton.Visibility = Visibility.Visible;
                form2.VernutsaVigruLabel.Visibility = Visibility.Visible;
            

        }
        
        private void Button_Click3(object sender, RoutedEventArgs e) ////КАМЕНЬ
        {
            timer.Start();
            KAMEN.Width = 330;
            KAMEN.Height = 278;
            Random r = new Random();
            int r1 = r.Next(1, 4);
            NICK_WIN.Content = nickname;
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ";
                NICK_WIN.Content = "           НИЧЬЯ";
            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ";
                NICK_WIN.Content = nickname + " ВЫИГРАЛ";
                POBEDA_label.Content = pobeda ++;
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ";
                NICK_WIN.Content = nickname + " ПРОИГРАЛ";
            }
            nickname = textbox1.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //БУМАГА
        {
            

            timer.Start();
            BUMAGA.Width = 330;
            BUMAGA.Height = 278;
            Random r = new Random();
            int r1 = r.Next(1, 4);
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ";
                NICK_WIN.Content = nickname + " ВЫИГРАЛ";
                POBEDA_label.Content = pobeda ++;
            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ";
                NICK_WIN.Content = "           НИЧЬЯ";
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ";
                NICK_WIN.Content = nickname + " ПРОИГРАЛ";
            }
            nickname = textbox1.Text;

            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        
        private void achievments()
        {
            if (pobeda == 25)
            {
                achievment.Visibility = Visibility.Visible;
            }

        }
    }
}
