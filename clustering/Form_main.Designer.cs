using System;

namespace clustering
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chamelon_cb = new System.Windows.Forms.CheckBox();
            this.kmeans_cb = new System.Windows.Forms.CheckBox();
            this.dbscan_cb = new System.Windows.Forms.CheckBox();
            this.gmm_cb = new System.Windows.Forms.CheckBox();
            this.run_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.clear_file_btn = new System.Windows.Forms.Button();
            this.path_textbox = new System.Windows.Forms.TextBox();
            this.open_file_btn = new System.Windows.Forms.Button();
            this.Load_file_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_cluster_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(162, 250);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(119, 17);
            this.radioButton4.TabIndex = 42;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Manhattan distance";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(162, 227);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(98, 17);
            this.radioButton5.TabIndex = 41;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Cosine similarity";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(162, 204);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(115, 17);
            this.radioButton6.TabIndex = 40;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Euclidean distance";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(159, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Select a similarity measure:";
            // 
            // chamelon_cb
            // 
            this.chamelon_cb.AutoSize = true;
            this.chamelon_cb.Location = new System.Drawing.Point(47, 251);
            this.chamelon_cb.Name = "chamelon_cb";
            this.chamelon_cb.Size = new System.Drawing.Size(73, 17);
            this.chamelon_cb.TabIndex = 38;
            this.chamelon_cb.Text = "Chamelon";
            this.chamelon_cb.UseVisualStyleBackColor = true;
            // 
            // kmeans_cb
            // 
            this.kmeans_cb.AutoSize = true;
            this.kmeans_cb.Location = new System.Drawing.Point(47, 205);
            this.kmeans_cb.Name = "kmeans_cb";
            this.kmeans_cb.Size = new System.Drawing.Size(67, 17);
            this.kmeans_cb.TabIndex = 34;
            this.kmeans_cb.Text = "K means";
            this.kmeans_cb.UseVisualStyleBackColor = true;
            // 
            // dbscan_cb
            // 
            this.dbscan_cb.AutoSize = true;
            this.dbscan_cb.Location = new System.Drawing.Point(47, 228);
            this.dbscan_cb.Name = "dbscan_cb";
            this.dbscan_cb.Size = new System.Drawing.Size(66, 17);
            this.dbscan_cb.TabIndex = 35;
            this.dbscan_cb.Text = "DBScan";
            this.dbscan_cb.UseVisualStyleBackColor = true;
            // 
            // gmm_cb
            // 
            this.gmm_cb.AutoSize = true;
            this.gmm_cb.Location = new System.Drawing.Point(47, 274);
            this.gmm_cb.Name = "gmm_cb";
            this.gmm_cb.Size = new System.Drawing.Size(52, 17);
            this.gmm_cb.TabIndex = 36;
            this.gmm_cb.Text = "GMM";
            this.gmm_cb.UseVisualStyleBackColor = true;
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(402, 304);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(75, 23);
            this.run_btn.TabIndex = 37;
            this.run_btn.Text = "Run";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(44, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Select an algorithm:\r\n";
            // 
            // clear_file_btn
            // 
            this.clear_file_btn.Location = new System.Drawing.Point(162, 109);
            this.clear_file_btn.Name = "clear_file_btn";
            this.clear_file_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_file_btn.TabIndex = 28;
            this.clear_file_btn.Text = "Clear file";
            this.clear_file_btn.UseVisualStyleBackColor = true;
            this.clear_file_btn.Click += new System.EventHandler(this.clear_file_btn_Click);
            // 
            // path_textbox
            // 
            this.path_textbox.Enabled = false;
            this.path_textbox.Location = new System.Drawing.Point(157, 70);
            this.path_textbox.Name = "path_textbox";
            this.path_textbox.Size = new System.Drawing.Size(393, 20);
            this.path_textbox.TabIndex = 32;
            // 
            // open_file_btn
            // 
            this.open_file_btn.Location = new System.Drawing.Point(47, 68);
            this.open_file_btn.Name = "open_file_btn";
            this.open_file_btn.Size = new System.Drawing.Size(75, 23);
            this.open_file_btn.TabIndex = 31;
            this.open_file_btn.Text = "Choose file";
            this.open_file_btn.UseVisualStyleBackColor = true;
            this.open_file_btn.Click += new System.EventHandler(this.open_file_btn_Click);
            // 
            // Load_file_btn
            // 
            this.Load_file_btn.Location = new System.Drawing.Point(47, 109);
            this.Load_file_btn.Name = "Load_file_btn";
            this.Load_file_btn.Size = new System.Drawing.Size(75, 23);
            this.Load_file_btn.TabIndex = 30;
            this.Load_file_btn.Text = "Load file";
            this.Load_file_btn.UseVisualStyleBackColor = true;
            this.Load_file_btn.Click += new System.EventHandler(this.Load_file_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(44, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Please upload a file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(310, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Number of clusters:";
            // 
            // num_cluster_txtbox
            // 
            this.num_cluster_txtbox.Location = new System.Drawing.Point(313, 203);
            this.num_cluster_txtbox.Name = "num_cluster_txtbox";
            this.num_cluster_txtbox.Size = new System.Drawing.Size(100, 20);
            this.num_cluster_txtbox.TabIndex = 44;
            this.num_cluster_txtbox.Text = "2";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 351);
            this.Controls.Add(this.num_cluster_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chamelon_cb);
            this.Controls.Add(this.kmeans_cb);
            this.Controls.Add(this.dbscan_cb);
            this.Controls.Add(this.gmm_cb);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clear_file_btn);
            this.Controls.Add(this.path_textbox);
            this.Controls.Add(this.open_file_btn);
            this.Controls.Add(this.Load_file_btn);
            this.Controls.Add(this.label2);
            this.Name = "Form_main";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chamelon_cb;
        private System.Windows.Forms.CheckBox kmeans_cb;
        private System.Windows.Forms.CheckBox dbscan_cb;
        private System.Windows.Forms.CheckBox gmm_cb;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear_file_btn;
        private System.Windows.Forms.TextBox path_textbox;
        private System.Windows.Forms.Button open_file_btn;
        private System.Windows.Forms.Button Load_file_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num_cluster_txtbox;
    }
}

