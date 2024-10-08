﻿namespace calculadora
{
    partial class frm_calc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calc));
            gifLoading = new PictureBox();
            txtLoading = new Label();
            pgbLoading = new ProgressBar();
            tmrLoading = new System.Windows.Forms.Timer(components);
            tmrTxtLoad = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)gifLoading).BeginInit();
            SuspendLayout();
            // 
            // gifLoading
            // 
            gifLoading.BackColor = Color.Transparent;
            gifLoading.Image = Properties.Resources.gatinho_unscreen;
            gifLoading.Location = new Point(-139, 168);
            gifLoading.Margin = new Padding(3, 2, 3, 2);
            gifLoading.Name = "gifLoading";
            gifLoading.Size = new Size(435, 169);
            gifLoading.SizeMode = PictureBoxSizeMode.Zoom;
            gifLoading.TabIndex = 0;
            gifLoading.TabStop = false;
            gifLoading.Click += pictureBox1_Click;
            // 
            // txtLoading
            // 
            txtLoading.AutoSize = true;
            txtLoading.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLoading.ForeColor = Color.White;
            txtLoading.Location = new Point(111, 109);
            txtLoading.Name = "txtLoading";
            txtLoading.Size = new Size(176, 35);
            txtLoading.TabIndex = 1;
            txtLoading.Text = "Carregando...";
            txtLoading.TextAlign = ContentAlignment.MiddleCenter;
            txtLoading.Visible = false;
            txtLoading.Click += label1_Click;
            // 
            // pgbLoading
            // 
            pgbLoading.Location = new Point(18, 156);
            pgbLoading.Margin = new Padding(3, 2, 3, 2);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(659, 34);
            pgbLoading.TabIndex = 2;
            pgbLoading.Click += pgbLoading_Click;
            // 
            // tmrLoading
            // 
            tmrLoading.Interval = 1000;
            tmrLoading.Tick += tmrSplash_Tick;
            // 
            // tmrTxtLoad
            // 
            tmrTxtLoad.Interval = 1000;
            tmrTxtLoad.Tick += tmrTxtLoad_Tick;
            // 
            // frm_calc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(700, 337);
            Controls.Add(pgbLoading);
            Controls.Add(txtLoading);
            Controls.Add(gifLoading);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frm_calc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Mortal";
            Load += frm_calc_Load;
            ((System.ComponentModel.ISupportInitialize)gifLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gifLoading;
        private Label txtLoading;
        private ProgressBar pgbLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.Timer tmrTxtLoad;
    }
}
