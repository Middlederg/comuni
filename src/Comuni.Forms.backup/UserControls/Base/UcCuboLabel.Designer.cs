namespace Comuni.Forms.UserControls
{
    partial class UcCuboLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCuboLabel));
            this.CuboInterior = new Comuni.Forms.CustomControls.Cubo();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblText = new System.Windows.Forms.Label();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // CuboInterior
            // 
            this.CuboInterior.BackColor = System.Drawing.Color.Transparent;
            this.CuboInterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CuboInterior.BackgroundImage")));
            this.CuboInterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CuboInterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuboInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuboInterior.Location = new System.Drawing.Point(24, 4);
            this.CuboInterior.Margin = new System.Windows.Forms.Padding(4);
            this.CuboInterior.Name = "CuboInterior";
            this.CuboInterior.Size = new System.Drawing.Size(22, 22);
            this.CuboInterior.TabIndex = 0;
            this.CuboInterior.Tipo = Comuni.Core.Model.ResourceType.Any;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.Controls.Add(this.CuboInterior, 1, 0);
            this.TlpPrincipal.Controls.Add(this.LblText, 0, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.Size = new System.Drawing.Size(50, 30);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblText.Font = new System.Drawing.Font("Rubik", 12F);
            this.LblText.Location = new System.Drawing.Point(0, 0);
            this.LblText.Margin = new System.Windows.Forms.Padding(0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(20, 30);
            this.LblText.TabIndex = 3;
            this.LblText.Text = "2";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UcCuboLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcCuboLabel";
            this.Size = new System.Drawing.Size(50, 30);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Cubo CuboInterior;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.Label LblText;
    }
}
