﻿using System;
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
    public partial class Form1 : Form
    {
        private Reader reader = new Reader();
        private Writer writer = new Writer();
        private Data data;

        public Form1()
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
            if (kmeans_cb.Checked) {
                var kmeans = new Kmeans(data);
                var clusters = kmeans.Get_clusters();
                var path_out = Path.Combine(Path.GetDirectoryName(path_textbox.Text), "kmeans.txt");
                writer.write_data(data, clusters, path_out);
            }
        }
    }
}