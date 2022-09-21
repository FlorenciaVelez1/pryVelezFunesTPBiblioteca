namespace pryVelezFunesTPBiblioteca
{
    partial class frmBiblioteca
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
            this.listLibros = new System.Windows.Forms.ListBox();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLibros
            // 
            this.listLibros.FormattingEnabled = true;
            this.listLibros.ItemHeight = 16;
            this.listLibros.Items.AddRange(new object[] {
            "Código\tLibro\tCódigo Editorial\tCódigo Autor\tCódigo Distribuidor"});
            this.listLibros.Location = new System.Drawing.Point(12, 12);
            this.listLibros.Name = "listLibros";
            this.listLibros.Size = new System.Drawing.Size(542, 228);
            this.listLibros.TabIndex = 0;
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnterior.Location = new System.Drawing.Point(12, 246);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(87, 34);
            this.cmdAnterior.TabIndex = 1;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSiguiente.Location = new System.Drawing.Point(467, 246);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(87, 34);
            this.cmdSiguiente.TabIndex = 2;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 292);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.listLibros);
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLibros;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdSiguiente;
    }
}

