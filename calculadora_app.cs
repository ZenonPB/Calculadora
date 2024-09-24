using System;
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
    public partial class calculadora_app : Form
    {
        public calculadora_app()
        {
            InitializeComponent();
        }

        string btnPressed = "";

        // Está como button6 porque não consegui renomear, porém é a uniao de todos os botões de algarismos
        private void button6_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (btn != null)
            {
                btnPressed += btn.Text;
                txtInScreen.Text = btnPressed;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnPressed = "";
            txtInScreen.Text = null;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            btnPressed = btnPressed.Substring(0, btnPressed.Length - 1);
            txtInScreen.Text = btnPressed;
        }
    }
}
