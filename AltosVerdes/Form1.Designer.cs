namespace AltosVerdes
{
    partial class Form1
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
            this.labNombre1 = new System.Windows.Forms.Label();
            this.labNombre2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labFaltasLoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labLocal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labFaltasVis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labVisitante = new System.Windows.Forms.Label();
            this.btnCargar1 = new System.Windows.Forms.Button();
            this.btnCargar2 = new System.Windows.Forms.Button();
            this.btnTanto = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnFalta = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNombre1
            // 
            this.labNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre1.Location = new System.Drawing.Point(18, 24);
            this.labNombre1.Name = "labNombre1";
            this.labNombre1.Size = new System.Drawing.Size(203, 32);
            this.labNombre1.TabIndex = 0;
            this.labNombre1.Text = "Local";
            // 
            // labNombre2
            // 
            this.labNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre2.Location = new System.Drawing.Point(247, 24);
            this.labNombre2.Name = "labNombre2";
            this.labNombre2.Size = new System.Drawing.Size(203, 23);
            this.labNombre2.TabIndex = 1;
            this.labNombre2.Text = "Visitante";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labFaltasLoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labLocal);
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // labFaltasLoc
            // 
            this.labFaltasLoc.AutoSize = true;
            this.labFaltasLoc.Location = new System.Drawing.Point(48, 94);
            this.labFaltasLoc.Name = "labFaltasLoc";
            this.labFaltasLoc.Size = new System.Drawing.Size(13, 13);
            this.labFaltasLoc.TabIndex = 4;
            this.labFaltasLoc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Faltas";
            // 
            // labLocal
            // 
            this.labLocal.AutoSize = true;
            this.labLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLocal.Location = new System.Drawing.Point(72, 28);
            this.labLocal.Name = "labLocal";
            this.labLocal.Size = new System.Drawing.Size(52, 55);
            this.labLocal.TabIndex = 4;
            this.labLocal.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.labFaltasVis);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labVisitante);
            this.groupBox2.Location = new System.Drawing.Point(250, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitante";
            // 
            // labFaltasVis
            // 
            this.labFaltasVis.AutoSize = true;
            this.labFaltasVis.Location = new System.Drawing.Point(47, 94);
            this.labFaltasVis.Name = "labFaltasVis";
            this.labFaltasVis.Size = new System.Drawing.Size(13, 13);
            this.labFaltasVis.TabIndex = 5;
            this.labFaltasVis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Faltas";
            // 
            // labVisitante
            // 
            this.labVisitante.AutoSize = true;
            this.labVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVisitante.Location = new System.Drawing.Point(78, 28);
            this.labVisitante.Name = "labVisitante";
            this.labVisitante.Size = new System.Drawing.Size(52, 55);
            this.labVisitante.TabIndex = 0;
            this.labVisitante.Text = "0";
            // 
            // btnCargar1
            // 
            this.btnCargar1.Location = new System.Drawing.Point(23, 204);
            this.btnCargar1.Name = "btnCargar1";
            this.btnCargar1.Size = new System.Drawing.Size(100, 48);
            this.btnCargar1.TabIndex = 4;
            this.btnCargar1.Text = "Cargar equipo local";
            this.btnCargar1.UseVisualStyleBackColor = true;
            this.btnCargar1.Click += new System.EventHandler(this.btnCargar1_Click);
            // 
            // btnCargar2
            // 
            this.btnCargar2.Location = new System.Drawing.Point(350, 204);
            this.btnCargar2.Name = "btnCargar2";
            this.btnCargar2.Size = new System.Drawing.Size(100, 48);
            this.btnCargar2.TabIndex = 5;
            this.btnCargar2.Text = "Cargar equipo visitante";
            this.btnCargar2.UseVisualStyleBackColor = true;
            this.btnCargar2.Click += new System.EventHandler(this.btnCargar2_Click);
            // 
            // btnTanto
            // 
            this.btnTanto.Enabled = false;
            this.btnTanto.Location = new System.Drawing.Point(23, 272);
            this.btnTanto.Name = "btnTanto";
            this.btnTanto.Size = new System.Drawing.Size(100, 48);
            this.btnTanto.TabIndex = 6;
            this.btnTanto.Text = "Cargar tanto";
            this.btnTanto.UseVisualStyleBackColor = true;
            this.btnTanto.Click += new System.EventHandler(this.btnTanto_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(350, 272);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 48);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnFalta
            // 
            this.btnFalta.Enabled = false;
            this.btnFalta.Location = new System.Drawing.Point(191, 272);
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(100, 48);
            this.btnFalta.TabIndex = 8;
            this.btnFalta.Text = "Cargar falta";
            this.btnFalta.UseVisualStyleBackColor = true;
            this.btnFalta.Click += new System.EventHandler(this.btnFalta_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Location = new System.Drawing.Point(350, 272);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 48);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 341);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnTanto);
            this.Controls.Add(this.btnFalta);
            this.Controls.Add(this.btnCargar2);
            this.Controls.Add(this.btnCargar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labNombre2);
            this.Controls.Add(this.labNombre1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labNombre1;
        private System.Windows.Forms.Label labNombre2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labFaltasLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labLocal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labFaltasVis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labVisitante;
        private System.Windows.Forms.Button btnCargar1;
        private System.Windows.Forms.Button btnCargar2;
        private System.Windows.Forms.Button btnTanto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnFalta;
        private System.Windows.Forms.Button btnIniciar;
    }
}

