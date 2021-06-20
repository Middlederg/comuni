namespace Comuni.Forms.UserControls
{
    partial class UcFilaConstruccion
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
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.LblMaestroGremio = new System.Windows.Forms.Label();
            this.HuecosConstruccion = new Comuni.Forms.UserControls.UcConstruccion();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Btn = new Comuni.Forms.CustomControls.CustomIconButton();
            this.CantidadRecursos = new Comuni.Forms.UserControls.UcCuboLabel();
            this.TlpDerecha = new System.Windows.Forms.TableLayoutPanel();
            this.TlpGeneral.SuspendLayout();
            this.TlpDerecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 3;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGeneral.Controls.Add(this.LblMaestroGremio, 2, 0);
            this.TlpGeneral.Controls.Add(this.HuecosConstruccion, 1, 0);
            this.TlpGeneral.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Left;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 1;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Size = new System.Drawing.Size(325, 35);
            this.TlpGeneral.TabIndex = 0;
            // 
            // LblMaestroGremio
            // 
            this.LblMaestroGremio.AutoSize = true;
            this.LblMaestroGremio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMaestroGremio.Font = new System.Drawing.Font("Rubik", 14F);
            this.LblMaestroGremio.Location = new System.Drawing.Point(270, 0);
            this.LblMaestroGremio.Margin = new System.Windows.Forms.Padding(0);
            this.LblMaestroGremio.Name = "LblMaestroGremio";
            this.LblMaestroGremio.Size = new System.Drawing.Size(55, 35);
            this.LblMaestroGremio.TabIndex = 2;
            this.LblMaestroGremio.Text = "+1";
            this.LblMaestroGremio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HuecosConstruccion
            // 
            this.HuecosConstruccion.Active = false;
            this.HuecosConstruccion.BackColor = System.Drawing.Color.White;
            this.HuecosConstruccion.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuecosConstruccion.Location = new System.Drawing.Point(120, 0);
            this.HuecosConstruccion.Margin = new System.Windows.Forms.Padding(0);
            this.HuecosConstruccion.Name = "HuecosConstruccion";
            this.HuecosConstruccion.Size = new System.Drawing.Size(150, 35);
            this.HuecosConstruccion.TabIndex = 0;
            this.HuecosConstruccion.Tipo = null;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(120, 35);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Título";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn
            // 
            this.Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.Btn.FlatAppearance.BorderSize = 0;
            this.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.Btn.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.Btn.IconColor = System.Drawing.Color.Black;
            this.Btn.IconSize = 28;
            this.Btn.Location = new System.Drawing.Point(0, 5);
            this.Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Btn.Name = "Btn";
            this.Btn.Rotation = 0D;
            this.Btn.Size = new System.Drawing.Size(80, 25);
            this.Btn.TabIndex = 3;
            this.Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn.UseVisualStyleBackColor = false;
            // 
            // CantidadRecursos
            // 
            this.CantidadRecursos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CantidadRecursos.BackColor = System.Drawing.Color.White;
            this.CantidadRecursos.Cantidad = 0;
            this.CantidadRecursos.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRecursos.Location = new System.Drawing.Point(110, 2);
            this.CantidadRecursos.Margin = new System.Windows.Forms.Padding(0);
            this.CantidadRecursos.Name = "CantidadRecursos";
            this.CantidadRecursos.Size = new System.Drawing.Size(50, 30);
            this.CantidadRecursos.TabIndex = 4;
            this.CantidadRecursos.Tipo = Comuni.Core.Model.TipoRecurso.Any;
            // 
            // TlpDerecha
            // 
            this.TlpDerecha.ColumnCount = 2;
            this.TlpDerecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpDerecha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpDerecha.Controls.Add(this.CantidadRecursos, 1, 0);
            this.TlpDerecha.Controls.Add(this.Btn, 0, 0);
            this.TlpDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.TlpDerecha.Location = new System.Drawing.Point(359, 0);
            this.TlpDerecha.Margin = new System.Windows.Forms.Padding(0);
            this.TlpDerecha.Name = "TlpDerecha";
            this.TlpDerecha.RowCount = 1;
            this.TlpDerecha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpDerecha.Size = new System.Drawing.Size(160, 35);
            this.TlpDerecha.TabIndex = 1;
            // 
            // UcFilaConstruccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpDerecha);
            this.Controls.Add(this.TlpGeneral);
            this.Name = "UcFilaConstruccion";
            this.Size = new System.Drawing.Size(519, 35);
            this.TlpGeneral.ResumeLayout(false);
            this.TlpGeneral.PerformLayout();
            this.TlpDerecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private UcConstruccion HuecosConstruccion;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblMaestroGremio;
        private CustomControls.CustomIconButton Btn;
        private UcCuboLabel CantidadRecursos;
        private System.Windows.Forms.TableLayoutPanel TlpDerecha;
    }
}
