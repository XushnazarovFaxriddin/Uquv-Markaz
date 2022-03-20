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
using Uquv_Markaz.Pages;
using Uquv_Markaz.Pages.Groups;

namespace Uquv_Markaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           PagesNavigation.Navigate(new System.Uri("Pages/Dashboard/Index.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            //PagesNavigation.Navigate(new IndexG());

            PagesNavigation.Navigate(new System.Uri("Pages/Dashboard/Index.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdPayment_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NotFound Page!");
            this.Hide();
            new Auth().ShowDialog();
            this.Show();
            //PagesNavigation.Navigate(new System.Uri("Pages/PaymentPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Surish(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void rdGroups_click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Groups/IndexG.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdStudent_click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Student/Index.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdTest_click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Test/Index.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdTeacher_click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Teachers/Index.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdGetTest_click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/GetTest/Index.xaml", UriKind.RelativeOrAbsolute));
            new Auth().ShowDialog();
        }
    }
}
