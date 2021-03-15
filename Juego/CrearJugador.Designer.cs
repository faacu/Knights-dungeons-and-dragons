namespace Laboratorio2TP1
{
    partial class CrearJugador
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
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.groupBoxTablero = new System.Windows.Forms.GroupBox();
            this.rb_Experto = new System.Windows.Forms.RadioButton();
            this.rb_Intermedio = new System.Windows.Forms.RadioButton();
            this.rb_Simple = new System.Windows.Forms.RadioButton();
            this.labelNombre = new System.Windows.Forms.Label();
            this.b_Aceptar = new System.Windows.Forms.Button();
            this.b_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_Partida = new System.Windows.Forms.GroupBox();
            this.b_Ok = new System.Windows.Forms.Button();
            this.rb_Demo = new System.Windows.Forms.RadioButton();
            this.rb_Manual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.n_nroJugadores = new System.Windows.Forms.NumericUpDown();
            this.groupBoxTablero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Partida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_nroJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(96, 33);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_Nombre.TabIndex = 0;
            // 
            // groupBoxTablero
            // 
            this.groupBoxTablero.Controls.Add(this.rb_Experto);
            this.groupBoxTablero.Controls.Add(this.rb_Intermedio);
            this.groupBoxTablero.Controls.Add(this.rb_Simple);
            this.groupBoxTablero.Location = new System.Drawing.Point(19, 59);
            this.groupBoxTablero.Name = "groupBoxTablero";
            this.groupBoxTablero.Size = new System.Drawing.Size(247, 52);
            this.groupBoxTablero.TabIndex = 2;
            this.groupBoxTablero.TabStop = false;
            this.groupBoxTablero.Text = "Tablero";
            // 
            // rb_Experto
            // 
            this.rb_Experto.AutoSize = true;
            this.rb_Experto.Location = new System.Drawing.Point(166, 19);
            this.rb_Experto.Name = "rb_Experto";
            this.rb_Experto.Size = new System.Drawing.Size(61, 17);
            this.rb_Experto.TabIndex = 2;
            this.rb_Experto.TabStop = true;
            this.rb_Experto.Text = "Experto";
            this.rb_Experto.UseVisualStyleBackColor = true;
            // 
            // rb_Intermedio
            // 
            this.rb_Intermedio.AutoSize = true;
            this.rb_Intermedio.Location = new System.Drawing.Point(77, 19);
            this.rb_Intermedio.Name = "rb_Intermedio";
            this.rb_Intermedio.Size = new System.Drawing.Size(74, 17);
            this.rb_Intermedio.TabIndex = 1;
            this.rb_Intermedio.TabStop = true;
            this.rb_Intermedio.Text = "Intermedio";
            this.rb_Intermedio.UseVisualStyleBackColor = true;
            // 
            // rb_Simple
            // 
            this.rb_Simple.AutoSize = true;
            this.rb_Simple.Location = new System.Drawing.Point(7, 20);
            this.rb_Simple.Name = "rb_Simple";
            this.rb_Simple.Size = new System.Drawing.Size(56, 17);
            this.rb_Simple.TabIndex = 0;
            this.rb_Simple.TabStop = true;
            this.rb_Simple.Text = "Simple";
            this.rb_Simple.UseVisualStyleBackColor = true;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(36, 36);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // b_Aceptar
            // 
            this.b_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_Aceptar.Location = new System.Drawing.Point(36, 260);
            this.b_Aceptar.Name = "b_Aceptar";
            this.b_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.b_Aceptar.TabIndex = 5;
            this.b_Aceptar.Text = "Aceptar";
            this.b_Aceptar.UseVisualStyleBackColor = true;
            // 
            // b_Cancelar
            // 
            this.b_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_Cancelar.Location = new System.Drawing.Point(202, 260);
            this.b_Cancelar.Name = "b_Cancelar";
            this.b_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_Cancelar.TabIndex = 6;
            this.b_Cancelar.Text = "Cancelar";
            this.b_Cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Nombre);
            this.groupBox1.Controls.Add(this.groupBoxTablero);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(17, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Jugador";
            // 
            // gb_Partida
            // 
            this.gb_Partida.Controls.Add(this.b_Ok);
            this.gb_Partida.Controls.Add(this.rb_Demo);
            this.gb_Partida.Controls.Add(this.rb_Manual);
            this.gb_Partida.Controls.Add(this.label1);
            this.gb_Partida.Controls.Add(this.n_nroJugadores);
            this.gb_Partida.Location = new System.Drawing.Point(17, 6);
            this.gb_Partida.Name = "gb_Partida";
            this.gb_Partida.Size = new System.Drawing.Size(284, 109);
            this.gb_Partida.TabIndex = 8;
            this.gb_Partida.TabStop = false;
            this.gb_Partida.Text = "Partida";
            // 
            // b_Ok
            // 
            this.b_Ok.Location = new System.Drawing.Point(106, 70);
            this.b_Ok.Name = "b_Ok";
            this.b_Ok.Size = new System.Drawing.Size(75, 23);
            this.b_Ok.TabIndex = 6;
            this.b_Ok.Text = "Ok";
            this.b_Ok.UseVisualStyleBackColor = true;
            this.b_Ok.Click += new System.EventHandler(this.b_Ok_Click);
            // 
            // rb_Demo
            // 
            this.rb_Demo.AutoSize = true;
            this.rb_Demo.Location = new System.Drawing.Point(19, 39);
            this.rb_Demo.Name = "rb_Demo";
            this.rb_Demo.Size = new System.Drawing.Size(53, 17);
            this.rb_Demo.TabIndex = 5;
            this.rb_Demo.TabStop = true;
            this.rb_Demo.Text = "Demo";
            this.rb_Demo.UseVisualStyleBackColor = true;
            // 
            // rb_Manual
            // 
            this.rb_Manual.AutoSize = true;
            this.rb_Manual.Location = new System.Drawing.Point(19, 15);
            this.rb_Manual.Name = "rb_Manual";
            this.rb_Manual.Size = new System.Drawing.Size(60, 17);
            this.rb_Manual.TabIndex = 4;
            this.rb_Manual.TabStop = true;
            this.rb_Manual.Text = "Manual";
            this.rb_Manual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jugadores";
            // 
            // n_nroJugadores
            // 
            this.n_nroJugadores.Location = new System.Drawing.Point(190, 42);
            this.n_nroJugadores.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.n_nroJugadores.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n_nroJugadores.Name = "n_nroJugadores";
            this.n_nroJugadores.Size = new System.Drawing.Size(74, 20);
            this.n_nroJugadores.TabIndex = 2;
            this.n_nroJugadores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // CrearJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 295);
            this.Controls.Add(this.gb_Partida);
            this.Controls.Add(this.b_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_Aceptar);
            this.Name = "CrearJugador";
            this.Text = "Crear Jugador";
            this.Load += new System.EventHandler(this.CrearJugador_Load);
            this.groupBoxTablero.ResumeLayout(false);
            this.groupBoxTablero.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Partida.ResumeLayout(false);
            this.gb_Partida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_nroJugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.GroupBox groupBoxTablero;
        public System.Windows.Forms.RadioButton rb_Experto;
        public System.Windows.Forms.RadioButton rb_Intermedio;
        public System.Windows.Forms.RadioButton rb_Simple;
        private System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.Button b_Aceptar;
        public System.Windows.Forms.Button b_Cancelar;
        private System.Windows.Forms.GroupBox gb_Partida;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown n_nroJugadores;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rb_Demo;
        public System.Windows.Forms.RadioButton rb_Manual;
        public System.Windows.Forms.Button b_Ok;
    }
}