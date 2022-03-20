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
using System.Windows.Shapes;

namespace Uquv_Markaz.Pages.Groups
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        public Create()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Close");
            this.Close();
        }

        private void btnClose_Hover(object sender, MouseEventArgs e)
        {
            btnClose.Background = Brushes.Red;
            CloseIcon.Foreground = Brushes.White;
        }

        private void btnClose_EndHover(object sender, MouseEventArgs e)
        {
            btnClose.Background = Brushes.White;
            CloseIcon.Foreground = Brushes.Black;
        }
    }
}
