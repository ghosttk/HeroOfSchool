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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Topmost = true;
        }
        void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
        }
        void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();//模式，弹出！
            //w1.Show();//无模式，弹出！
        }
    }
}
