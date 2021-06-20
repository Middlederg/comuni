namespace Comuni.Forms.UserControls
{
    partial class UcNumericUpDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNumericUpDown));
            this.CuboInterior = new Comuni.Forms.CustomControls.Cubo();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnUp = new Comuni.Forms.CustomControls.CustomIconButton();
            this.BtnDown = new Comuni.Forms.CustomControls.CustomIconButton();
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
            this.CuboInterior.Location = new System.Drawing.Point(45, 0);
            this.CuboInterior.Margin = new System.Windows.Forms.Padding(0);
            this.CuboInterior.Name = "CuboInterior";
            this.TlpPrincipal.SetRowSpan(this.CuboInterior, 2);
            this.CuboInterior.Size = new System.Drawing.Size(30, 30);
            this.CuboInterior.TabIndex = 0;
            this.CuboInterior.Tipo = Comuni.Core.Model.TipoRecurso.Any;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 3;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.Controls.Add(this.BtnUp, 1, 0);
            this.TlpPrincipal.Controls.Add(this.BtnDown, 1, 1);
            this.TlpPrincipal.Controls.Add(this.LblText, 0, 0);
            this.TlpPrincipal.Controls.Add(this.CuboInterior, 2, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TlpPrincipal.Size = new System.Drawing.Size(75, 30);
            this.TlpPrincipal.TabIndex = 1;
            // 
            // BtnUp
            // 
            this.BtnUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUp.FlatAppearance.BorderSize = 0;
            this.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnUp.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnUp.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.BtnUp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnUp.IconSize = 21;
            this.BtnUp.Location = new System.Drawing.Point(25, 0);
            this.BtnUp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Rotation = 0D;
            this.BtnUp.Size = new System.Drawing.Size(20, 15);
            this.BtnUp.TabIndex = 2;
            this.BtnUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUp.UseVisualStyleBackColor = false;
            this.BtnUp.Click += new System.EventHandler(this.BtnUpClick);
            // 
            // BtnDown
            // 
            this.BtnDown.BackColor = System.Drawing.Color.Transparent;
            this.BtnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDown.FlatAppearance.BorderSize = 0;
            this.BtnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDown.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnDown.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.BtnDown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnDown.IconSize = 21;
            this.BtnDown.Location = new System.Drawing.Point(25, 15);
            this.BtnDown.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Rotation = 0D;
            this.BtnDown.Size = new System.Drawing.Size(20, 15);
            this.BtnDown.TabIndex = 1;
            this.BtnDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDown.UseVisualStyleBackColor = false;
            this.BtnDown.Click += new System.EventHandler(this.BtnDownClick);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblText.Font = new System.Drawing.Font("Rubik", 10F);
            this.LblText.Location = new System.Drawing.Point(0, 0);
            this.LblText.Margin = new System.Windows.Forms.Padding(0);
            this.LblText.Name = "LblText";
            this.TlpPrincipal.SetRowSpan(this.LblText, 2);
            this.LblText.Size = new System.Drawing.Size(25, 30);
            this.LblText.TabIndex = 3;
            this.LblText.Text = "2";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UcNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcNumericUpDown";
            this.Size = new System.Drawing.Size(75, 30);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Cubo CuboInterior;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.CustomIconButton BtnUp;
        private CustomControls.CustomIconButton BtnDown;
        private System.Windows.Forms.Label LblText;
    }
}
