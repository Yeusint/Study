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

namespace Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Check1.IsChecked == true)
            {
                MessageBox.Show("你选了" + Check1.Content);
            }else if(Check2.IsChecked == true)
            {
                MessageBox.Show("你选了" + Check2.Content);
            }
            else { MessageBox.Show("你干嘛不选?"); }
            if (String.IsNullOrWhiteSpace(Input.Text))
            {
                MessageBox.Show("输入框未输入");
            }
            else { MessageBox.Show("输入框的内容为" + Input.Text); }
        }
    }
}
