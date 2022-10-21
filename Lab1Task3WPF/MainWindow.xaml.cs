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

namespace Lab1Task3WPF
{
    

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(Time);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            

        }

        private void Time(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            Label1.Content = d.Hour + " : " + d.Minute + " : " + d.Second;
        }
    
    }
}
