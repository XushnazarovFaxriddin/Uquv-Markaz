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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Uquv_Markaz.Pages.Dashboard
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
            //SeriesCollection2 = new SeriesCollection
            //{
            //    new StackedRowSeries
            //    {
            //        Title = "Alek",
            //        Values = new ChartValues<double> {.5, -.7, .8, -.8, .6, -.2, .6}
            //    },
            //    new StackedRowSeries
            //    {
            //        Title = "Salom",
            //        Values = new ChartValues<double> {.2, .7, .1, .7, .1, .2, .9}
            //    },
            //    new StackedRowSeries
            //    {
            //        Title="Nimadir",
            //        Values=new ChartValues<double>{.1,.2,.3,.3,.4,.5,.6,.3,.2}
            //    },
            //    new StackedRowSeries
            //    {
            //        Title="Nimadir",
            //        Values=new ChartValues<double>{.1,.2,.3,.3,.4,.5,.6,.3,.2}
            //    }
            //};
            //Labels = new[] { "0-20", "20-35", "35-45", "45-55", "55-65", "65-70", ">70" };
            //Formatter = value => Math.Abs(value).ToString("P");
            //DataContext = this;



            /// chiziqli chart

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 10),
                        new ObservablePoint(4, 7),
                        new ObservablePoint(5, 3),
                        new ObservablePoint(7, 6),
                        new ObservablePoint(10, 8)
                    },
                    PointGeometrySize = 15,
                    //Name="1-2KIDT-20"
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 2),
                        new ObservablePoint(2, 5),
                        new ObservablePoint(3, 6),
                        new ObservablePoint(6, 8),
                        new ObservablePoint(10, 5)
                    },
                    PointGeometrySize = 15,
                    //Name="1-1ATT-21"
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 4),
                        new ObservablePoint(5, 5),
                        new ObservablePoint(7, 7),
                        new ObservablePoint(9, 10),
                        new ObservablePoint(10, 9)
                    },
                    PointGeometrySize = 15,
                    //Name="1-3PM-19"
                },
                //new LineSeries
                //{
                //    Values = new ChartValues<ObservablePoint>
                //    {
                //        new ObservablePoint(0, 0),
                //        new ObservablePoint(7, 3),
                //        new ObservablePoint(1, 7),
                //        new ObservablePoint(9, 5),
                //        new ObservablePoint(10, 9)
                //    },
                //    PointGeometrySize = 15,
                //    //Name="1-3PM-19"
                //}
            };
            DataContext = this;

        }

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection2 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
