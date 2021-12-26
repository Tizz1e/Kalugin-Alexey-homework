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

        private void Check(object sender, RoutedEventArgs e)
        {
            if (txt_box.Text.Length == 5)
            {
                txt_box.IsEnabled = false;
                foreach(Button btn in allbtns.Children)
                {
                    btn.IsEnabled = false;
                }
            }
        }

        private void Move(object sender, RoutedEventArgs e)
        {
            double top = txt_box.Margin.Top + random.Next(-10, 10);
            double left = txt_box.Margin.Left + random.Next(-10, 10);
            double bottom = txt_box.Margin.Bottom;
            double right = txt_box.Margin.Right;
            Thickness marg = new Thickness(left, top, right, bottom);
            txt_box.Margin = marg;
        }

        private void MsEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            Button temp = allbtns.Children[random.Next(allbtns.Children.Count)] as Button;
            string tempContent = btn.Content.ToString();
            btn.Content = temp.Content;
            temp.Content = tempContent;
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Content.ToString() == "✘")
            {
                Clear(sender, e);
            }
            else if (btn.Content.ToString() == "✔")
            {
                Check(sender, e);
            }
            else
            {
                txt_box.Text += btn.Content.ToString();
                Move(sender, e);
            }
        }
    }
}
