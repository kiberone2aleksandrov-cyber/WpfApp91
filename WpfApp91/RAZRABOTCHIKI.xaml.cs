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
using System.Windows.Shapes;

namespace WpfApp91
{
    /// <summary>
    /// Логика взаимодействия для RAZRABOTCHIKI.xaml
    /// </summary>
    public partial class RAZRABOTCHIKI : Window
    {
        public RAZRABOTCHIKI()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var form2 = new Window2();
            form2.Show();
            this.Close();
            if (Class1.GGG == true)
            {
                form2.VernutsaVigruButton.Visibility = Visibility.Visible;
                form2.VernutsaVigruLabel.Visibility = Visibility.Visible;
            }
            else if (Class1.GGG == false)
            {
                form2.VernutsaVigruButton.Visibility = Visibility.Hidden;
                form2.VernutsaVigruLabel.Visibility = Visibility.Hidden;
            }
            
            
            
        }
    }
}
