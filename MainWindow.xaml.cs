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
//using IronPython.Hosting;
using MatplotlibCS;
using System.IO;

// 工具>NuGet封裝管理員>套檢管理主控台

namespace WPFApp20170912
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
           
        }

        int score;
        int courses = 0;
        int GPA;
        double sumGPA = 0;
        string msg = "CODE  SCORE   POINT   GRADE   GPA";



       

        private void WPFTest_Loaded(object sender, RoutedEventArgs e)
        {
            Title = "WPFTest";
            //Size = new Size(800, 600);
         
            MessageBox.Show("Welcome!");
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome!");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            //#region create test data

            /*const int N = 100;
            var X = new double[N];
            var Y1 = new double[N];
            var Y2 = new double[N];
            var x = 0.0;
            const double h = 2 * Math.PI / N;
            var rnd = new Random();

            for (var i = 0; i < N; i++)
            {
                var y = Math.Sin(x);
                X[i] = x;
                Y1[i] = y;

                y = Math.Sin(2 * x);
                Y2[i] = y + rnd.NextDouble() / 10.0;

                x += h;
            }

            #endregion

            #region create plot

            // init engine with right paths 
            var matplotlib = new MatplotlibCS.MatplotlibCS(pythonExePath, matplotlibPyPath);

            var figure = new Figure(1, 1)
            {
                FileName = "ExampleSin.png",
                OnlySaveImage = true,
                DPI = 150,
                Subplots =
            {
            new Axes(1, "The X axis", "The Y axis")
            {
                Title = "Example Sin",
                Grid = new Grid()
                {
                    MinorAlpha = 0.2,
                    MajorAlpha = 1.0,
                    XMajorTicks = new[] {0.0, 7.6, 0.5},
                    YMajorTicks = new[] {-1, 2.5, 0.25},
                    XMinorTicks = new[] {0.0, 7.25, 0.25},
                    YMinorTicks = new[] {-1, 2.5, 0.125}
                },
                PlotItems =
                {
                    new Line2D("Sin")
                    {
                        X = X.ToList(),
                        Y = Y1.ToList(),
                        LineStyle = LineStyle.Dashed
                    },

                    new Line2D("Sin 2x")
                    {
                        X = X.ToList(),
                        Y = Y2.ToList(),
                        LineStyle = LineStyle.Solid,
                        LineWidth = 0.5f,
                        Color = Color.Green,
                        Markevery = 5,
                        MarkerSize = 10,
                        Marker = Marker.Circle
                    },

                    new Text("Text annotation", 4.5, 0.76)
                    {
                        FontSize = 17
                    },

                    new Annotation("Arrow text annotation", 0.5, -0.7, 3, 0)
                    {
                        Color = Color.Blue
                    }
                }
            }
            }
            };

            var t = matplotlib.BuildFigure(figure);
            t.Wait();

            #endregion*/
            Application.Current.Shutdown(0);
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            int loop = int.Parse(InputTextBox.Text);
            int sums = 0;
            for (int i=1; i<=loop; i++)
            {
                sums = sums + i;
            }
            
            MessageBox.Show(sums.ToString());
            ShowBox.Text = Convert.ToString(sums);
        }

        private void RandomNumber_Click(object sender, RoutedEventArgs e)
        {
            Random RandNumVec = new Random();
        }
    }
}