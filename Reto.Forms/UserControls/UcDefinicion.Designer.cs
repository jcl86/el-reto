namespace Reto.Forms.UserControls
{
    partial class UcDefinicion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.LblDefinicion = new Reto.Forms.CustomControls.CustomLabel();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.LblDefinicion);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.pPrincipal.Size = new System.Drawing.Size(277, 247);
            this.pPrincipal.TabIndex = 0;
            // 
            // LblDefinicion
            // 
            this.LblDefinicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDefinicion.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefinicion.Location = new System.Drawing.Point(10, 10);
            this.LblDefinicion.Margin = new System.Windows.Forms.Padding(0);
            this.LblDefinicion.Name = "LblDefinicion";
            this.LblDefinicion.Size = new System.Drawing.Size(255, 225);
            this.LblDefinicion.TabIndex = 0;
            this.LblDefinicion.Text = "Definición";
            this.LblDefinicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcDefinicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcDefinicion";
            this.Size = new System.Drawing.Size(277, 247);
            this.pPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private CustomControls.CustomLabel LblDefinicion;
    }
}
