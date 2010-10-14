namespace BackPropagation
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.labResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labValorEsperado = new System.Windows.Forms.Label();
            this.txtValorEsperado = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarEjemplo = new System.Windows.Forms.Button();
            this.labError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArchivoEntrenamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArchivoDePesos = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoEntrenamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoDePesos = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jonathan Lizano Jiménez A63183";
            // 
            // btnProbar
            // 
            this.btnProbar.Enabled = false;
            this.btnProbar.Location = new System.Drawing.Point(478, 434);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(77, 37);
            this.btnProbar.TabIndex = 2;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.probar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 434);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.salir_Click);
            // 
            // btnEntrenar
            // 
            this.btnEntrenar.Enabled = false;
            this.btnEntrenar.Location = new System.Drawing.Point(396, 434);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(76, 37);
            this.btnEntrenar.TabIndex = 4;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.entrenar_Click);
            // 
            // labResultado
            // 
            this.labResultado.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultado.Location = new System.Drawing.Point(441, 45);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(183, 231);
            this.labResultado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // labValorEsperado
            // 
            this.labValorEsperado.AutoSize = true;
            this.labValorEsperado.Location = new System.Drawing.Point(422, 163);
            this.labValorEsperado.Name = "labValorEsperado";
            this.labValorEsperado.Size = new System.Drawing.Size(79, 13);
            this.labValorEsperado.TabIndex = 7;
            this.labValorEsperado.Text = "Valor Esperado";
            // 
            // txtValorEsperado
            // 
            this.txtValorEsperado.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEsperado.Location = new System.Drawing.Point(434, 179);
            this.txtValorEsperado.Mask = "a";
            this.txtValorEsperado.Name = "txtValorEsperado";
            this.txtValorEsperado.Size = new System.Drawing.Size(55, 97);
            this.txtValorEsperado.TabIndex = 8;
            this.txtValorEsperado.TextChanged += new System.EventHandler(this.txtValorEsperado_TextChanged);
            // 
            // btnAgregarEjemplo
            // 
            this.btnAgregarEjemplo.Enabled = false;
            this.btnAgregarEjemplo.Location = new System.Drawing.Point(286, 434);
            this.btnAgregarEjemplo.Name = "btnAgregarEjemplo";
            this.btnAgregarEjemplo.Size = new System.Drawing.Size(104, 37);
            this.btnAgregarEjemplo.TabIndex = 9;
            this.btnAgregarEjemplo.Text = "Agregar Ejemplo de Entrenamiento";
            this.btnAgregarEjemplo.UseVisualStyleBackColor = true;
            this.btnAgregarEjemplo.Click += new System.EventHandler(this.button1_Click);
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labError.Location = new System.Drawing.Point(33, 506);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(0, 24);
            this.labError.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modo: Seleccione la acción que desea realizar";
            // 
            // cmbModo
            // 
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Items.AddRange(new object[] {
            "",
            "Agregar Ejemplos de entrenamiento",
            "Entrenar",
            "Probar"});
            this.cmbModo.Location = new System.Drawing.Point(37, 450);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(196, 21);
            this.cmbModo.TabIndex = 12;
            this.cmbModo.SelectedIndexChanged += new System.EventHandler(this.cmbModo_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(563, 434);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 37);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArchivoEntrenamiento,
            this.nuevoArchivoDePesos});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // nuevoArchivoEntrenamiento
            // 
            this.nuevoArchivoEntrenamiento.Name = "nuevoArchivoEntrenamiento";
            this.nuevoArchivoEntrenamiento.Size = new System.Drawing.Size(194, 22);
            this.nuevoArchivoEntrenamiento.Text = "Archivo Entrenamiento";
            this.nuevoArchivoEntrenamiento.Click += new System.EventHandler(this.nuevoArchivoEntrenamiento_Click);
            // 
            // nuevoArchivoDePesos
            // 
            this.nuevoArchivoDePesos.Name = "nuevoArchivoDePesos";
            this.nuevoArchivoDePesos.Size = new System.Drawing.Size(194, 22);
            this.nuevoArchivoDePesos.Text = "Archivo De Pesos";
            this.nuevoArchivoDePesos.Click += new System.EventHandler(this.nuevoArchivoDePesos_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoEntrenamiento,
            this.abrirArchivoDePesos});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // abrirArchivoEntrenamiento
            // 
            this.abrirArchivoEntrenamiento.Name = "abrirArchivoEntrenamiento";
            this.abrirArchivoEntrenamiento.Size = new System.Drawing.Size(194, 22);
            this.abrirArchivoEntrenamiento.Text = "Archivo Entrenamiento";
            this.abrirArchivoEntrenamiento.Click += new System.EventHandler(this.abrirArchivoEntrenamiento_Click);
            // 
            // abrirArchivoDePesos
            // 
            this.abrirArchivoDePesos.Name = "abrirArchivoDePesos";
            this.abrirArchivoDePesos.Size = new System.Drawing.Size(194, 22);
            this.abrirArchivoDePesos.Text = "Archivo De Pesos";
            this.abrirArchivoDePesos.Click += new System.EventHandler(this.abrirArchivoDePesos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 578);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbModo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.btnAgregarEjemplo);
            this.Controls.Add(this.txtValorEsperado);
            this.Controls.Add(this.labValorEsperado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.btnEntrenar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Principal";
            this.Text = "Reconocedor De Vocales - Back Propagation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labValorEsperado;
        private System.Windows.Forms.MaskedTextBox txtValorEsperado;
        private System.Windows.Forms.Button btnAgregarEjemplo;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArchivoEntrenamiento;
        private System.Windows.Forms.ToolStripMenuItem nuevoArchivoDePesos;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoEntrenamiento;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoDePesos;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;



    }
}

