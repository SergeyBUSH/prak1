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

namespace _3
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
            double t = Convert.ToDouble(TbNumberT.Text);
            double V1 = Convert.ToDouble(TbNumberV1.Text);
            double v2= Convert.ToDouble(TbNumberV2.Text);
            double s= Convert.ToDouble(TbNumberS.Text);
            double s2;
            s2 =s+t*(V1+v2);
            TextBlockAnswer.Text = ($" s={s}");

        }
    }
}
