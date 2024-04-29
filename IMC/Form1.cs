namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double imc = peso / (altura * altura);

            lbIMC.Text = imc.ToString("F2");
            lbIMC.Visible = true;

            string classificacao = string.Empty;

            if (imc < 16.9)
                classificacao = "Muito abaixo do peso";
            else if (imc >= 17 && imc <= 18.49)
                classificacao = "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.99)
                classificacao = "Peso normal";
            else if (imc >= 25 && imc <= 29.99)
                classificacao = "Acima do peso";
            else if (imc >= 30 && imc <= 34.99)
                classificacao = "Obesidade Grau I";
            else if (imc >= 35 && imc <= 40)
                classificacao = "Obesidade Grau II";
            else if (imc >40)
                classificacao = "Obesidade Grau III";

            lbClassificacao.Text = classificacao;
            lbClassificacao.Visible = true;
        }
    }
}
