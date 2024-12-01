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

                // Verificar que el número sea no negativo
                if (numero < 0)
                {
                    lblResultado.Text = "Ingrese un número no negativo.";
                    return;
                }

                // Calcular el factorial usando recursividad
                int resultado = Factorial(numero);

                // Mostrar el resultado en el Label
                lblResultado.Text = $"El factorial de {numero} es {resultado}.";
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, ingrese un número válido.";
            }
        }
        private int Factorial(int n)
        {
            // Condición base
            if (n == 0)
                return 1;

            // Segmento recursivo
            return n * Factorial(n - 1);
        }
    }
}
