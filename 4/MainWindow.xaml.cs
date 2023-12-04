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
using static System.Math;

namespace _4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void BtnOK_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TbNumberX.Text);
            double y = Convert.ToDouble(TbNumberA1.Text);
            double p,a,b;
            a = x + y;
            b=Pow(x,2)+Pow(y,2);
            p =Pow(a+b,2)+a*Cos(a+b)+(a*Sqrt(b))/(a+b) ;       
            TextBlockAnswer.Text = ($" s={a}");

        }
    }
}
