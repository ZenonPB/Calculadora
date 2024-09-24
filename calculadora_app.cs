using System;
using System.Data;
using System.Windows.Forms;

namespace calculadora
{
    public partial class calculadora_app : Form
    {
        public calculadora_app()
        {
            InitializeComponent();
            txtAccount.Text = "";
        }

        // Variáveis para armazenar a entrada atual e a equação
        private string btnPressed = "";
        private string equacao = "";

        // Adiciona o número pressionado ao display
        private void button6_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btnPressed += btn.Text;
                txtInScreen.Text = btnPressed;
            }
        }

        // Atualiza a equação e o display da conta
        private void equacaoUpdate(string txt)
        {
            equacao += txt;
            txtAccount.Text = equacao;
        }

        // Reseta tanto a entrada do clique, quanto o texto que aparece em maior destaque
        private void resetAll()
        {
            btnPressed = "";
            txtInScreen.Text = "";
        }

        // Limpa todos os valores
        private void btnClear_Click(object sender, EventArgs e)
        {
            resetAll();
            equacao = "";
            txtAccount.Text = "";
        }

        // Apaga o último algarismo da digitação
        private void btnErase_Click(object sender, EventArgs e)
        {
            if (btnPressed.Length > 0)
            {
                btnPressed = btnPressed.Substring(0, btnPressed.Length - 1);
                txtInScreen.Text = btnPressed;
            }
        }

        // Adiciona operador e atualiza a equação
        private void AddOperator(string operador)
        {
            if (!string.IsNullOrEmpty(btnPressed) || !string.IsNullOrEmpty(equacao))
            {
                equacaoUpdate(btnPressed);
                equacaoUpdate(operador);
                resetAll();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e) => AddOperator("+");
        private void btnMinus_Click(object sender, EventArgs e) => AddOperator("-");
        private void btnMultiply_Click(object sender, EventArgs e) => AddOperator("*");
        private void btnDivide_Click(object sender, EventArgs e) => AddOperator("/");

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnPressed))
            {
                equacaoUpdate(btnPressed);
                equacaoUpdate("/100");
                resetAll();
            }
        }

        // Calcula o resultado da equação
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnPressed))
            {
                equacaoUpdate(btnPressed);
            }

            try
            {
                var result = new DataTable().Compute(equacao, null);
                txtInScreen.Text = result.ToString();
                // Atualiza a equação para o resultado
                equacao = result.ToString();
                btnPressed = ""; // Limpa a entrada atual
                txtAccount.Text = equacao; // Mostra a equação completa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conta: " + ex.Message);
            }
        }
    }
}
