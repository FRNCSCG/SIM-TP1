namespace SIM_TP1
{
    partial class Main
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
            this.btnMixto = new System.Windows.Forms.RadioButton();
            this.btnMultiplicativo = new System.Windows.Forms.RadioButton();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.labbb = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgTabla = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMixto
            // 
            this.btnMixto.AutoSize = true;
            this.btnMixto.Location = new System.Drawing.Point(23, 21);
            this.btnMixto.Name = "btnMixto";
            this.btnMixto.Size = new System.Drawing.Size(50, 17);
            this.btnMixto.TabIndex = 0;
            this.btnMixto.TabStop = true;
            this.btnMixto.Text = "Mixto";
            this.btnMixto.UseVisualStyleBackColor = true;
            this.btnMixto.CheckedChanged += new System.EventHandler(this.btnMixto_CheckedChanged);
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.AutoSize = true;
            this.btnMultiplicativo.Location = new System.Drawing.Point(102, 21);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(86, 17);
            this.btnMultiplicativo.TabIndex = 1;
            this.btnMultiplicativo.TabStop = true;
            this.btnMultiplicativo.Text = "Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.CheckedChanged += new System.EventHandler(this.btnMultiplicativo_CheckedChanged);
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(247, 20);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(36, 20);
            this.txtX0.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(637, 20);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(36, 20);
            this.txtA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "c";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(541, 21);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(36, 20);
            this.txtC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "m";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(725, 20);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(36, 20);
            this.txtM.TabIndex = 8;
            // 
            // labbb
            // 
            this.labbb.AutoSize = true;
            this.labbb.Location = new System.Drawing.Point(322, 23);
            this.labbb.Name = "labbb";
            this.labbb.Size = new System.Drawing.Size(13, 13);
            this.labbb.TabIndex = 11;
            this.labbb.Text = "k";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(341, 20);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(36, 20);
            this.txtK.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "g";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(436, 20);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(36, 20);
            this.txtG.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 61);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(210, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 61);
            this.panel2.TabIndex = 15;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(210, 66);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(91, 23);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // dgTabla
            // 
            this.dgTabla.AllowUserToAddRows = false;
            this.dgTabla.AllowUserToDeleteRows = false;
            this.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Rand});
            this.dgTabla.Location = new System.Drawing.Point(12, 95);
            this.dgTabla.Name = "dgTabla";
            this.dgTabla.Size = new System.Drawing.Size(649, 343);
            this.dgTabla.TabIndex = 17;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.Name = "Iteracion";
            // 
            // Rand
            // 
            this.Rand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rand.HeaderText = "Rand";
            this.Rand.Name = "Rand";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(698, 415);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 18;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(325, 66);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 23);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dgTabla);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.labbb);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.btnMultiplicativo);
            this.Controls.Add(this.btnMixto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Main";
            this.Text = "Generador";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnMixto;
        private System.Windows.Forms.RadioButton btnMultiplicativo;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label labbb;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rand;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnBorrar;
    }
}