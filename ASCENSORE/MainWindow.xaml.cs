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
        private static Semaphore _pool;
        Thread t0;
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        double f;
        double i;
        public object x = new object();
        bool selezioneTastierino;
        


        public MainWindow()
        {
            InitializeComponent();
            ImageSource immAscensore = new BitmapImage(uriAscensore);
            imgAscensore.Source = immAscensore;


            selezioneTastierino = true;
             
        }

        private void edificio0_Click(object sender, RoutedEventArgs e)
        {

            while (selezioneTastierino == false)
            {
                Task.Delay(TimeSpan.FromMilliseconds(300));
            }
            
            if (selezioneTastierino == true)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    f = imgAscensore.Margin.Top;
                    i = imgAscensore.Margin.Bottom;
                }));
                t0 = new Thread(new ThreadStart(MetodoBottone0));

                t0.Start();
            }
          

        }

        private void edificio1_Click(object sender, RoutedEventArgs e)
        {

            while (selezioneTastierino == false)
            {
                Task.Delay(TimeSpan.FromMilliseconds(300));
            }
            
            if (selezioneTastierino == true)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    f = imgAscensore.Margin.Top;
                    i = imgAscensore.Margin.Bottom;
                }));
                t1 = new Thread(new ThreadStart(MetodoBottone1));

                t1.Start();
            }
                
            
        }
        
        private void edificio2_Click(object sender, RoutedEventArgs e)
        {

            while (selezioneTastierino == false)
            {
                Task.Delay(TimeSpan.FromMilliseconds(300));
            }
            
            if (selezioneTastierino == true)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    f = imgAscensore.Margin.Top;
                    i = imgAscensore.Margin.Bottom;
                }));
                t2 = new Thread(new ThreadStart(MetodoBottone2));

                t2.Start();
            }
            
            
        }

        private void edificio3_Click(object sender, RoutedEventArgs e)
        {
            while (selezioneTastierino == false)
            {
                Task.Delay(TimeSpan.FromMilliseconds(300));
            }
            
            if (selezioneTastierino == true)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    f = imgAscensore.Margin.Top;
                    i = imgAscensore.Margin.Bottom;
                }));
                t3 = new Thread(new ThreadStart(MetodoBottone3));

                t3.Start();
            }
            
            
        }

        private void edificio4_Click(object sender, RoutedEventArgs e)
        {
            while (selezioneTastierino == false)
            {
                Task.Delay(TimeSpan.FromMilliseconds(300));
            }
            
            if (selezioneTastierino == true)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    f = imgAscensore.Margin.Top;
                    i = imgAscensore.Margin.Bottom;
                }));
                t4 = new Thread(new ThreadStart(MetodoBottone4));

                t4.Start();
            }

        }
        public void MetodoBottone0()
        {

            selezioneTastierino = false;
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPianoPrenotato.Content = "0";
                }));
                double g = 320;
                int time = 20;



                if (f - g < 0)
                {
                    while (f < g)
                    {
                        f++;
                        i--;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }



            }
            selezioneTastierino = false;
            Thread.Sleep(TimeSpan.FromSeconds(4));
            selezioneTastierino = true;

        }

        public void MetodoBottone1()
        {
            selezioneTastierino = false;
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPianoPrenotato.Content = "1";
                }));

                double g = 260.501;
                int time = 20;

                if (f - g > 0)
                {

                    while (f > g)
                    {
                        f--;
                        i++;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }
                else if (f - g < 0)
                {

                    while (f < g)
                    {
                        f++;
                        i--;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }

            }
            selezioneTastierino = false;
            Thread.Sleep(TimeSpan.FromSeconds(4));
            selezioneTastierino = true;
        }

        public void MetodoBottone2()
        {
            selezioneTastierino = false;
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPianoPrenotato.Content = "2";
                }));
                double g = 199;
                int time = 20;


                if (f - g > 0)
                {

                    while (f > g)
                    {
                        f--;
                        i++;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }
                else if (f - g < 0)
                {
                    while (f < g)
                    {
                        f++;
                        i--;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }
                


            }
            selezioneTastierino = false;
            Thread.Sleep(TimeSpan.FromSeconds(4));
            selezioneTastierino = true;
        }
        public void MetodoBottone3()
        {
            selezioneTastierino = false;
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPianoPrenotato.Content = "3";
                }));
                double g = 145;
                int time = 20;


                if (f - g > 0)
                {

                    while (f > g)
                    {
                        f--;
                        i++;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }
                else if (f - g < 0)
                {

                    while (f < g)
                    {
                        f++;
                        i--;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }
               

            }
            selezioneTastierino = false;
            Thread.Sleep(TimeSpan.FromSeconds(4));
            selezioneTastierino = true;
        }

        public void MetodoBottone4()
        {
            selezioneTastierino = false;
            lock (x)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    lblPianoPrenotato.Content = "4";
                }));
                double g = 83;
                int time = 20;


                if (f - g > 0)
                {

                    while (f > g)
                    {
                        f--;
                        i++;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }
                else if (f - g < 0)
                {

                    while (f < g)
                    {
                        f++;
                        i--;
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            imgAscensore.Margin = new Thickness(178, f, 501.333, i);
                        }));
                        Thread.Sleep(TimeSpan.FromMilliseconds(time));
                    }
                }
               
            }
            selezioneTastierino = false;
            Thread.Sleep(TimeSpan.FromSeconds(4));
            selezioneTastierino = true;

        }

        private void ascensore0_Click(object sender, RoutedEventArgs e)
        {
            
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                f = imgAscensore.Margin.Top;
                i = imgAscensore.Margin.Bottom;
            }));
            selezioneTastierino = true;
            t0 = new Thread(new ThreadStart(MetodoBottone0));
           
            t0.Start();
        }

        private void ascensore1_Click(object sender, RoutedEventArgs e)
        {
            
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                f = imgAscensore.Margin.Top;
                i = imgAscensore.Margin.Bottom;
            }));
            selezioneTastierino = true;
            t1 = new Thread(new ThreadStart(MetodoBottone1));
           
            t1.Start();
        }

        private void ascensore2_Click(object sender, RoutedEventArgs e)
        {
            
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                f = imgAscensore.Margin.Top;
                i = imgAscensore.Margin.Bottom;
            }));
            selezioneTastierino = true;
            t2 = new Thread(new ThreadStart(MetodoBottone2));
            
            t2.Start();

        }

        private void ascensore3_Click(object sender, RoutedEventArgs e)
        {
            
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                f = imgAscensore.Margin.Top;
                i = imgAscensore.Margin.Bottom;
            }));
            selezioneTastierino = true;
            t3 = new Thread(new ThreadStart(MetodoBottone3));
            
            t3.Start();



        }

        private void ascensore4_Click(object sender, RoutedEventArgs e)
        {
            
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                f = imgAscensore.Margin.Top;
                i = imgAscensore.Margin.Bottom;
            }));
            selezioneTastierino = true;
            t4 = new Thread(new ThreadStart(MetodoBottone4));
            
            t4.Start();

        }
    }
}
