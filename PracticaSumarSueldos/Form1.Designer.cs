
namespace PracticaSumarSueldos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTOnp = new System.Windows.Forms.RadioButton();
            this.RbtAfp = new System.Windows.Forms.RadioButton();
            this.txtcolaborador = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.cbxCondicion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lsbColaboradores = new System.Windows.Forms.ListBox();
            this.lsbCondicion = new System.Windows.Forms.ListBox();
            this.lsbBasico = new System.Windows.Forms.ListBox();
            this.lsbDescuento = new System.Windows.Forms.ListBox();
            this.lsbSueldoNeto = new System.Windows.Forms.ListBox();
            this.lblPlanilla = new System.Windows.Forms.Label();
            this.txtPlanilla = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "REMUNERACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "COLABORADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUELDO BÁSICO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONDICIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtAfp);
            this.groupBox1.Controls.Add(this.rbTOnp);
            this.groupBox1.Location = new System.Drawing.Point(188, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SISTEMA DE PENSIONES";
            // 
            // rbTOnp
            // 
            this.rbTOnp.AutoSize = true;
            this.rbTOnp.Checked = true;
            this.rbTOnp.Location = new System.Drawing.Point(17, 35);
            this.rbTOnp.Name = "rbTOnp";
            this.rbTOnp.Size = new System.Drawing.Size(74, 17);
            this.rbTOnp.TabIndex = 0;
            this.rbTOnp.TabStop = true;
            this.rbTOnp.Text = "ONP(13%)";
            this.rbTOnp.UseVisualStyleBackColor = true;
            // 
            // RbtAfp
            // 
            this.RbtAfp.AutoSize = true;
            this.RbtAfp.Location = new System.Drawing.Point(183, 35);
            this.RbtAfp.Name = "RbtAfp";
            this.RbtAfp.Size = new System.Drawing.Size(71, 17);
            this.RbtAfp.TabIndex = 1;
            this.RbtAfp.Text = "AFP(11%)";
            this.RbtAfp.UseVisualStyleBackColor = true;
            // 
            // txtcolaborador
            // 
            this.txtcolaborador.Location = new System.Drawing.Point(316, 80);
            this.txtcolaborador.Name = "txtcolaborador";
            this.txtcolaborador.Size = new System.Drawing.Size(100, 20);
            this.txtcolaborador.TabIndex = 5;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(210, 125);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 6;
            // 
            // cbxCondicion
            // 
            this.cbxCondicion.FormattingEnabled = true;
            this.cbxCondicion.Location = new System.Drawing.Point(465, 124);
            this.cbxCondicion.Name = "cbxCondicion";
            this.cbxCondicion.Size = new System.Drawing.Size(121, 21);
            this.cbxCondicion.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(152, 255);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 40);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(259, 255);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(185, 40);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "QUITAR DE PLANTILLA";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(484, 255);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 40);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "COLABORADORES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CONDICIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SUELDO BÁSICO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "DESCUENTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "SUELDO NETO";
            // 
            // lsbColaboradores
            // 
            this.lsbColaboradores.FormattingEnabled = true;
            this.lsbColaboradores.Location = new System.Drawing.Point(91, 326);
            this.lsbColaboradores.Name = "lsbColaboradores";
            this.lsbColaboradores.Size = new System.Drawing.Size(100, 108);
            this.lsbColaboradores.TabIndex = 16;
            // 
            // lsbCondicion
            // 
            this.lsbCondicion.Enabled = false;
            this.lsbCondicion.FormattingEnabled = true;
            this.lsbCondicion.Location = new System.Drawing.Point(197, 326);
            this.lsbCondicion.Name = "lsbCondicion";
            this.lsbCondicion.Size = new System.Drawing.Size(100, 108);
            this.lsbCondicion.TabIndex = 17;
            // 
            // lsbBasico
            // 
            this.lsbBasico.Enabled = false;
            this.lsbBasico.FormattingEnabled = true;
            this.lsbBasico.Location = new System.Drawing.Point(303, 326);
            this.lsbBasico.Name = "lsbBasico";
            this.lsbBasico.Size = new System.Drawing.Size(100, 108);
            this.lsbBasico.TabIndex = 18;
            // 
            // lsbDescuento
            // 
            this.lsbDescuento.Enabled = false;
            this.lsbDescuento.FormattingEnabled = true;
            this.lsbDescuento.Location = new System.Drawing.Point(409, 326);
            this.lsbDescuento.Name = "lsbDescuento";
            this.lsbDescuento.Size = new System.Drawing.Size(100, 108);
            this.lsbDescuento.TabIndex = 19;
            // 
            // lsbSueldoNeto
            // 
            this.lsbSueldoNeto.Enabled = false;
            this.lsbSueldoNeto.FormattingEnabled = true;
            this.lsbSueldoNeto.Location = new System.Drawing.Point(515, 326);
            this.lsbSueldoNeto.Name = "lsbSueldoNeto";
            this.lsbSueldoNeto.Size = new System.Drawing.Size(100, 108);
            this.lsbSueldoNeto.TabIndex = 20;
            // 
            // lblPlanilla
            // 
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.Location = new System.Drawing.Point(396, 470);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(113, 13);
            this.lblPlanilla.TabIndex = 21;
            this.lblPlanilla.Text = "TOTAL DE PLANILLA";
            // 
            // txtPlanilla
            // 
            this.txtPlanilla.Location = new System.Drawing.Point(515, 463);
            this.txtPlanilla.Name = "txtPlanilla";
            this.txtPlanilla.Size = new System.Drawing.Size(100, 20);
            this.txtPlanilla.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(723, 544);
            this.Controls.Add(this.txtPlanilla);
            this.Controls.Add(this.lblPlanilla);
            this.Controls.Add(this.lsbSueldoNeto);
            this.Controls.Add(this.lsbDescuento);
            this.Controls.Add(this.lsbBasico);
            this.Controls.Add(this.lsbCondicion);
            this.Controls.Add(this.lsbColaboradores);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxCondicion);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtcolaborador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Formulario remuneraciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtAfp;
        private System.Windows.Forms.RadioButton rbTOnp;
        private System.Windows.Forms.TextBox txtcolaborador;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.ComboBox cbxCondicion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lsbColaboradores;
        private System.Windows.Forms.ListBox lsbCondicion;
        private System.Windows.Forms.ListBox lsbBasico;
        private System.Windows.Forms.ListBox lsbDescuento;
        private System.Windows.Forms.ListBox lsbSueldoNeto;
        private System.Windows.Forms.Label lblPlanilla;
        private System.Windows.Forms.TextBox txtPlanilla;
    }
}

