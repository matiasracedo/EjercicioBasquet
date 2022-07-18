namespace AltosVerdes
{
    partial class CargaEquipos
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
            this.tbEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.gBjugadores = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cBCamiseta = new System.Windows.Forms.ComboBox();
            this.tBJugador = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gBjugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre equipo";
            // 
            // tbEquipo
            // 
            this.tbEquipo.Location = new System.Drawing.Point(93, 27);
            this.tbEquipo.Name = "tbEquipo";
            this.tbEquipo.Size = new System.Drawing.Size(114, 20);
            this.tbEquipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Camiseta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContinuar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEquipo);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear equipo";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(271, 25);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // gBjugadores
            // 
            this.gBjugadores.Controls.Add(this.btnCancelar);
            this.gBjugadores.Controls.Add(this.btnCargar);
            this.gBjugadores.Controls.Add(this.cBCamiseta);
            this.gBjugadores.Controls.Add(this.tBJugador);
            this.gBjugadores.Controls.Add(this.label2);
            this.gBjugadores.Controls.Add(this.label3);
            this.gBjugadores.Enabled = false;
            this.gBjugadores.Location = new System.Drawing.Point(23, 116);
            this.gBjugadores.Name = "gBjugadores";
            this.gBjugadores.Size = new System.Drawing.Size(363, 100);
            this.gBjugadores.TabIndex = 6;
            this.gBjugadores.TabStop = false;
            this.gBjugadores.Text = "Cargar jugadores";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Location = new System.Drawing.Point(271, 62);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCargar.Location = new System.Drawing.Point(271, 26);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cBCamiseta
            // 
            this.cBCamiseta.FormattingEnabled = true;
            this.cBCamiseta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBCamiseta.Location = new System.Drawing.Point(93, 62);
            this.cBCamiseta.Name = "cBCamiseta";
            this.cBCamiseta.Size = new System.Drawing.Size(114, 21);
            this.cBCamiseta.TabIndex = 5;
            // 
            // tBJugador
            // 
            this.tBJugador.Location = new System.Drawing.Point(93, 29);
            this.tBJugador.Name = "tBJugador";
            this.tBJugador.Size = new System.Drawing.Size(114, 20);
            this.tBJugador.TabIndex = 4;
            // 
            // btnTerminar
            // 
            this.btnTerminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTerminar.Location = new System.Drawing.Point(148, 237);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(100, 55);
            this.btnTerminar.TabIndex = 7;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // CargaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 315);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.gBjugadores);
            this.Controls.Add(this.groupBox1);
            this.Name = "CargaEquipos";
            this.Text = "CargaEquipos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBjugadores.ResumeLayout(false);
            this.gBjugadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTerminar;
        public System.Windows.Forms.TextBox tbEquipo;
        public System.Windows.Forms.Button btnContinuar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnCargar;
        public System.Windows.Forms.ComboBox cBCamiseta;
        public System.Windows.Forms.TextBox tBJugador;
        public System.Windows.Forms.GroupBox gBjugadores;
    }
}