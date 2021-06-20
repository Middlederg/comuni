namespace Comuni.Forms.UserControls
{
    partial class UcEdificio
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
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.Pbx = new FontAwesome.Sharp.IconPictureBox();
            this.TlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Controls.Add(this.LblNombre, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblNumero, 0, 0);
            this.TlpPrincipal.Controls.Add(this.Pbx, 1, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(2, 2);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Size = new System.Drawing.Size(96, 61);
            this.TlpPrincipal.TabIndex = 0;
            this.TlpPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.TlpPrincipal.SetColumnSpan(this.LblNombre, 2);
            this.LblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNombre.Font = new System.Drawing.Font("Rubik", 9F);
            this.LblNombre.Location = new System.Drawing.Point(0, 30);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(96, 31);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre edificio";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNumero.Font = new System.Drawing.Font("Rubik", 14F);
            this.LblNumero.Location = new System.Drawing.Point(0, 0);
            this.LblNumero.Margin = new System.Windows.Forms.Padding(0);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(48, 30);
            this.LblNumero.TabIndex = 4;
            this.LblNumero.Text = "2";
            this.LblNumero.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LblNumero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // Pbx
            // 
            this.Pbx.BackColor = System.Drawing.Color.Transparent;
            this.Pbx.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pbx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pbx.IconColor = System.Drawing.SystemColors.ControlText;
            this.Pbx.IconSize = 29;
            this.Pbx.Location = new System.Drawing.Point(48, 0);
            this.Pbx.Margin = new System.Windows.Forms.Padding(0);
            this.Pbx.Name = "Pbx";
            this.Pbx.Size = new System.Drawing.Size(29, 30);
            this.Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx.TabIndex = 5;
            this.Pbx.TabStop = false;
            this.Pbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // UcEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcEdificio";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(100, 65);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.Label LblNumero;
        private FontAwesome.Sharp.IconPictureBox Pbx;
        private System.Windows.Forms.Label LblNombre;
    }
}
