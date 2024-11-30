namespace programa_1
{
    partial class ProcesamientoPorLotes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NumProc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonGen = new System.Windows.Forms.Button();
            this.Ejecutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Terminados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EnEspera = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Seg = new System.Windows.Forms.TextBox();
            this.Ghost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# procesos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumProc
            // 
            this.NumProc.Location = new System.Drawing.Point(96, 40);
            this.NumProc.Name = "NumProc";
            this.NumProc.Size = new System.Drawing.Size(100, 20);
            this.NumProc.TabIndex = 1;
            this.NumProc.TextChanged += new System.EventHandler(this.NumProc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EN ESPERA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "# de lotes pendientes:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 378);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonGen
            // 
            this.ButtonGen.Location = new System.Drawing.Point(216, 38);
            this.ButtonGen.Name = "ButtonGen";
            this.ButtonGen.Size = new System.Drawing.Size(75, 23);
            this.ButtonGen.TabIndex = 6;
            this.ButtonGen.Text = "Generar";
            this.ButtonGen.UseVisualStyleBackColor = true;
            this.ButtonGen.Click += new System.EventHandler(this.ButtonGen_Click);
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(274, 149);
            this.Ejecutar.Multiline = true;
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.ReadOnly = true;
            this.Ejecutar.Size = new System.Drawing.Size(178, 96);
            this.Ejecutar.TabIndex = 7;
            this.Ejecutar.TextChanged += new System.EventHandler(this.Ejecutar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "EJECUCION";
            // 
            // Terminados
            // 
            this.Terminados.Location = new System.Drawing.Point(539, 82);
            this.Terminados.Multiline = true;
            this.Terminados.Name = "Terminados";
            this.Terminados.ReadOnly = true;
            this.Terminados.Size = new System.Drawing.Size(166, 280);
            this.Terminados.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TERMINADOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reloj Global:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Resultados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnEspera
            // 
            this.EnEspera.Location = new System.Drawing.Point(30, 82);
            this.EnEspera.Multiline = true;
            this.EnEspera.Name = "EnEspera";
            this.EnEspera.ReadOnly = true;
            this.EnEspera.Size = new System.Drawing.Size(166, 280);
            this.EnEspera.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Seg
            // 
            this.Seg.Location = new System.Drawing.Point(577, 6);
            this.Seg.Name = "Seg";
            this.Seg.ReadOnly = true;
            this.Seg.Size = new System.Drawing.Size(32, 20);
            this.Seg.TabIndex = 14;
            // 
            // Ghost
            // 
            this.Ghost.Location = new System.Drawing.Point(274, 268);
            this.Ghost.Multiline = true;
            this.Ghost.Name = "Ghost";
            this.Ghost.ReadOnly = true;
            this.Ghost.Size = new System.Drawing.Size(178, 106);
            this.Ghost.TabIndex = 15;
            this.Ghost.Visible = false;
            // 
            // ProcesamientoPorLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.Seg);
            this.Controls.Add(this.EnEspera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Terminados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ejecutar);
            this.Controls.Add(this.ButtonGen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumProc);
            this.Controls.Add(this.label1);
            this.Name = "ProcesamientoPorLotes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumProc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonGen;
        private System.Windows.Forms.TextBox Ejecutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Terminados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EnEspera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Seg;
        private System.Windows.Forms.TextBox Ghost;
    }
}

