namespace Guia._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrecioOriginal.Text, out double precioOriginal) &&
               double.TryParse(txtDescuento.Text, out double descuento))
            {
                double precioFinal = precioOriginal - (precioOriginal * (descuento / 100));
                lblResultado.Text = $"Precio final después de descuento: ${precioFinal:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
