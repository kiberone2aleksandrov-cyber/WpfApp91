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

namespace WpfApp91
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)//ножницы
        {
            Random r = new Random();
            int r1 = r.Next(1, 4);
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ \n ВЫ ПРОИГРАЛИ";
            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ \n ВЫ ВЫИГРАЛИ";
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ \n   НИЧЬЯ";
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
            
            
        }
        
        private void Button_Click3(object sender, RoutedEventArgs e) ////КАМЕНЬ
        {
            Random r = new Random();
            int r1 = r.Next(1, 4);
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ \n    НИЧЬЯ";
            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ \n ВЫ ПРОИГРАЛИ";
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ \n ВЫ ВЫИГРАЛИ";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //БУМАГА
        {
            Random r = new Random();
            int r1 = r.Next(1, 4);
            if (r1 == 1)
            {
                labelResult.Content = "БОТ ВЫБРАЛ КАМЕНЬ \n ВЫ ВЫИГРАЛИ";
            }
            else if (r1 == 2)
            {
                labelResult.Content = "БОТ ВЫБРАЛ БУМАГУ \n    НИЧЬЯ";
            }
            else if (r1 == 3)
            {
                labelResult.Content = "БОТ ВЫБРАЛ НОЖНИЦЫ \n ВЫ ПРОИГРАЛИ";
            }
        }
    }
}
