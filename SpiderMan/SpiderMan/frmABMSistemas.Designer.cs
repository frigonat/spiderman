namespace SpiderMan
{
    partial class frmABMSistemas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMSistemas));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificarConexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreSistema = new System.Windows.Forms.TextBox();
            this.txtDescripcionSistema = new System.Windows.Forms.TextBox();
            this.txtDireccionIPSistema = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstadoNuevo = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslOperacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(428, 126);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(428, 76);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnVerificarConexion
            // 
            this.btnVerificarConexion.Enabled = false;
            this.btnVerificarConexion.Location = new System.Drawing.Point(227, 171);
            this.btnVerificarConexion.Name = "btnVerificarConexion";
            this.btnVerificarConexion.Size = new System.Drawing.Size(173, 23);
            this.btnVerificarConexion.TabIndex = 9;
            this.btnVerificarConexion.Text = "Verificar Conexión";
            this.btnVerificarConexion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección IP:";
            // 
            // txtNombreSistema
            // 
            this.txtNombreSistema.Location = new System.Drawing.Point(66, 27);
            this.txtNombreSistema.Name = "txtNombreSistema";
            this.txtNombreSistema.Size = new System.Drawing.Size(100, 21);
            this.txtNombreSistema.TabIndex = 1;
            // 
            // txtDescripcionSistema
            // 
            this.txtDescripcionSistema.Location = new System.Drawing.Point(83, 74);
            this.txtDescripcionSistema.Name = "txtDescripcionSistema";
            this.txtDescripcionSistema.Size = new System.Drawing.Size(162, 21);
            this.txtDescripcionSistema.TabIndex = 3;
            // 
            // txtDireccionIPSistema
            // 
            this.txtDireccionIPSistema.Location = new System.Drawing.Point(85, 123);
            this.txtDireccionIPSistema.Name = "txtDireccionIPSistema";
            this.txtDireccionIPSistema.Size = new System.Drawing.Size(174, 21);
            this.txtDireccionIPSistema.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslOperacion,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(540, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(428, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "&";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado:";
            // 
            // lblEstadoNuevo
            // 
            this.lblEstadoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstadoNuevo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoNuevo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblEstadoNuevo.Location = new System.Drawing.Point(66, 173);
            this.lblEstadoNuevo.Name = "lblEstadoNuevo";
            this.lblEstadoNuevo.Size = new System.Drawing.Size(66, 21);
            this.lblEstadoNuevo.TabIndex = 7;
            this.lblEstadoNuevo.Text = "Nuevo";
            this.lblEstadoNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(62, 173);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(121, 21);
            this.cmbEstados.TabIndex = 8;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // tslOperacion
            // 
            this.tslOperacion.AutoSize = false;
            this.tslOperacion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslOperacion.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tslOperacion.Name = "tslOperacion";
            this.tslOperacion.Size = new System.Drawing.Size(199, 17);
            this.tslOperacion.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmABMSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 245);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.lblEstadoNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtDireccionIPSistema);
            this.Controls.Add(this.txtDescripcionSistema);
            this.Controls.Add(this.txtNombreSistema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerificarConexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMSistemas";
            this.Text = "frmABMSistemas";
            this.Load += new System.EventHandler(this.frmABMSistemas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificarConexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreSistema;
        private System.Windows.Forms.TextBox txtDescripcionSistema;
        private System.Windows.Forms.TextBox txtDireccionIPSistema;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstadoNuevo;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslOperacion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
    }
}