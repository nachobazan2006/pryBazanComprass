namespace pryBazanComprass
{
    partial class frmIngresoCompras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            btnIngresar = new Button();
            lblTitulo = new Label();
            CantidadNum = new NumericUpDown();
            cboProducto = new ComboBox();
            mkbPrecioUnitaerio = new MaskedTextBox();
            lstResultado = new Label();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)CantidadNum).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(161, 74);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(46, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(161, 112);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(65, 23);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(161, 149);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(66, 23);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(161, 185);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(103, 23);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(335, 225);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(131, 34);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(38, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(530, 39);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Bienvenido al programa de ingreso de compras.";
            // 
            // CantidadNum
            // 
            CantidadNum.Location = new Point(266, 147);
            CantidadNum.Name = "CantidadNum";
            CantidadNum.Size = new Size(100, 23);
            CantidadNum.TabIndex = 6;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(266, 109);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(200, 23);
            cboProducto.TabIndex = 8;
            // 
            // mkbPrecioUnitaerio
            // 
            mkbPrecioUnitaerio.Location = new Point(266, 182);
            mkbPrecioUnitaerio.Mask = "$99999";
            mkbPrecioUnitaerio.Name = "mkbPrecioUnitaerio";
            mkbPrecioUnitaerio.Size = new Size(100, 23);
            mkbPrecioUnitaerio.TabIndex = 9;
            mkbPrecioUnitaerio.ValidatingType = typeof(int);
            // 
            // lstResultado
            // 
            lstResultado.BorderStyle = BorderStyle.Fixed3D;
            lstResultado.Font = new Font("Segoe UI", 12F);
            lstResultado.ForeColor = Color.Blue;
            lstResultado.Location = new Point(77, 284);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(389, 78);
            lstResultado.TabIndex = 10;
            lstResultado.Text = "---";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(266, 74);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 7;
            dtpFecha.ValueChanged += dtp_ValueChanged;
            // 
            // frmIngresoCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(lstResultado);
            Controls.Add(mkbPrecioUnitaerio);
            Controls.Add(cboProducto);
            Controls.Add(dtpFecha);
            Controls.Add(CantidadNum);
            Controls.Add(lblTitulo);
            Controls.Add(btnIngresar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmIngresoCompras";
            Text = "Ingreso Compras";
            ((System.ComponentModel.ISupportInitialize)CantidadNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private Button btnIngresar;
        private Label lblTitulo;
        private NumericUpDown CantidadNum;
        private DateTimePicker dtp;
        private ComboBox cboProducto;
        private MaskedTextBox mkbPrecioUnitaerio;
        private Label lstResultado;
        private DateTimePicker dtpFecha;
    }
}
