
namespace PedidosApp
{
    partial class HistorialPedidos
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cmbTipoEntrega = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(22, 12);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(456, 150);
            this.dgvHistorial.TabIndex = 0;
            // 
            // cmbTipoEntrega
            // 
            this.cmbTipoEntrega.FormattingEnabled = true;
            this.cmbTipoEntrega.Location = new System.Drawing.Point(22, 187);
            this.cmbTipoEntrega.Name = "cmbTipoEntrega";
            this.cmbTipoEntrega.Size = new System.Drawing.Size(213, 21);
            this.cmbTipoEntrega.TabIndex = 1;
            // 
            // HistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 254);
            this.Controls.Add(this.cmbTipoEntrega);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "HistorialPedidos";
            this.Text = "HistorialPedidos";
            this.Load += new System.EventHandler(this.HistorialPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ComboBox cmbTipoEntrega;
    }
}