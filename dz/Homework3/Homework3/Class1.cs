using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Homework3
{
    class NumberBox : UIElement
    {
        private Button plusBtn = new Button();
        private Button minusBtn = new Button();
        private TextBox txt = new TextBox();
        private int value = 0;
        private double height;
        private double width;
        private Thickness margin;
        private Brush foreground;
        private Brush background;
        public static RoutedEvent ValueChange;

        public NumberBox()
        {
            plusBtn.Content = "+";
            minusBtn.Content = "-";
            txt.HorizontalContentAlignment = HorizontalAlignment.Center;
            txt.Text = "0";
            plusBtn.Click += Clck;
            minusBtn.Click += Clck;
            txt.TextChanged += TxtInput;
            ValueChange = EventManager.RegisterRoutedEvent("ValueChange", RoutingStrategy.Direct,
                typeof(RoutedEventHandler), typeof(NumberBox));
        }

        protected override void OnVisualParentChanged(DependencyObject oldParent)
        {
            Grid grid = VisualParent as Grid;
            grid.Children.Add(plusBtn);
            grid.Children.Add(minusBtn);
            grid.Children.Add(txt);
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                plusBtn.Width = width / 2;
                minusBtn.Width = width / 2;
                txt.Width = width / 2;

            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                plusBtn.Height = height / 2;
                minusBtn.Height = height / 2;
                txt.Height = height;

                plusBtn.FontSize = height / 3;
                minusBtn.FontSize = height / 3;
                txt.FontSize = height * 3 / 5;
            }
        }

        public Thickness Margin
        {
            get
            {
                return margin;
            }
            set
            {
                margin = value;
                Thickness tmp = margin;
                txt.Margin = margin;
                tmp.Left += width;
                tmp.Top -= height / 2;
                plusBtn.Margin = tmp;

                tmp.Top += height;
                minusBtn.Margin = tmp;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value > 99) this.value = 99;
                else if (value < 99) this.value = -99;
                else this.value = value;
            }
        }

        public Brush Foreground
        {
            get
            {
                return foreground;
            }
            set
            {
                foreground = value;
                plusBtn.Foreground = foreground;
                minusBtn.Foreground = foreground;
                txt.Foreground = foreground;
            }
        }

        public Brush Background
        {
            get
            {
                return background;
            }
            set
            {
                background = value;
                plusBtn.Background = background;
                minusBtn.Background = background;
                txt.Background = background;
            }
        }

        private void Clck(object sender, RoutedEventArgs e)
        {
            if (sender as Button == plusBtn) value++;
            else value--;
            TxtUpdate();
            ButtonsUpdate();
        }

        private void TxtUpdate()
        {
            txt.Text = value.ToString();
        }

        private void ButtonsUpdate()
        {
            if (value == 99) plusBtn.IsEnabled = false;
            else if (value == -99) minusBtn.IsEnabled = false;
            else
            {
                plusBtn.IsEnabled = true;
                minusBtn.IsEnabled = true;
            }
        }

        private void TxtInput(object sender, TextChangedEventArgs e)
        {
            int temp;
            bool res = int.TryParse(txt.Text, out temp);
            if (res && Math.Abs(temp) < 100) value = temp;
        }

        public event RoutedEventHandler ChangeValue
        {
            add
            {
                AddHandler(ValueChange, value);
            }
            remove
            {
                RemoveHandler(ValueChange, value);
            }
        }

        private void OnValueChanged()
        {
            RaiseEvent(new RoutedEventArgs(ValueChange, this));
        }
    }

}
