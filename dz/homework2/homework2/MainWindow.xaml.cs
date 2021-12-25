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
using System.Windows.Threading;


namespace homework2
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += new EventHandler(ChangeButtons);
            timer.Start();
        }

        private void ChangeButtons(object sender,EventArgs e)
        {
            foreach(Button btn in allbtns.Children)
            {
                Button temp = allbtns.Children[random.Next(allbtns.Children.Count)] as Button;
                string tempContent = btn.Content.ToString();
                btn.Content = temp.Content;
                temp.Content = tempContent;
                btn.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(random.Next(60, 230)), Convert.ToByte(random.Next(60, 230)),
                    Convert.ToByte(random.Next(60, 230)), Convert.ToByte(random.Next(60, 230))));
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            foreach(Button btn in allbtns.Children)
            {
                btn.Content = "";
            }
        }

        private void btn1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = sender as Button;
            btn.Content = "fsdfdsfds";
        }
    }
}
