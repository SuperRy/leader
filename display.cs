using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Media;
using System.Windows.Media;
using Brushes = System.Windows.Media.Brushes;
using LiveCharts.Defaults;

namespace Leadersoftware
{
    public partial class display : UserControl
    {
        public display()
        {
            InitializeComponent();
            /*
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7}
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {5, 2, 8, 3},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            //modifying the series collection will animate and update the chart
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
                LineSmoothness = 0, //straight lines, 1 really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });

            //modifying any series values will also animate and update the chart
            cartesianChart1.Series[2].Values.Add(5d);

    */




            cartesianChart2.Series = new SeriesCollection
            {
                new StackedAreaSeries
                {
                    Title = "Africa",
                    Values = new ChartValues<DateTimePoint>
                    {
                        
                        new DateTimePoint(new System.DateTime(66, 1, 1), 285),
                        new DateTimePoint(new System.DateTime(67, 1, 1), 366)
                     

                    },
                    LineSmoothness = 0
                },
                /*
                new StackedAreaSeries
                {
                    Title = "N & S America",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new System.DateTime(1950, 1, 1), .339),
                        new DateTimePoint(new System.DateTime(1960, 1, 1), .424),
                        new DateTimePoint(new System.DateTime(1970, 1, 1), .519),
                        new DateTimePoint(new System.DateTime(1980, 1, 1), .618),
                        new DateTimePoint(new System.DateTime(1990, 1, 1), .727),
                        new DateTimePoint(new System.DateTime(2000, 1, 1), .841),
                        new DateTimePoint(new System.DateTime(2010, 1, 1), .942),
                        new DateTimePoint(new System.DateTime(2013, 1, 1), .972)
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "Asia",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new System.DateTime(1950, 1, 1), 1.395),
                        new DateTimePoint(new System.DateTime(1960, 1, 1), 1.694),
                        new DateTimePoint(new System.DateTime(1970, 1, 1), 2.128),
                        new DateTimePoint(new System.DateTime(1980, 1, 1), 2.634),
                        new DateTimePoint(new System.DateTime(1990, 1, 1), 3.213),
                        new DateTimePoint(new System.DateTime(2000, 1, 1), 3.717),
                        new DateTimePoint(new System.DateTime(2010, 1, 1), 4.165),
                        new DateTimePoint(new System.DateTime(2013, 1, 1), 4.298)
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "Europe",
                    Values = new ChartValues<DateTimePoint>
                    {
                        new DateTimePoint(new System.DateTime(1950, 1, 1), 14.549),
                        new DateTimePoint(new System.DateTime(1960, 1, 1), .605),
                        new DateTimePoint(new System.DateTime(1970, 1, 1), .657),
                        new DateTimePoint(new System.DateTime(1980, 1, 1), .694),
                        new DateTimePoint(new System.DateTime(1990, 1, 1), .723),
                        new DateTimePoint(new System.DateTime(2000, 1, 1), .729),
                        new DateTimePoint(new System.DateTime(2010, 1, 1), .740),
                        new DateTimePoint(new System.DateTime(2013, 1, 1), .742)
                    },
                    LineSmoothness = 0
                }
                */
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                LabelFormatter = val => new System.DateTime((long)val).ToString("yyyy")
            });
            cartesianChart2.AxisY.Add(new Axis
            {
                LabelFormatter = val => val.ToString("N") + " M"
            });

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
           


        }

        private void running_Click(object sender, EventArgs e)
        {
           
        }

        private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
