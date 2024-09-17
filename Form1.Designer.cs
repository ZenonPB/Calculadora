namespace calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calc));
            gifLoading = new PictureBox();
            label1 = new Label();
            pgbLoading = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)gifLoading).BeginInit();
            SuspendLayout();
            // 
            // gifLoading
            // 
            gifLoading.BackColor = Color.Transparent;
            gifLoading.Image = Properties.Resources.gatinho_unscreen;
            gifLoading.Location = new Point(-159, 224);
            gifLoading.Name = "gifLoading";
            gifLoading.Size = new Size(497, 225);
            gifLoading.SizeMode = PictureBoxSizeMode.Zoom;
            gifLoading.TabIndex = 0;
            gifLoading.TabStop = false;
            gifLoading.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, 110);
            label1.Name = "label1";
            label1.Size = new Size(344, 65);
            label1.TabIndex = 1;
            label1.Text = "Carregando...";
            // 
            // pgbLoading
            // 
            pgbLoading.Location = new Point(21, 208);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(753, 45);
            pgbLoading.Style = ProgressBarStyle.Marquee;
            pgbLoading.TabIndex = 2;
            // 
            // frm_calc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(800, 450);
            Controls.Add(pgbLoading);
            Controls.Add(label1);
            Controls.Add(gifLoading);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label1;
        private ProgressBar pgbLoading;
    }
}
