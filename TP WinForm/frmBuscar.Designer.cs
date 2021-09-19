
namespace TP_WinForm
{
    partial class frmBuscar
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
            this.BtnID = new System.Windows.Forms.Button();
            this.BtnCodigo = new System.Windows.Forms.Button();
            this.BtnNombre = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.TxtIdBuscar = new System.Windows.Forms.TextBox();
            this.TxtCodigoBuscar = new System.Windows.Forms.TextBox();
            this.TxtNombreBuscar = new System.Windows.Forms.TextBox();
            this.pcbBucar = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBucar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnID
            // 
            this.BtnID.Location = new System.Drawing.Point(12, 304);
            this.BtnID.Name = "BtnID";
            this.BtnID.Size = new System.Drawing.Size(133, 23);
            this.BtnID.TabIndex = 0;
            this.BtnID.Text = "ID";
            this.BtnID.UseVisualStyleBackColor = true;
            this.BtnID.Click += new System.EventHandler(this.BtnID_Click);
            // 
            // BtnCodigo
            // 
            this.BtnCodigo.Location = new System.Drawing.Point(12, 369);
            this.BtnCodigo.Name = "BtnCodigo";
            this.BtnCodigo.Size = new System.Drawing.Size(133, 23);
            this.BtnCodigo.TabIndex = 1;
            this.BtnCodigo.Text = "Codigo";
            this.BtnCodigo.UseVisualStyleBackColor = true;
            this.BtnCodigo.Click += new System.EventHandler(this.BtnCodigo_Click);
            // 
            // BtnNombre
            // 
            this.BtnNombre.Location = new System.Drawing.Point(12, 439);
            this.BtnNombre.Name = "BtnNombre";
            this.BtnNombre.Size = new System.Drawing.Size(133, 23);
            this.BtnNombre.TabIndex = 2;
            this.BtnNombre.Text = "Nombre";
            this.BtnNombre.UseVisualStyleBackColor = true;
            this.BtnNombre.Click += new System.EventHandler(this.BtnNombre_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(12, 12);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(540, 201);
            this.dgvBuscar.TabIndex = 3;
            // 
            // TxtIdBuscar
            // 
            this.TxtIdBuscar.Location = new System.Drawing.Point(12, 278);
            this.TxtIdBuscar.Name = "TxtIdBuscar";
            this.TxtIdBuscar.Size = new System.Drawing.Size(133, 20);
            this.TxtIdBuscar.TabIndex = 4;
            // 
            // TxtCodigoBuscar
            // 
            this.TxtCodigoBuscar.Location = new System.Drawing.Point(12, 343);
            this.TxtCodigoBuscar.Name = "TxtCodigoBuscar";
            this.TxtCodigoBuscar.Size = new System.Drawing.Size(133, 20);
            this.TxtCodigoBuscar.TabIndex = 5;
            // 
            // TxtNombreBuscar
            // 
            this.TxtNombreBuscar.Location = new System.Drawing.Point(12, 410);
            this.TxtNombreBuscar.Name = "TxtNombreBuscar";
            this.TxtNombreBuscar.Size = new System.Drawing.Size(133, 20);
            this.TxtNombreBuscar.TabIndex = 6;
            // 
            // pcbBucar
            // 
            this.pcbBucar.Location = new System.Drawing.Point(558, 12);
            this.pcbBucar.Name = "pcbBucar";
            this.pcbBucar.Size = new System.Drawing.Size(249, 257);
            this.pcbBucar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBucar.TabIndex = 7;
            this.pcbBucar.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(699, 428);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 34);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(819, 473);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.pcbBucar);
            this.Controls.Add(this.TxtNombreBuscar);
            this.Controls.Add(this.TxtCodigoBuscar);
            this.Controls.Add(this.TxtIdBuscar);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.BtnNombre);
            this.Controls.Add(this.BtnCodigo);
            this.Controls.Add(this.BtnID);
            this.Name = "frmBuscar";
            this.Text = "Buscador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBucar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnID;
        private System.Windows.Forms.Button BtnCodigo;
        private System.Windows.Forms.Button BtnNombre;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.TextBox TxtIdBuscar;
        private System.Windows.Forms.TextBox TxtCodigoBuscar;
        private System.Windows.Forms.TextBox TxtNombreBuscar;
        private System.Windows.Forms.PictureBox pcbBucar;
        private System.Windows.Forms.Button BtnSalir;
    }
}