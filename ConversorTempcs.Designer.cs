namespace calculadora
{
    partial class ConversorTempcs
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
            txtHeader = new Label();
            boxUserInput = new TextBox();
            txtCelsius = new Label();
            btnConvert = new Button();
            txtResult = new Label();
            SuspendLayout();
            // 
            // txtHeader
            // 
            txtHeader.AutoSize = true;
            txtHeader.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHeader.ForeColor = Color.White;
            txtHeader.Location = new Point(18, 9);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(383, 45);
            txtHeader.TabIndex = 0;
            txtHeader.Text = "Conversor Temperatura";
            // 
            // boxUserInput
            // 
            boxUserInput.Location = new Point(18, 209);
            boxUserInput.Name = "boxUserInput";
            boxUserInput.Size = new Size(383, 23);
            boxUserInput.TabIndex = 1;
            boxUserInput.TextChanged += boxUserInput_TextChanged;
            // 
            // txtCelsius
            // 
            txtCelsius.AutoSize = true;
            txtCelsius.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCelsius.ForeColor = Color.White;
            txtCelsius.Location = new Point(18, 130);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(394, 45);
            txtCelsius.TabIndex = 2;
            txtCelsius.Text = "Temperatura em Celsius";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.SteelBlue;
            btnConvert.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = Color.WhiteSmoke;
            btnConvert.Location = new Point(104, 272);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(197, 60);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Converter";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(61, 369);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(281, 45);
            txtResult.TabIndex = 4;
            txtResult.Text = "000°F ou 000°K";
            txtResult.Visible = false;
            // 
            // ConversorTempcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(413, 477);
            Controls.Add(txtResult);
            Controls.Add(btnConvert);
            Controls.Add(txtCelsius);
            Controls.Add(boxUserInput);
            Controls.Add(txtHeader);
            Name = "ConversorTempcs";
            Text = "ConversorTempcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtHeader;
        private TextBox boxUserInput;
        private Label txtCelsius;
        private Button btnConvert;
        private Label txtResult;
    }
}