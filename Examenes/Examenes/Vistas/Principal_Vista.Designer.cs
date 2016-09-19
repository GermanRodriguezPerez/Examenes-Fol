namespace Examenes
{
    partial class Principal_Vista
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Preguntas = new System.Windows.Forms.TabPage();
            this.AñadirPregunta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dificultad = new System.Windows.Forms.ComboBox();
            this.Tema = new System.Windows.Forms.ComboBox();
            this.Asignaturas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ejercicios = new System.Windows.Forms.TabPage();
            this.Examenes = new System.Windows.Forms.TabPage();
            this.Opciones = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Preguntas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Preguntas);
            this.tabControl1.Controls.Add(this.Ejercicios);
            this.tabControl1.Controls.Add(this.Examenes);
            this.tabControl1.Controls.Add(this.Opciones);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 419);
            this.tabControl1.TabIndex = 4;
            // 
            // Preguntas
            // 
            this.Preguntas.Controls.Add(this.AñadirPregunta);
            this.Preguntas.Controls.Add(this.label3);
            this.Preguntas.Controls.Add(this.label2);
            this.Preguntas.Controls.Add(this.label1);
            this.Preguntas.Controls.Add(this.Dificultad);
            this.Preguntas.Controls.Add(this.Tema);
            this.Preguntas.Controls.Add(this.Asignaturas);
            this.Preguntas.Controls.Add(this.dataGridView1);
            this.Preguntas.Location = new System.Drawing.Point(4, 22);
            this.Preguntas.Name = "Preguntas";
            this.Preguntas.Padding = new System.Windows.Forms.Padding(3);
            this.Preguntas.Size = new System.Drawing.Size(627, 393);
            this.Preguntas.TabIndex = 0;
            this.Preguntas.Text = "Preguntas";
            this.Preguntas.UseVisualStyleBackColor = true;
            // 
            // AñadirPregunta
            // 
            this.AñadirPregunta.Location = new System.Drawing.Point(528, 25);
            this.AñadirPregunta.Name = "AñadirPregunta";
            this.AñadirPregunta.Size = new System.Drawing.Size(75, 23);
            this.AñadirPregunta.TabIndex = 5;
            this.AñadirPregunta.Text = "Añadir";
            this.AñadirPregunta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dificultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aisgnatura";
            // 
            // Dificultad
            // 
            this.Dificultad.FormattingEnabled = true;
            this.Dificultad.Location = new System.Drawing.Point(343, 27);
            this.Dificultad.Name = "Dificultad";
            this.Dificultad.Size = new System.Drawing.Size(121, 21);
            this.Dificultad.TabIndex = 3;
            // 
            // Tema
            // 
            this.Tema.FormattingEnabled = true;
            this.Tema.Location = new System.Drawing.Point(184, 27);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(121, 21);
            this.Tema.TabIndex = 2;
            // 
            // Asignaturas
            // 
            this.Asignaturas.FormattingEnabled = true;
            this.Asignaturas.Location = new System.Drawing.Point(17, 27);
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.Size = new System.Drawing.Size(121, 21);
            this.Asignaturas.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ejercicios
            // 
            this.Ejercicios.Location = new System.Drawing.Point(4, 22);
            this.Ejercicios.Name = "Ejercicios";
            this.Ejercicios.Padding = new System.Windows.Forms.Padding(3);
            this.Ejercicios.Size = new System.Drawing.Size(627, 393);
            this.Ejercicios.TabIndex = 1;
            this.Ejercicios.Text = "Ejercicios";
            this.Ejercicios.UseVisualStyleBackColor = true;
            // 
            // Examenes
            // 
            this.Examenes.Location = new System.Drawing.Point(4, 22);
            this.Examenes.Name = "Examenes";
            this.Examenes.Size = new System.Drawing.Size(627, 393);
            this.Examenes.TabIndex = 2;
            this.Examenes.Text = "Exámenes";
            this.Examenes.UseVisualStyleBackColor = true;
            // 
            // Opciones
            // 
            this.Opciones.Location = new System.Drawing.Point(4, 22);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(627, 393);
            this.Opciones.TabIndex = 3;
            this.Opciones.Text = "Opciones";
            this.Opciones.UseVisualStyleBackColor = true;
            // 
            // Principal_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal_Vista";
            this.Text = "Principal";
            this.tabControl1.ResumeLayout(false);
            this.Preguntas.ResumeLayout(false);
            this.Preguntas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Preguntas;
        private System.Windows.Forms.TabPage Ejercicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Examenes;
        private System.Windows.Forms.TabPage Opciones;
        public System.Windows.Forms.ComboBox Dificultad;
        public System.Windows.Forms.ComboBox Tema;
        public System.Windows.Forms.ComboBox Asignaturas;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button AñadirPregunta;
    }
}

