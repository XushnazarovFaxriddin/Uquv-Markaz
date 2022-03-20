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

namespace Uquv_Markaz.Pages
{
    /// <summary>
    /// Interaction logic for Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {

        private bool isKirish = false;
        public Auth()
        {
            if (!isKirish)
                InitializeComponent();
            else
            {
                // boshqa page ga o'tish
            }
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


        private void btnKirish_Click(object sender, RoutedEventArgs e)
        {
            /*if (txtUsername.Text == "test")
            {
                this.isKirish = true;
                MessageBox.Show("Bizning tizimdan foydalanganingiz uchun tashakkur!");
            }
            else
            {
                this.isKirish = false;
                MessageBox.Show("Kalit xato! Kalit olish uchun adminstrator bilan bog'laning. +998936831555");
            }*/

            /*IndexG index = new IndexG();
            this.Hide();*/
            /*index.ShowDialog();*/
            this.Show();
        }


        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
