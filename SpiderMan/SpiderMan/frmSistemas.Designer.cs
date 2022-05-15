namespace SpiderMan
{
    partial class frmSistemas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistemas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCantidadSistemas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslAgregar = new System.Windows.Forms.ToolStripButton();
            this.tslEditar = new System.Windows.Forms.ToolStripButton();
            this.tslEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslRefrescar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvSistemas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.colNombreSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccionIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslCantidadSistemas,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // tsslCantidadSistemas
            // 
            this.tsslCantidadSistemas.AutoSize = false;
            this.tsslCantidadSistemas.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslCantidadSistemas.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tsslCantidadSistemas.Name = "tsslCantidadSistemas";
            this.tsslCantidadSistemas.Size = new System.Drawing.Size(118, 19);
            this.tsslCantidadSistemas.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel3.Text = "...";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel4.Text = "...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAgregar,
            this.tslEditar,
            this.tslEliminar,
            this.toolStripSeparator1,
            this.tslGuardar,
            this.toolStripSeparator2,
            this.tslRefrescar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(713, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslAgregar
            // 
            this.tslAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tslAgregar.Image")));
            this.tslAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslAgregar.Name = "tslAgregar";
            this.tslAgregar.Size = new System.Drawing.Size(23, 22);
            this.tslAgregar.Text = "Agregar sistema...";
            this.tslAgregar.Click += new System.EventHandler(this.tslAgregar_Click);
            // 
            // tslEditar
            // 
            this.tslEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslEditar.Image = ((System.Drawing.Image)(resources.GetObject("tslEditar.Image")));
            this.tslEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslEditar.Name = "tslEditar";
            this.tslEditar.Size = new System.Drawing.Size(23, 22);
            this.tslEditar.Text = "Editar el sistema actual";
            this.tslEditar.Click += new System.EventHandler(this.tslEditar_Click);
            // 
            // tslEliminar
            // 
            this.tslEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tslEliminar.Image")));
            this.tslEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(23, 22);
            this.tslEliminar.Text = "toolStripButton3";
            this.tslEliminar.ToolTipText = "Eliminar sistema actual";
            this.tslEliminar.Click += new System.EventHandler(this.tslEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslGuardar
            // 
            this.tslGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tslGuardar.Image")));
            this.tslGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslGuardar.Name = "tslGuardar";
            this.tslGuardar.Size = new System.Drawing.Size(23, 22);
            this.tslGuardar.Text = "toolStripButton1";
            this.tslGuardar.ToolTipText = "Guardar";
            this.tslGuardar.Click += new System.EventHandler(this.tslGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslRefrescar
            // 
            this.tslRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("tslRefrescar.Image")));
            this.tslRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslRefrescar.Name = "tslRefrescar";
            this.tslRefrescar.Size = new System.Drawing.Size(23, 22);
            this.tslRefrescar.Text = "toolStripButton2";
            this.tslRefrescar.ToolTipText = "Refrescar";
            this.tslRefrescar.Click += new System.EventHandler(this.tslRefrescar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(621, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 322);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Location = new System.Drawing.Point(113, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar...";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvSistemas
            // 
            this.dgvSistemas.AllowUserToAddRows = false;
            this.dgvSistemas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSistemas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSistemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSistemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreSistema,
            this.colDescripcionSistema,
            this.colDireccionIP,
            this.colEstadoSistema});
            this.dgvSistemas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSistemas.Location = new System.Drawing.Point(14, 41);
            this.dgvSistemas.Name = "dgvSistemas";
            this.dgvSistemas.Size = new System.Drawing.Size(682, 263);
            this.dgvSistemas.TabIndex = 7;
            this.dgvSistemas.SelectionChanged += new System.EventHandler(this.dgvSistemas_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(211, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // colNombreSistema
            // 
            this.colNombreSistema.HeaderText = "Nombre";
            this.colNombreSistema.Name = "colNombreSistema";
            // 
            // colDescripcionSistema
            // 
            this.colDescripcionSistema.HeaderText = "Descripción";
            this.colDescripcionSistema.Name = "colDescripcionSistema";
            this.colDescripcionSistema.Width = 300;
            // 
            // colDireccionIP
            // 
            this.colDireccionIP.HeaderText = "IP";
            this.colDireccionIP.Name = "colDireccionIP";
            // 
            // colEstadoSistema
            // 
            this.colEstadoSistema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEstadoSistema.HeaderText = "Estado";
            this.colEstadoSistema.Name = "colEstadoSistema";
            // 
            // frmSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 388);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvSistemas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistemas";
            this.Text = "Sistemas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSistemas_FormClosing);
            this.Load += new System.EventHandler(this.frmSistemas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tslAgregar;
        private System.Windows.Forms.ToolStripButton tslEditar;
        private System.Windows.Forms.ToolStripButton tslEliminar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCantidadSistemas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvSistemas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tslGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tslRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccionIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoSistema;
    }
}

