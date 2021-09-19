
namespace TP_WinForm
{
    partial class frmBorrar
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtborrar = new System.Windows.Forms.TextBox();
            this.labelborrar = new System.Windows.Forms.Label();
            this.labelBorrarSeguro = new System.Windows.Forms.Label();
            this.dgvBorrar = new System.Windows.Forms.DataGridView();
            this.PcbBorrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(206, 224);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(86, 22);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(387, 223);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 23);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtborrar
            // 
            this.txtborrar.Location = new System.Drawing.Point(12, 226);
            this.txtborrar.Name = "txtborrar";
            this.txtborrar.Size = new System.Drawing.Size(188, 20);
            this.txtborrar.TabIndex = 2;
            // 
            // labelborrar
            // 
            this.labelborrar.BackColor = System.Drawing.Color.Peru;
            this.labelborrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelborrar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelborrar.Location = new System.Drawing.Point(12, 176);
            this.labelborrar.Name = "labelborrar";
            this.labelborrar.Size = new System.Drawing.Size(613, 30);
            this.labelborrar.TabIndex = 3;
            this.labelborrar.Text = "Para Confirmar la Eliminacion del Articulo escriba, \" ELIMINAR \" y luego de en Ac" +
    "eptar";
            // 
            // labelBorrarSeguro
            // 
            this.labelBorrarSeguro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarSeguro.Location = new System.Drawing.Point(9, 27);
            this.labelBorrarSeguro.Name = "labelBorrarSeguro";
            this.labelBorrarSeguro.Size = new System.Drawing.Size(383, 27);
            this.labelBorrarSeguro.TabIndex = 4;
            this.labelBorrarSeguro.Text = "¿ Esta Seguro de Eliminar el Articulo ?";
            this.labelBorrarSeguro.Click += new System.EventHandler(this.labelBorrarSeguro_Click);
            // 
            // dgvBorrar
            // 
            this.dgvBorrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrar.Location = new System.Drawing.Point(12, 51);
            this.dgvBorrar.Name = "dgvBorrar";
            this.dgvBorrar.Size = new System.Drawing.Size(594, 102);
            this.dgvBorrar.TabIndex = 5;
            // 
            // PcbBorrar
            // 
            this.PcbBorrar.Location = new System.Drawing.Point(631, 12);
            this.PcbBorrar.Name = "PcbBorrar";
            this.PcbBorrar.Size = new System.Drawing.Size(267, 258);
            this.PcbBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBorrar.TabIndex = 6;
            this.PcbBorrar.TabStop = false;
            this.PcbBorrar.Click += new System.EventHandler(this.PcbBorrar_Click);
            // 
            // frmBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(910, 282);
            this.Controls.Add(this.PcbBorrar);
            this.Controls.Add(this.dgvBorrar);
            this.Controls.Add(this.labelBorrarSeguro);
            this.Controls.Add(this.labelborrar);
            this.Controls.Add(this.txtborrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "frmBorrar";
            this.Text = "Borrar";
            this.Load += new System.EventHandler(this.frmBorrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtborrar;
        private System.Windows.Forms.Label labelborrar;
        private System.Windows.Forms.Label labelBorrarSeguro;
        private System.Windows.Forms.DataGridView dgvBorrar;
        private System.Windows.Forms.PictureBox PcbBorrar;
    }
}