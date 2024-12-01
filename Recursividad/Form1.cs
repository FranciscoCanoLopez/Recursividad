namespace Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el valor ingresado en el TextBox
                int numero = int.Parse(txtNumero.Text);

                // Verificar que el n�mero sea no negativo
                if (numero < 0)
                {
                    lblResultado.Text = "Ingrese un n�mero no negativo.";
                    return;
                }

                // Calcular el factorial usando recursividad
                int resultado = Factorial(numero);

                // Mostrar el resultado en el Label
                lblResultado.Text = $"El factorial de {numero} es {resultado}.";
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, ingrese un n�mero v�lido.";
            }
        }
        private int Factorial(int n)
        {
            // Condici�n base
            if (n == 0)
                return 1;

            // Segmento recursivo
            return n * Factorial(n - 1);
        }
    }
}
