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

namespace SlotMachine
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer1;
        Timer timer2;
        Timer timer3;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            timer1 = new Timer((i) =>
            {
                label1.Dispatcher.BeginInvoke(
                new Action(() =>
                {
                    var random = new Random();
                    int num = random.Next(0, 9);
                    label1.Content = num.ToString();
                }));
            }, null, 0, 100);

            timer2 = new Timer((i) =>
            {
                label2.Dispatcher.BeginInvoke(
                new Action(() =>
                {
                    var random = new Random();
                    int num = random.Next(0, 9);
                    label2.Content = num.ToString();
                }));
            }, null, 0, 10);

            timer3 = new Timer((i) =>
            {
                label3.Dispatcher.BeginInvoke(
                new Action(() =>
                {
                    var random = new Random();
                    int num = random.Next(0, 9);
                    label3.Content = num.ToString();
                }));
            }, null, 0, 50);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            timer1.Dispose();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            timer2.Dispose();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            timer3.Dispose();
        }
    }
}
