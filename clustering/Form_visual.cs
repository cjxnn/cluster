using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace clustering
{
    public partial class Form_visual : Form
    {
        Color[] colors = { Color.Black, Color.LimeGreen, Color.Blue, Color.Orange, Color.Red, Color.Violet, Color.Turquoise};
        public Form_visual() {
            InitializeComponent();
        }

        public void plot_clusters(double[,] points, Result result) {
            var num_clusters = result.Means.GetLength(0);
            var series = new Series[num_clusters];
            for (var i = 0; i < num_clusters; i++) {
                series[i] = plot.Series.Add(i.ToString());
                series[i].ChartType = SeriesChartType.Point;
                series[i].Color = colors[i];

                // plot centroids
                var s = plot.Series.Add((i+num_clusters).ToString());
                s.Points.AddXY(result.Means[i, 0], result.Means[i, 1]);
                s.ChartType = SeriesChartType.Point;
                s.Color = colors[i];
                s.MarkerSize = 30;
                s.MarkerStyle = MarkerStyle.Cross;
                s.IsVisibleInLegend = false;
            }

            // plot clusters
            var num_points = points.GetLength(0);
            for (var i = 0; i < num_points; i++)
                series[result.Clusters[i]].Points.AddXY(points[i,0], points[i,1]);
        }
    }
}