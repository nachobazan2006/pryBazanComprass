namespace pryBazanComprass
{
    public partial class frmIngresoCompras : Form
    {
        public frmIngresoCompras()
        {
            InitializeComponent();
        }
        //VARIABLES GLOBALES

        string vProducto="";
        DateTime vFecha;
        int vCantidad;
        int vPrecio;
        int vContador;

        //vFecha= dtpFecha.value;
        //vProducto = cboProducto.text;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            vContador++;
            vProducto = cboProducto.Text;
            vFecha = dtpFecha.Value;
            int vCantidad = Convert.ToInt32(CantidadNum.Text);
            vCantidad = vCantidad;
            // Extraer solo los dígitos del texto de mkbPrecioUnitaerio
            string precioSoloDigitos = new string(mkbPrecioUnitaerio.Text.Where(char.IsDigit).ToArray());
            int vPrecioUnitario = string.IsNullOrEmpty(precioSoloDigitos) ? 0 : Convert.ToInt32(precioSoloDigitos);

            vPrecio = vPrecioUnitario;
            lstResultado.Text = "Producto: " + vProducto + " Fecha: " + vFecha + " Cantidad: " + vCantidad + " Precio Unitario: " + vPrecioUnitario;

            cboProducto.Text = "";
            dtpFecha.Value = DateTime.Now;
            CantidadNum.Value = 0;
            mkbPrecioUnitaerio.Text = "";
            cboProducto.Focus();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)



        {

        }
    }
}
