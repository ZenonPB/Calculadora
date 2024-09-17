namespace calculadora
{
    public partial class frm_calc : Form
    {
        public frm_calc()
        {
            // Definindo o tempo de loading, de 3 a 12 segundos
            InitializeComponent();
            Random rng = new Random();
            int loadingTime = rng.Next(3, 12) * 1000;
            pgbLoading.Maximum = loadingTime;
            pgbLoading.Value = 0;
            tmrLoading.Start();
            tmrTxtLoad.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_calc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            // Fazendo a barra de loading andar conforme cada segundo passa
            if (pgbLoading.Value < pgbLoading.Maximum)
            {

                pgbLoading.Value += 1000;

            }
            else
            {
                pgbLoading.Value = pgbLoading.Maximum;
                tmrLoading.Stop();
            }
        }

        private void tmrTxtLoad_Tick(object sender, EventArgs e)
        {
            txtLoading.Visible = true;

            List<string> loadingTexts = new List<string>();
            loadingTexts = ["Carregando fórmulas matemáticas...",
            "Preparando funções algébricas...",
            "Ajustando precisão dos cálculos...",
            "Carregando tabelas de conversão...",
            "Sincronizando dados numéricos...",
            "Inicializando operadores matemáticos...",
            "Configurando ambiente de cálculo...",
            "Preparando algoritmos de operação...",
            "Carregando constantes matemáticas...",
            "Ajustando parâmetros de precisão..."];

            // Fazendo com que a cada tick o texto mude para algum aleatório da array
            Random randomTxt = new Random();
            int indexLoading = randomTxt.Next(0, loadingTexts.Count);
            txtLoading.Text = loadingTexts[indexLoading];

        }
    }
}
