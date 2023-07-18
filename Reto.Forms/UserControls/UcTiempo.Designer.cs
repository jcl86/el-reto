namespace Reto.Forms.UserControls
{
    partial class UcTiempo
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
            this.components = new System.ComponentModel.Container();
            this.LblSegundos = new Reto.Forms.CustomControls.CustomLabel();
            this.timerSegundos = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblSegundos
            // 
            this.LblSegundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSegundos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSegundos.Font = new System.Drawing.Font("Liberation Mono", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSegundos.Location = new System.Drawing.Point(0, 0);
            this.LblSegundos.Name = "LblSegundos";
            this.LblSegundos.Size = new System.Drawing.Size(60, 40);
            this.LblSegundos.TabIndex = 0;
            this.LblSegundos.Text = "50";
            this.LblSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSegundos
            // 
            this.timerSegundos.Interval = 1000;
            this.timerSegundos.Tick += new System.EventHandler(this.TimerSegundosTick);
            // 
            // UcTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblSegundos);
            this.Name = "UcTiempo";
            this.Size = new System.Drawing.Size(60, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomLabel LblSegundos;
        private System.Windows.Forms.Timer timerSegundos;
    }
}
