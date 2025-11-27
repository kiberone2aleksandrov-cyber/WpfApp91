using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp91;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    
    public MainWindow()
    {      
        InitializeComponent();       
        TextAnimation();
        if (Razreshenie.a == 1)
        {
            this.Width = 1920;
            this.Height = 1080;
        }
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

        mainlabel.Foreground = new SolidColorBrush(Colors.DarkGray);
        mainlabel.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, textanim);

    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        var form1 = new Window1();
        form1.Show();
        this.Close();
    }

    public void Button_Click_2(object sender, RoutedEventArgs e)
    {
        var form2 = new Window2();
        form2.Show();
        this.Close();

        Class1.vihodvmenu = false;                   
            form2.VernutsaVigruButton.Visibility = Visibility.Hidden;
            form2.VernutsaVigruLabel.Visibility = Visibility.Hidden;
    }

    private void Button_Click_3(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();

    }

    private void Button_Click_4(object sender, RoutedEventArgs e)
    {
        
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Grid_Loaded(object sender, RoutedEventArgs e)
    {
       
    }

    private void Grid_Unloaded(object sender, RoutedEventArgs e)
    {
       
    }
}