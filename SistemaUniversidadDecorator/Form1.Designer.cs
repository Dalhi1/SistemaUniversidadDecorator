namespace SistemaUniversidadDecorator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFisica = new System.Windows.Forms.CheckBox();
            this.chkCalculo = new System.Windows.Forms.CheckBox();
            this.chkProgramacion = new System.Windows.Forms.CheckBox();
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.chkTutoria = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCarrera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona una carrera:";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(9, 61);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(121, 24);
            this.cmbCarrera.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTutoria);
            this.groupBox2.Controls.Add(this.chkProgramacion);
            this.groupBox2.Controls.Add(this.chkIngles);
            this.groupBox2.Controls.Add(this.chkCalculo);
            this.groupBox2.Controls.Add(this.chkFisica);
            this.groupBox2.Location = new System.Drawing.Point(233, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materias";
            // 
            // chkFisica
            // 
            this.chkFisica.AutoSize = true;
            this.chkFisica.Location = new System.Drawing.Point(6, 31);
            this.chkFisica.Name = "chkFisica";
            this.chkFisica.Size = new System.Drawing.Size(65, 20);
            this.chkFisica.TabIndex = 2;
            this.chkFisica.Text = "Física";
            this.chkFisica.UseVisualStyleBackColor = true;
            // 
            // chkCalculo
            // 
            this.chkCalculo.AutoSize = true;
            this.chkCalculo.Location = new System.Drawing.Point(6, 57);
            this.chkCalculo.Name = "chkCalculo";
            this.chkCalculo.Size = new System.Drawing.Size(74, 20);
            this.chkCalculo.TabIndex = 3;
            this.chkCalculo.Text = "Cálculo";
            this.chkCalculo.UseVisualStyleBackColor = true;
            // 
            // chkProgramacion
            // 
            this.chkProgramacion.AutoSize = true;
            this.chkProgramacion.Location = new System.Drawing.Point(6, 83);
            this.chkProgramacion.Name = "chkProgramacion";
            this.chkProgramacion.Size = new System.Drawing.Size(114, 20);
            this.chkProgramacion.TabIndex = 4;
            this.chkProgramacion.Text = "Programación";
            this.chkProgramacion.UseVisualStyleBackColor = true;
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(6, 109);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(65, 20);
            this.chkIngles.TabIndex = 2;
            this.chkIngles.Text = "Inglés";
            this.chkIngles.UseVisualStyleBackColor = true;
            // 
            // chkTutoria
            // 
            this.chkTutoria.AutoSize = true;
            this.chkTutoria.Location = new System.Drawing.Point(6, 135);
            this.chkTutoria.Name = "chkTutoria";
            this.chkTutoria.Size = new System.Drawing.Size(71, 20);
            this.chkTutoria.TabIndex = 3;
            this.chkTutoria.Text = "Tutoría";
            this.chkTutoria.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(131, 215);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(327, 53);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Plan";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResultado);
            this.groupBox3.Location = new System.Drawing.Point(21, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 21);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(501, 140);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(582, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema de Administración Universitaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkProgramacion;
        private System.Windows.Forms.CheckBox chkCalculo;
        private System.Windows.Forms.CheckBox chkFisica;
        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.CheckBox chkTutoria;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtResultado;
    }
}

