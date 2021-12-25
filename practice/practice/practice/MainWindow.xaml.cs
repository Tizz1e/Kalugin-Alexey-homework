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

namespace practice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Tick += new EventHandler(timerTick);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = 110;
            btn.Height = 50;
            btn.MouseEnter += Button_MouseEnter;
            btn.Background = new SolidColorBrush(Color.FromArgb(255, Convert.ToByte(rand.Next(255)),
                    Convert.ToByte(rand.Next(255)), Convert.ToByte(rand.Next(255))));
            grid.Children.Add(btn);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            double left = btn.Margin.Left + rand.Next(-100, 100);
            double top = btn.Margin.Top + rand.Next(-100, 100);
            double right = btn.Margin.Right;
            double bottom = btn.Margin.Bottom;
            Thickness marg = new Thickness(left, top, right, bottom);
            btn.Margin = marg;
        }
    }
}
