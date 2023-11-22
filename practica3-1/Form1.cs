namespace practica3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            textoTelegrama = txtTelegrama.Text;

            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            int numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;
            double coste;
            //Leo el telegrama

            // telegrama urgente?
            if (ordinario.Checked)
                tipoTelegrama = 'u';

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;

                else
                    coste = 0.5 * (numPalabras - 10) + 2.50;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void ordinario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}