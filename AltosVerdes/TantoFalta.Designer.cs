namespace AltosVerdes
{
    partial class TantoFalta
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBjugador = new System.Windows.Forms.ComboBox();
            this.labTanto = new System.Windows.Forms.Label();
            this.cBtanto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBequipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(62, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(202, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jugador";
            // 
            // cBjugador
            // 
            this.cBjugador.FormattingEnabled = true;
            this.cBjugador.Items.AddRange(new object[] {
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
            this.cBjugador.Location = new System.Drawing.Point(158, 53);
            this.cBjugador.Name = "cBjugador";
            this.cBjugador.Size = new System.Drawing.Size(132, 21);
            this.cBjugador.TabIndex = 3;
            // 
            // labTanto
            // 
            this.labTanto.AutoSize = true;
            this.labTanto.Location = new System.Drawing.Point(59, 89);
            this.labTanto.Name = "labTanto";
            this.labTanto.Size = new System.Drawing.Size(35, 13);
            this.labTanto.TabIndex = 4;
            this.labTanto.Text = "Tanto";
            // 
            // cBtanto
            // 
            this.cBtanto.FormattingEnabled = true;
            this.cBtanto.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cBtanto.Location = new System.Drawing.Point(158, 86);
            this.cBtanto.Name = "cBtanto";
            this.cBtanto.Size = new System.Drawing.Size(132, 21);
            this.cBtanto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Equipo";
            // 
            // cBequipo
            // 
            this.cBequipo.FormattingEnabled = true;
            this.cBequipo.Items.AddRange(new object[] {
            "Local",
            "Visitante"});
            this.cBequipo.Location = new System.Drawing.Point(158, 21);
            this.cBequipo.Name = "cBequipo";
            this.cBequipo.Size = new System.Drawing.Size(132, 21);
            this.cBequipo.TabIndex = 7;
            // 
            // TantoFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.cBequipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBtanto);
            this.Controls.Add(this.labTanto);
            this.Controls.Add(this.cBjugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TantoFalta";
            this.Text = "TantoFalta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cBjugador;
        public System.Windows.Forms.Label labTanto;
        public System.Windows.Forms.ComboBox cBtanto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cBequipo;
    }
}