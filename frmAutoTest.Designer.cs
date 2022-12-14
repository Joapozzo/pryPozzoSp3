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
            this.numAñoFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtNroTurno = new System.Windows.Forms.TextBox();
            this.lblNroTurno = new System.Windows.Forms.Label();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.txtCantDominio = new System.Windows.Forms.TextBox();
            this.lblCantDominio = new System.Windows.Forms.Label();
            this.lblAñoAntiguo = new System.Windows.Forms.Label();
            this.lblCantTurnos = new System.Windows.Forms.Label();
            this.txtAñoAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantTurnos = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFabricacion)).BeginInit();
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
            this.mrcRegistro.Controls.Add(this.numAñoFabricacion);
            this.mrcRegistro.Controls.Add(this.txtNroTurno);
            this.mrcRegistro.Controls.Add(this.lblNroTurno);
            this.mrcRegistro.Location = new System.Drawing.Point(12, 12);
            this.mrcRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcRegistro.Size = new System.Drawing.Size(549, 239);
            this.mrcRegistro.TabIndex = 0;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro de Turnos";
            // 
            // txtTitular
            // 
            this.txtTitular.Enabled = false;
            this.txtTitular.Location = new System.Drawing.Point(133, 183);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(316, 22);
            this.txtTitular.TabIndex = 9;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(5, 183);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(44, 16);
            this.lblTitular.TabIndex = 8;
            this.lblTitular.Text = "Titular";
            // 
            // lblAñoFabricacion
            // 
            this.lblAñoFabricacion.AutoSize = true;
            this.lblAñoFabricacion.Location = new System.Drawing.Point(5, 135);
            this.lblAñoFabricacion.Name = "lblAñoFabricacion";
            this.lblAñoFabricacion.Size = new System.Drawing.Size(105, 16);
            this.lblAñoFabricacion.TabIndex = 7;
            this.lblAñoFabricacion.Text = "Año Fabricacion";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(5, 82);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(57, 16);
            this.lblDominio.TabIndex = 6;
            this.lblDominio.Text = "Dominio";
            // 
            // txtDominio
            // 
            this.txtDominio.Enabled = false;
            this.txtDominio.Location = new System.Drawing.Point(133, 80);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(137, 22);
            this.txtDominio.TabIndex = 5;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // numAñoFabricacion
            // 
            this.numAñoFabricacion.Enabled = false;
            this.numAñoFabricacion.Location = new System.Drawing.Point(133, 129);
            this.numAñoFabricacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAñoFabricacion.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numAñoFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAñoFabricacion.Name = "numAñoFabricacion";
            this.numAñoFabricacion.Size = new System.Drawing.Size(76, 22);
            this.numAñoFabricacion.TabIndex = 4;
            this.numAñoFabricacion.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAñoFabricacion.ValueChanged += new System.EventHandler(this.numAñoFabricacion_ValueChanged);
            // 
            // txtNroTurno
            // 
            this.txtNroTurno.Location = new System.Drawing.Point(133, 28);
            this.txtNroTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroTurno.MaxLength = 5;
            this.txtNroTurno.Name = "txtNroTurno";
            this.txtNroTurno.Size = new System.Drawing.Size(100, 22);
            this.txtNroTurno.TabIndex = 3;
            this.txtNroTurno.TextChanged += new System.EventHandler(this.txtNroTurno_TextChanged);
            this.txtNroTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTurno_KeyPress);
            // 
            // lblNroTurno
            // 
            this.lblNroTurno.AutoSize = true;
            this.lblNroTurno.Location = new System.Drawing.Point(5, 28);
            this.lblNroTurno.Name = "lblNroTurno";
            this.lblNroTurno.Size = new System.Drawing.Size(112, 16);
            this.lblNroTurno.TabIndex = 2;
            this.lblNroTurno.Text = "Numero de Turno";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.txtCantDominio);
            this.mrcEstadisticas.Controls.Add(this.lblCantDominio);
            this.mrcEstadisticas.Controls.Add(this.lblAñoAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblCantTurnos);
            this.mrcEstadisticas.Controls.Add(this.txtAñoAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantTurnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(12, 257);
            this.mrcEstadisticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcEstadisticas.Size = new System.Drawing.Size(549, 181);
            this.mrcEstadisticas.TabIndex = 1;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // txtCantDominio
            // 
            this.txtCantDominio.Location = new System.Drawing.Point(253, 121);
            this.txtCantDominio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantDominio.Name = "txtCantDominio";
            this.txtCantDominio.ReadOnly = true;
            this.txtCantDominio.Size = new System.Drawing.Size(100, 22);
            this.txtCantDominio.TabIndex = 15;
            // 
            // lblCantDominio
            // 
            this.lblCantDominio.AutoSize = true;
            this.lblCantDominio.Location = new System.Drawing.Point(7, 121);
            this.lblCantDominio.Name = "lblCantDominio";
            this.lblCantDominio.Size = new System.Drawing.Size(233, 16);
            this.lblCantDominio.TabIndex = 14;
            this.lblCantDominio.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // lblAñoAntiguo
            // 
            this.lblAñoAntiguo.AutoSize = true;
            this.lblAñoAntiguo.Location = new System.Drawing.Point(5, 81);
            this.lblAñoAntiguo.Name = "lblAñoAntiguo";
            this.lblAñoAntiguo.Size = new System.Drawing.Size(130, 16);
            this.lblAñoAntiguo.TabIndex = 13;
            this.lblAñoAntiguo.Text = "Año del mas Antiguo";
            // 
            // lblCantTurnos
            // 
            this.lblCantTurnos.AutoSize = true;
            this.lblCantTurnos.Location = new System.Drawing.Point(5, 39);
            this.lblCantTurnos.Name = "lblCantTurnos";
            this.lblCantTurnos.Size = new System.Drawing.Size(125, 16);
            this.lblCantTurnos.TabIndex = 10;
            this.lblCantTurnos.Text = "Cantidad de Turnos";
            // 
            // txtAñoAntiguo
            // 
            this.txtAñoAntiguo.Location = new System.Drawing.Point(253, 78);
            this.txtAñoAntiguo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAñoAntiguo.Name = "txtAñoAntiguo";
            this.txtAñoAntiguo.ReadOnly = true;
            this.txtAñoAntiguo.Size = new System.Drawing.Size(100, 22);
            this.txtAñoAntiguo.TabIndex = 12;
            // 
            // txtCantTurnos
            // 
            this.txtCantTurnos.Location = new System.Drawing.Point(253, 39);
            this.txtCantTurnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantTurnos.Name = "txtCantTurnos";
            this.txtCantTurnos.ReadOnly = true;
            this.txtCantTurnos.Size = new System.Drawing.Size(100, 22);
            this.txtCantTurnos.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(607, 89);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(607, 21);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(116, 34);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(607, 267);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 34);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcRegistro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAutoTest";
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.frmAutoTest_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFabricacion)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numAñoFabricacion;
        private System.Windows.Forms.TextBox txtNroTurno;
        private System.Windows.Forms.Label lblNroTurno;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.TextBox txtCantDominio;
        private System.Windows.Forms.Label lblCantDominio;
        private System.Windows.Forms.Label lblAñoAntiguo;
        private System.Windows.Forms.Label lblCantTurnos;
        private System.Windows.Forms.TextBox txtAñoAntiguo;
        private System.Windows.Forms.TextBox txtCantTurnos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
    }
}

