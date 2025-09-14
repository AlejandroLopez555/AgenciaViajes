namespace AgenciaViajes
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarInternacional = new System.Windows.Forms.Button();
            this.btnAgregarNacional = new System.Windows.Forms.Button();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.chkRequiereVisa = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnAgregarInternacional);
            this.groupBox1.Controls.Add(this.btnAgregarNacional);
            this.groupBox1.Controls.Add(this.nudPrecio);
            this.groupBox1.Controls.Add(this.nudDuracion);
            this.groupBox1.Controls.Add(this.txtAerolinea);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.chkRequiereVisa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGENDAR VIAJES";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(379, 45);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(212, 25);
            this.lblResultados.TabIndex = 16;
            this.lblResultados.Text = "TODOS LOS VIAJES";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(810, 421);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 34);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(614, 421);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(171, 34);
            this.btnEstadisticas.TabIndex = 14;
            this.btnEstadisticas.Text = "ESTADISTICAS";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(264, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 34);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(117, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 31);
            this.txtBuscar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "BUSCAR :";
            // 
            // btnAgregarInternacional
            // 
            this.btnAgregarInternacional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarInternacional.Location = new System.Drawing.Point(40, 380);
            this.btnAgregarInternacional.Name = "btnAgregarInternacional";
            this.btnAgregarInternacional.Size = new System.Drawing.Size(345, 34);
            this.btnAgregarInternacional.TabIndex = 10;
            this.btnAgregarInternacional.Text = "Agregar Internacional";
            this.btnAgregarInternacional.UseVisualStyleBackColor = true;
            this.btnAgregarInternacional.Click += new System.EventHandler(this.btnAgregarInternacional_Click);
            // 
            // btnAgregarNacional
            // 
            this.btnAgregarNacional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarNacional.Location = new System.Drawing.Point(40, 340);
            this.btnAgregarNacional.Name = "btnAgregarNacional";
            this.btnAgregarNacional.Size = new System.Drawing.Size(345, 34);
            this.btnAgregarNacional.TabIndex = 9;
            this.btnAgregarNacional.Text = "Agregar Nacional";
            this.btnAgregarNacional.UseVisualStyleBackColor = true;
            this.btnAgregarNacional.Click += new System.EventHandler(this.btnAgregarNacional_Click);
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(126, 269);
            this.nudPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(170, 31);
            this.nudPrecio.TabIndex = 8;
            this.nudPrecio.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(214, 102);
            this.nudDuracion.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(171, 31);
            this.nudDuracion.TabIndex = 7;
            this.nudDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Location = new System.Drawing.Point(158, 158);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(171, 31);
            this.txtAerolinea.TabIndex = 6;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(140, 54);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(170, 31);
            this.txtDestino.TabIndex = 5;
            // 
            // chkRequiereVisa
            // 
            this.chkRequiereVisa.AutoSize = true;
            this.chkRequiereVisa.Location = new System.Drawing.Point(40, 212);
            this.chkRequiereVisa.Name = "chkRequiereVisa";
            this.chkRequiereVisa.Size = new System.Drawing.Size(255, 29);
            this.chkRequiereVisa.TabIndex = 4;
            this.chkRequiereVisa.Text = "¿El viaje requiere visa?";
            this.chkRequiereVisa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duracion (Dias) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aerolinea :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 108);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtDetalles
            // 
            this.txtDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalles.Location = new System.Drawing.Point(858, 272);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalles.Size = new System.Drawing.Size(262, 108);
            this.txtDetalles.TabIndex = 2;
            this.txtDetalles.TextChanged += new System.EventHandler(this.txtDetalles_TextChanged);
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "";
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(858, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "DETALLES :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultados);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(426, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR VIAJES";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(426, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "VIAJES :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(399, 85);
            this.label8.TabIndex = 16;
            this.label8.Text = "TRAVEL SV";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AgenciaViajes.Properties.Resources.photo_1436491865332_7a61a109cc05;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 550);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.TextBox txtAerolinea;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.CheckBox chkRequiereVisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btnAgregarInternacional;
        private System.Windows.Forms.Button btnAgregarNacional;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

