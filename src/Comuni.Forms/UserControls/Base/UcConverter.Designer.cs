namespace Comuni.Forms.UserControls
{
    partial class UcConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcConverter));
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.CuboLabel = new Comuni.Forms.UserControls.UcCuboLabel();
            this.Btn = new Comuni.Forms.CustomControls.CustomIconButton();
            this.CuboDestino = new Comuni.Forms.CustomControls.Cubo();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 3;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TlpPrincipal.Controls.Add(this.CuboLabel, 0, 0);
            this.TlpPrincipal.Controls.Add(this.Btn, 1, 0);
            this.TlpPrincipal.Controls.Add(this.CuboDestino, 2, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.Size = new System.Drawing.Size(116, 35);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // CuboLabel
            // 
            this.CuboLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CuboLabel.BackColor = System.Drawing.Color.White;
            this.CuboLabel.Cantidad = 2;
            this.CuboLabel.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuboLabel.Location = new System.Drawing.Point(0, 2);
            this.CuboLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CuboLabel.Name = "CuboLabel";
            this.CuboLabel.Size = new System.Drawing.Size(50, 30);
            this.CuboLabel.TabIndex = 0;
            this.CuboLabel.Tipo = Comuni.Core.Model.TipoRecurso.Any;
            // 
            // Btn
            // 
            this.Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn.BackColor = System.Drawing.Color.Transparent;
            this.Btn.FlatAppearance.BorderSize = 0;
            this.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.Btn.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.Btn.IconColor = System.Drawing.Color.Black;
            this.Btn.IconSize = 30;
            this.Btn.Location = new System.Drawing.Point(52, 2);
            this.Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Btn.Name = "Btn";
            this.Btn.Rotation = 0D;
            this.Btn.Size = new System.Drawing.Size(30, 30);
            this.Btn.TabIndex = 2;
            this.Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn.UseVisualStyleBackColor = false;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // CuboDestino
            // 
            this.CuboDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CuboDestino.BackColor = System.Drawing.Color.Transparent;
            this.CuboDestino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CuboDestino.BackgroundImage")));
            this.CuboDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CuboDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CuboDestino.Location = new System.Drawing.Point(89, 6);
            this.CuboDestino.Margin = new System.Windows.Forms.Padding(0);
            this.CuboDestino.Name = "CuboDestino";
            this.CuboDestino.Size = new System.Drawing.Size(22, 22);
            this.CuboDestino.TabIndex = 3;
            this.CuboDestino.Tipo = Comuni.Core.Model.TipoRecurso.Any;
            // 
            // UcConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcConverter";
            this.Size = new System.Drawing.Size(116, 35);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UcCuboLabel CuboLabel;
        private CustomControls.CustomIconButton Btn;
        private CustomControls.Cubo CuboDestino;
    }
}
