using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

using System.Security;


namespace clustering
{
    public partial class Form_main : Form
    {
        private Reader reader = new Reader();
        private Writer writer = new Writer();
        private Data data;

        public Form_main()
        {
            InitializeComponent();
        }

       
        
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void button1_Click_1(object sender, EventArgs e)
        {
            Process p = Process.Start("111.exe");
            Thread.Sleep(500);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, this.Handle);

        }

        

        private void open_file_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    path_textbox.Text = openFileDialog.FileName;
            }
        }

        private void clear_file_btn_Click(object sender, EventArgs e)
        {
            path_textbox.Text = "";
            //unload
        }

        private void Load_file_btn_Click(object sender, EventArgs e)
        {
            data = reader.get_data(path_textbox.Text);
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            var num_clusters = Int32.Parse(num_cluster_txtbox.Text);
            if (kmeans_cb.Checked)
            {
                var kmeans = new Kmeans(data, num_clusters);
                var clusters = kmeans.Get_clusters();
                visualise(data.Points, clusters);
                //var path_out = Path.Combine(Path.GetDirectoryName(path_textbox.Text), "kmeans.txt");
                //writer.write_data(data, clusters, path_out);
            }
        }

        private void visualise(double [,] points, int[] clusters) {
            var form_vis = new Form_visual();
            form_vis.Show();

            Brush[] brushes = { Brushes.Black, Brushes.LimeGreen, Brushes.Blue, Brushes.Orange, Brushes.Red, Brushes.Violet, Brushes.Turquoise };
            Graphics g = form_vis.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            var max_h = form_vis.ClientSize.Height;
            var max_w = form_vis.ClientSize.Width;
            var h_margin = max_h * .05;
            var w_margin = max_w * .05;
            var h_span = max_h * .9;
            var w_span = max_w * .9;

            var num = points.GetLength(0);

            var h_min = Double.MaxValue;
            var h_max = 0.0;
            var w_min = Double.MaxValue;
            var w_max = 0.0;

            for (var i = 0; i < num; i++) {
                if (points[i, 0] < w_min)
                    w_min = points[i, 0];
                if (points[i, 1] < h_min)
                    h_min = points[i, 1];
                if (points[i, 0] > w_max)
                    w_max = points[i, 0];
                if (points[i, 1] > h_max)
                    h_max = points[i, 1];
            }
            var h_len = h_max - h_min;
            var w_len = w_max - w_min;

            for (var i = 0; i < num; i++)
            {
                var p_w = (points[i, 0] - w_min) * w_span / w_len + w_margin;
                var p_h = (points[i, 1] - h_min) * h_span / h_len + h_margin;
                Point pPosition = new Point((int)p_w, (int)p_h);
                g.FillEllipse(brushes[clusters[i]], new RectangleF(pPosition, new Size(6, 6)));
            }  
        }
    }
}