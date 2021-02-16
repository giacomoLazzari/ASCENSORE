using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ASCENSORE
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly Uri uriAscensore = new Uri("ascensore.png", UriKind.Relative);
        public Queue<int> listaPrenotazioni;
        private static Semaphore _pool;
        Thread t0;
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        

        public MainWindow()
        {
            InitializeComponent();
            ImageSource immAscensore = new BitmapImage(uriAscensore);
            imgAscensore.Source = immAscensore;
            _pool = new Semaphore(0, 1);
            t1 = new Thread(new ThreadStart(MetodoBottone1));
            _pool.Release(1);
            
        }

        private void edificio1_Click(object sender, RoutedEventArgs e)
        {

            t1.Start();
            t1.Join();
            
        }

        public void MetodoBottone1()
        {
            _pool.WaitOne();
            {
                double g = 260.501;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    if (imgAscensore.Margin.Top - g > 0)
                    {
                        double f = imgAscensore.Margin.Top;
                        double i = imgAscensore.Margin.Bottom;
                        while (f > 260)
                        {
                            f--;
                            i++;
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                            }));
                            Thread.Sleep(40);
                        }
                    }
                    else if (imgAscensore.Margin.Top - g < 0)
                    {
                        double f = imgAscensore.Margin.Top;
                        double i = imgAscensore.Margin.Bottom;
                        while (f < 260)
                        {
                            f++;
                            i--;
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                            }));
                            Thread.Sleep(40);
                        }
                    }
                }));
            }
            _pool.Release();
        }

        private void edificio0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void edificio2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void edificio3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void edificio4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
