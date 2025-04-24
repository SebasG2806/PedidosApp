
namespace PedidosApp
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.nupPeso = new System.Windows.Forms.NumericUpDown();
            this.nupDistancia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO PRODUCTO:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(156, 30);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(188, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(156, 83);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(188, 21);
            this.cmbProducto.TabIndex = 3;
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(156, 238);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(79, 17);
            this.chkUrgente.TabIndex = 4;
            this.chkUrgente.Text = "URGENTE";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // nupPeso
            // 
            this.nupPeso.Location = new System.Drawing.Point(156, 138);
            this.nupPeso.Name = "nupPeso";
            this.nupPeso.Size = new System.Drawing.Size(188, 20);
            this.nupPeso.TabIndex = 5;
            // 
            // nupDistancia
            // 
            this.nupDistancia.Location = new System.Drawing.Point(156, 185);
            this.nupDistancia.Name = "nupDistancia";
            this.nupDistancia.Size = new System.Drawing.Size(188, 20);
            this.nupDistancia.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PESO PRODUCTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DISTANCIA RECORRIDA:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(403, 33);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(2, 15);
            this.lblResultado.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(118, 289);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 60);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(561, 325);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 371);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupDistancia);
            this.Controls.Add(this.nupPeso);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.NumericUpDown nupPeso;
        private System.Windows.Forms.NumericUpDown nupDistancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCerrar;
    }
}

