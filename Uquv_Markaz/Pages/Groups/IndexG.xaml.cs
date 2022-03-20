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
using System.Windows.Shapes;
using Uquv_Markaz.Models;

namespace Uquv_Markaz.Pages.Groups
{
    /// <summary>
    /// Interaction logic for IndexG.xaml
    /// </summary>
    public partial class IndexG : Page
    {
        public List<Group> groups = new List<Group>();
        public IndexG()
        {
            InitializeComponent();
            groups.Add(new Group
            {
                Title = "Salom",
                Price = 234,
                Company = "Nokia"
            });
            for (int i = 0; i < 25; i++)
            {
                //Thread.Sleep(500);
                groups.Add(new Group
                {
                    Title = "Alek",
                    Price = 789,
                    Company = "Samsung"
                });
            }
            groupsGrid.ItemsSource = groups;
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            new Create().ShowDialog();
            //this.Content = NavigationService.Navigate( new System.Uri("Pages/Groups/Create.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
