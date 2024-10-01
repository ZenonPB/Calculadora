﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class ConversorTempcs : Form
    {
        private float fahrenheit;
        private double kelvin;

        public ConversorTempcs()
        {
            InitializeComponent();
        }

        private void boxUserInput_TextChanged(object sender, EventArgs e)
        {

        }
    
        public void temperatura()
        {
            int temperature = Convert.ToInt32(boxUserInput.Text);
            fahrenheit = (temperature * 9 / 5) + 32;
            kelvin = temperature + 273.15;
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtResult.Text = $"{fahrenheit}°F ou {kelvin}°K";
        }
    }
}
