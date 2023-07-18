namespace Reto.Forms.Views
{
    partial class FrmPrincipal
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
            this.Tbx = new Reto.Forms.CustomControls.CustomTextBox();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.Definicion = new Reto.Forms.UserControls.UcDefinicion();
            this.FlpIniciales = new System.Windows.Forms.FlowLayoutPanel();
            this.ucInicial1 = new Reto.Forms.UserControls.UcInicial();
            this.ucInicial2 = new Reto.Forms.UserControls.UcInicial();
            this.ucInicial3 = new Reto.Forms.UserControls.UcInicial();
            this.ucInicial4 = new Reto.Forms.UserControls.UcInicial();
            this.ucInicial5 = new Reto.Forms.UserControls.UcInicial();
            this.ucInicial6 = new Reto.Forms.UserControls.UcInicial();
            this.ucTiempo1 = new Reto.Forms.UserControls.UcTiempo();
            this.TlpPrincipal.SuspendLayout();
            this.FlpIniciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbx
            // 
            this.Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx.Font = new System.Drawing.Font("Liberation Sans", 35F);
            this.Tbx.Location = new System.Drawing.Point(30, 452);
            this.Tbx.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Tbx.Name = "Tbx";
            this.Tbx.Size = new System.Drawing.Size(536, 61);
            this.Tbx.TabIndex = 0;
            this.Tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxKeyDown);
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.Controls.Add(this.Tbx, 0, 1);
            this.TlpPrincipal.Controls.Add(this.Definicion, 0, 0);
            this.TlpPrincipal.Controls.Add(this.FlpIniciales, 1, 0);
            this.TlpPrincipal.Controls.Add(this.ucTiempo1, 1, 1);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(20);
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpPrincipal.Size = new System.Drawing.Size(774, 533);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // Definicion
            // 
            this.Definicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Definicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Definicion.Fondo = null;
            this.Definicion.Location = new System.Drawing.Point(30, 20);
            this.Definicion.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Definicion.Name = "Definicion";
            this.Definicion.Size = new System.Drawing.Size(536, 403);
            this.Definicion.TabIndex = 2;
            this.Definicion.Titulo = "Definición";
            // 
            // FlpIniciales
            // 
            this.FlpIniciales.Controls.Add(this.ucInicial1);
            this.FlpIniciales.Controls.Add(this.ucInicial2);
            this.FlpIniciales.Controls.Add(this.ucInicial3);
            this.FlpIniciales.Controls.Add(this.ucInicial4);
            this.FlpIniciales.Controls.Add(this.ucInicial5);
            this.FlpIniciales.Controls.Add(this.ucInicial6);
            this.FlpIniciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpIniciales.Location = new System.Drawing.Point(576, 20);
            this.FlpIniciales.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.FlpIniciales.Name = "FlpIniciales";
            this.FlpIniciales.Size = new System.Drawing.Size(178, 403);
            this.FlpIniciales.TabIndex = 3;
            // 
            // ucInicial1
            // 
            this.ucInicial1.Acertado = false;
            this.ucInicial1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucInicial1.Location = new System.Drawing.Point(0, 0);
            this.ucInicial1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ucInicial1.Name = "ucInicial1";
            this.ucInicial1.Size = new System.Drawing.Size(178, 58);
            this.ucInicial1.TabIndex = 0;
            // 
            // ucInicial2
            // 
            this.ucInicial2.Acertado = false;
            this.ucInicial2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucInicial2.Location = new System.Drawing.Point(0, 68);
            this.ucInicial2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ucInicial2.Name = "ucInicial2";
            this.ucInicial2.Size = new System.Drawing.Size(178, 58);
            this.ucInicial2.TabIndex = 1;
            // 
            // ucInicial3
            // 
            this.ucInicial3.Acertado = false;
            this.ucInicial3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucInicial3.Location = new System.Drawing.Point(0, 136);
            this.ucInicial3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ucInicial3.Name = "ucInicial3";
            this.ucInicial3.Size = new System.Drawing.Size(178, 58);
            this.ucInicial3.TabIndex = 2;
            // 
            // ucInicial4
            // 
            this.ucInicial4.Acertado = false;
            this.ucInicial4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucInicial4.Location = new System.Drawing.Point(0, 204);
            this.ucInicial4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ucInicial4.Name = "ucInicial4";
            this.ucInicial4.Size = new System.Drawing.Size(178, 58);
            this.ucInicial4.TabIndex = 3;
            // 
            // ucInicial5
            // 
            this.ucInicial5.Acertado = false;
            this.ucInicial5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucInicial5.Location = new System.Drawing.Point(0, 272);
            this.ucInicial5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ucInicial5.Name = "ucInicial5";
            this.ucInicial5.Size = new System.Drawing.Size(178, 58);
            this.ucInicial5.TabIndex = 4;
            // 
            // ucInicial6
            // 
            this.ucInicial6.Acertado = false;
            this.ucInicial6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucInicial6.Location = new System.Drawing.Point(0, 340);
            this.ucInicial6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ucInicial6.Name = "ucInicial6";
            this.ucInicial6.Size = new System.Drawing.Size(178, 58);
            this.ucInicial6.TabIndex = 5;
            // 
            // ucTiempo1
            // 
            this.ucTiempo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTiempo1.Location = new System.Drawing.Point(675, 452);
            this.ucTiempo1.Margin = new System.Windows.Forms.Padding(0);
            this.ucTiempo1.Name = "ucTiempo1";
            this.ucTiempo1.Size = new System.Drawing.Size(79, 61);
            this.ucTiempo1.TabIndex = 1;
            this.ucTiempo1.TiempoFinalizado = null;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 533);
            this.Controls.Add(this.TlpPrincipal);
            this.KeyPreview = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.FlpIniciales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomTextBox Tbx;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UserControls.UcTiempo ucTiempo1;
        private UserControls.UcDefinicion Definicion;
        private System.Windows.Forms.FlowLayoutPanel FlpIniciales;
        private UserControls.UcInicial ucInicial1;
        private UserControls.UcInicial ucInicial2;
        private UserControls.UcInicial ucInicial3;
        private UserControls.UcInicial ucInicial4;
        private UserControls.UcInicial ucInicial5;
        private UserControls.UcInicial ucInicial6;
    }
}