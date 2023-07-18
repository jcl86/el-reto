namespace Reto.Forms.UserControls
{
    partial class UcInicial
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
            this.LblInicial = new Reto.Forms.CustomControls.CustomLabel();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PbxIcon = new FontAwesome.Sharp.IconPictureBox();
            this.TlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // customLabel1
            // 
            this.LblInicial.AutoSize = true;
            this.LblInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblInicial.Font = new System.Drawing.Font("Liberation Sans", 30F, System.Drawing.FontStyle.Bold);
            this.LblInicial.Location = new System.Drawing.Point(43, 0);
            this.LblInicial.Name = "customLabel1";
            this.LblInicial.Size = new System.Drawing.Size(132, 58);
            this.LblInicial.TabIndex = 0;
            this.LblInicial.Text = "ABC";
            this.LblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.LblInicial, 1, 0);
            this.TlpPrincipal.Controls.Add(this.PbxIcon, 0, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Size = new System.Drawing.Size(178, 58);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // PbxIcon
            // 
            this.PbxIcon.BackColor = System.Drawing.SystemColors.Control;
            this.PbxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PbxIcon.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.PbxIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.PbxIcon.IconSize = 40;
            this.PbxIcon.Location = new System.Drawing.Point(0, 0);
            this.PbxIcon.Margin = new System.Windows.Forms.Padding(0);
            this.PbxIcon.Name = "PbxIcon";
            this.PbxIcon.Size = new System.Drawing.Size(40, 58);
            this.PbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxIcon.TabIndex = 1;
            this.PbxIcon.TabStop = false;
            // 
            // UcInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcInicial";
            this.Size = new System.Drawing.Size(178, 58);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomLabel LblInicial;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private FontAwesome.Sharp.IconPictureBox PbxIcon;
    }
}
