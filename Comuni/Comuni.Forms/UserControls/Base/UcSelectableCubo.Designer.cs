namespace Comuni.Forms.UserControls
{
    partial class UcSelectableCubo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSelectableCubo));
            this.CuboInterior = new Comuni.Forms.CustomControls.Cubo();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnIzq = new Comuni.Forms.CustomControls.CustomIconButton();
            this.BtnDerecha = new Comuni.Forms.CustomControls.CustomIconButton();
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
            this.CuboInterior.Location = new System.Drawing.Point(20, 0);
            this.CuboInterior.Margin = new System.Windows.Forms.Padding(0);
            this.CuboInterior.Name = "CuboInterior";
            this.CuboInterior.Size = new System.Drawing.Size(30, 30);
            this.CuboInterior.TabIndex = 0;
            this.CuboInterior.Tipo = Comuni.Core.Model.TipoRecurso.Any;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 4;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.BtnDerecha, 2, 0);
            this.TlpPrincipal.Controls.Add(this.CuboInterior, 1, 0);
            this.TlpPrincipal.Controls.Add(this.BtnIzq, 0, 0);
            this.TlpPrincipal.Controls.Add(this.LblText, 3, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.Size = new System.Drawing.Size(150, 30);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // BtnIzq
            // 
            this.BtnIzq.BackColor = System.Drawing.Color.Transparent;
            this.BtnIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIzq.FlatAppearance.BorderSize = 0;
            this.BtnIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzq.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnIzq.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnIzq.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnIzq.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnIzq.IconSize = 21;
            this.BtnIzq.Location = new System.Drawing.Point(0, 0);
            this.BtnIzq.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIzq.Name = "BtnIzq";
            this.BtnIzq.Rotation = 0D;
            this.BtnIzq.Size = new System.Drawing.Size(20, 30);
            this.BtnIzq.TabIndex = 1;
            this.BtnIzq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIzq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIzq.UseVisualStyleBackColor = false;
            this.BtnIzq.Click += new System.EventHandler(this.BtnIzq_Click);
            // 
            // BtnDerecha
            // 
            this.BtnDerecha.BackColor = System.Drawing.Color.Transparent;
            this.BtnDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDerecha.FlatAppearance.BorderSize = 0;
            this.BtnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDerecha.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDerecha.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDerecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnDerecha.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.BtnDerecha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnDerecha.IconSize = 21;
            this.BtnDerecha.Location = new System.Drawing.Point(50, 0);
            this.BtnDerecha.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDerecha.Name = "BtnDerecha";
            this.BtnDerecha.Rotation = 0D;
            this.BtnDerecha.Size = new System.Drawing.Size(20, 30);
            this.BtnDerecha.TabIndex = 2;
            this.BtnDerecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDerecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDerecha.UseVisualStyleBackColor = false;
            this.BtnDerecha.Click += new System.EventHandler(this.BtnDerecha_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblText.Font = new System.Drawing.Font("Rubik", 10F);
            this.LblText.Location = new System.Drawing.Point(73, 0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(74, 30);
            this.LblText.TabIndex = 3;
            this.LblText.Text = "label1";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcSelectableCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcSelectableCubo";
            this.Size = new System.Drawing.Size(150, 30);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Cubo CuboInterior;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.CustomIconButton BtnDerecha;
        private CustomControls.CustomIconButton BtnIzq;
        private System.Windows.Forms.Label LblText;
    }
}
