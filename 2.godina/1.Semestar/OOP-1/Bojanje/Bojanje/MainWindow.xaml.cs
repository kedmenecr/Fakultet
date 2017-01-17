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

namespace Bojanje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //početna i završna točka grafičmkog oblika
        private Point PocetnaTocka;
        private Point zavrsnaTocka;

        //rectangle
        private Rectangle sjena;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PocetnaTocka =
                e.GetPosition(PlocaCanvas);
                if(sjena == null)
            {
                sjena = new Rectangle();
                PlocaCanvas.Children.Add(sjena);
            }
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            sjena = null;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            KordinateTextBox.Text =
                e.GetPosition(PlocaCanvas).X.ToString() + " / " +
                e.GetPosition(PlocaCanvas).Y.ToString();

            if (sjena != null)
            {
                //sirina i visina
                sjena.Width = Math.Abs(PocetnaTocka.X - zavrsnaTocka.X);
                sjena.Height = Math.Abs(PocetnaTocka.Y - zavrsnaTocka.Y);

                //brushes i sthicckens
                sjena.Fill = BojaTextBox.Background;
                sjena.Stroke = Brushes.Black;
                sjena.StrokeThickness = double.Parse(LinijaTextBox.Text);

                //pozicija
                Canvas.SetTop(sjena, Math.Min(PocetnaTocka.X, zavrsnaTocka.Y));
                Canvas.SetLeft(sjena, Math.Min(PocetnaTocka.X, zavrsnaTocka.Y));


                


            }
        }

        private void BojaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(BojaTextBox.Text));
            BojaTextBox.Background = brush ;
        }

        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
        
            
            if (PlocaCanvas.Children.Count != 0)
            {
                PlocaCanvas.Children.RemoveAt(PlocaCanvas.Children.Count - 1);
            }

       
    }
    }
}
