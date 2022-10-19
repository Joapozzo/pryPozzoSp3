namespace pryPozzoSp3
{
    partial class frmAutoTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblAñoFabricacion = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.numAnioFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtNroTurno = new System.Windows.Forms.TextBox();
            this.lblNroTurno = new System.Windows.Forms.Label();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.txtCantDominio = new System.Windows.Forms.TextBox();
            this.lblCantDominio = new System.Windows.Forms.Label();
            this.lblAnioAntiguo = new System.Windows.Forms.Label();
            this.lblCantTurnos = new System.Windows.Forms.Label();
            this.txtAnioAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantTurnos = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).BeginInit();
            this.mrcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.txtTitular);
            this.mrcRegistro.Controls.Add(this.lblTitular);
            this.mrcRegistro.Controls.Add(this.lblAñoFabricacion);
            this.mrcRegistro.Controls.Add(this.lblDominio);
            this.mrcRegistro.Controls.Add(this.txtDominio);
            this.mrcRegistro.Controls.Add(this.numAnioFabricacion);
            this.mrcRegistro.Controls.Add(this.txtNroTurno);
            this.mrcRegistro.Controls.Add(this.lblNroTurno);
            this.mrcRegistro.Location = new System.Drawing.Point(9, 10);
            this.mrcRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.mrcRegistro.Size = new System.Drawing.Size(412, 194);
            this.mrcRegistro.TabIndex = 0;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro de Turnos";
            // 
            // txtTitular
            // 
            this.txtTitular.Enabled = false;
            this.txtTitular.Location = new System.Drawing.Point(100, 149);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(238, 20);
            this.txtTitular.TabIndex = 9;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(4, 149);
            this.lblTitular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 8;
            this.lblTitular.Text = "Titular";
            // 
            // lblAñoFabricacion
            // 
            this.lblAñoFabricacion.AutoSize = true;
            this.lblAñoFabricacion.Location = new System.Drawing.Point(4, 110);
            this.lblAñoFabricacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAñoFabricacion.Name = "lblAñoFabricacion";
            this.lblAñoFabricacion.Size = new System.Drawing.Size(84, 13);
            this.lblAñoFabricacion.TabIndex = 7;
            this.lblAñoFabricacion.Text = "Año Fabricacion";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(4, 67);
            this.lblDominio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 6;
            this.lblDominio.Text = "Dominio";
            // 
            // txtDominio
            // 
            this.txtDominio.Enabled = false;
            this.txtDominio.Location = new System.Drawing.Point(100, 65);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(104, 20);
            this.txtDominio.TabIndex = 5;
            // 
            // numAnioFabricacion
            // 
            this.numAnioFabricacion.Enabled = false;
            this.numAnioFabricacion.Location = new System.Drawing.Point(100, 105);
            this.numAnioFabricacion.Margin = new System.Windows.Forms.Padding(2);
            this.numAnioFabricacion.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numAnioFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAnioFabricacion.Name = "numAnioFabricacion";
            this.numAnioFabricacion.Size = new System.Drawing.Size(57, 20);
            this.numAnioFabricacion.TabIndex = 4;
            this.numAnioFabricacion.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.Location = new System.Drawing.Point(100, 23);
            this.txtNroTurno.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroTurno.MaxLength = 5;
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(76, 20);
            this.txtNroTurno.TabIndex = 3;
            this.txtNroTurno.TextChanged += new System.EventHandler(this.txtNroTurno_TextChanged);
            this.txtNroTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTurno_KeyPress);
            // 
            // lblNroTurno
            // 
            this.lblNroTurno.AutoSize = true;
            this.lblNroTurno.Location = new System.Drawing.Point(4, 23);
            this.lblNroTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroTurno.Name = "lblNroTurno";
            this.lblNroTurno.Size = new System.Drawing.Size(90, 13);
            this.lblNroTurno.TabIndex = 2;
            this.lblNroTurno.Text = "Numero de Turno";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.txtCantDominio);
            this.mrcEstadisticas.Controls.Add(this.lblCantDominio);
            this.mrcEstadisticas.Controls.Add(this.lblAnioAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblCantTurnos);
            this.mrcEstadisticas.Controls.Add(this.txtAnioAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantTurnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(9, 209);
            this.mrcEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Padding = new System.Windows.Forms.Padding(2);
            this.mrcEstadisticas.Size = new System.Drawing.Size(412, 147);
            this.mrcEstadisticas.TabIndex = 1;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // txtCantDominio
            // 
            this.txtCantDominio.Location = new System.Drawing.Point(190, 98);
            this.txtCantDominio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantDominio.Name = "txtCantDominio";
            this.txtCantDominio.ReadOnly = true;
            this.txtCantDominio.Size = new System.Drawing.Size(76, 20);
            this.txtCantDominio.TabIndex = 15;
            // 
            // lblCantDominio
            // 
            this.lblCantDominio.AutoSize = true;
            this.lblCantDominio.Location = new System.Drawing.Point(5, 98);
            this.lblCantDominio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantDominio.Name = "lblCantDominio";
            this.lblCantDominio.Size = new System.Drawing.Size(186, 13);
            this.lblCantDominio.TabIndex = 14;
            this.lblCantDominio.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // lblAnioAntiguo
            // 
            this.lblAnioAntiguo.AutoSize = true;
            this.lblAnioAntiguo.Location = new System.Drawing.Point(4, 66);
            this.lblAnioAntiguo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnioAntiguo.Name = "lblAnioAntiguo";
            this.lblAnioAntiguo.Size = new System.Drawing.Size(104, 13);
            this.lblAnioAntiguo.TabIndex = 13;
            this.lblAnioAntiguo.Text = "Año del mas Antiguo";
            // 
            // lblCantTurnos
            // 
            this.lblCantTurnos.AutoSize = true;
            this.lblCantTurnos.Location = new System.Drawing.Point(4, 32);
            this.lblCantTurnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantTurnos.Name = "lblCantTurnos";
            this.lblCantTurnos.Size = new System.Drawing.Size(100, 13);
            this.lblCantTurnos.TabIndex = 10;
            this.lblCantTurnos.Text = "Cantidad de Turnos";
            // 
            // txtAnioAntiguo
            // 
            this.txtAnioAntiguo.Location = new System.Drawing.Point(190, 63);
            this.txtAnioAntiguo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnioAntiguo.Name = "txtAnioAntiguo";
            this.txtAnioAntiguo.ReadOnly = true;
            this.txtAnioAntiguo.Size = new System.Drawing.Size(76, 20);
            this.txtAnioAntiguo.TabIndex = 12;
            // 
            // txtCantTurnos
            // 
            this.txtCantTurnos.Location = new System.Drawing.Point(190, 32);
            this.txtCantTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantTurnos.Name = "txtCantTurnos";
            this.txtCantTurnos.ReadOnly = true;
            this.txtCantTurnos.Size = new System.Drawing.Size(76, 20);
            this.txtCantTurnos.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(455, 72);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 28);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(455, 17);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 28);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(455, 217);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 28);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 366);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcRegistro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAutoTest";
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.frmAutoTest_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnioFabricacion)).EndInit();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAñoFabricacion;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.NumericUpDown numAnioFabricacion;
        private System.Windows.Forms.TextBox txtNroTurno;
        private System.Windows.Forms.Label lblNroTurno;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.TextBox txtCantDominio;
        private System.Windows.Forms.Label lblCantDominio;
        private System.Windows.Forms.Label lblAnioAntiguo;
        private System.Windows.Forms.Label lblCantTurnos;
        private System.Windows.Forms.TextBox txtAnioAntiguo;
        private System.Windows.Forms.TextBox txtCantTurnos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
    }
}

