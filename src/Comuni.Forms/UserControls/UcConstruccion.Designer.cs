namespace Comuni.Forms.UserControls
{
    partial class UcConstruccion
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
            this.Lbl1 = new Comuni.Forms.CustomControls.BorderedLabel();
            this.Lbl2 = new Comuni.Forms.CustomControls.BorderedLabel();
            this.Lbl3 = new Comuni.Forms.CustomControls.BorderedLabel();
            this.Lbl4 = new Comuni.Forms.CustomControls.BorderedLabel();
            this.Lbl5 = new Comuni.Forms.CustomControls.BorderedLabel();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 5;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.Controls.Add(this.Lbl1, 0, 0);
            this.TlpPrincipal.Controls.Add(this.Lbl2, 1, 0);
            this.TlpPrincipal.Controls.Add(this.Lbl3, 2, 0);
            this.TlpPrincipal.Controls.Add(this.Lbl4, 3, 0);
            this.TlpPrincipal.Controls.Add(this.Lbl5, 4, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 1;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Size = new System.Drawing.Size(150, 35);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // Lbl1
            // 
            this.Lbl1.AllowDrop = true;
            this.Lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl1.BackColor = System.Drawing.Color.White;
            this.Lbl1.Columna = 0;
            this.Lbl1.Font = new System.Drawing.Font("Rubik", 12F);
            this.Lbl1.Location = new System.Drawing.Point(4, 4);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(22, 26);
            this.Lbl1.TabIndex = 5;
            this.Lbl1.Text = "borderedLabel1";
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl1.Tipo = null;
            this.Lbl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.Lbl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // Lbl2
            // 
            this.Lbl2.AllowDrop = true;
            this.Lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl2.BackColor = System.Drawing.Color.White;
            this.Lbl2.Columna = 1;
            this.Lbl2.Font = new System.Drawing.Font("Rubik", 12F);
            this.Lbl2.Location = new System.Drawing.Point(34, 4);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(22, 26);
            this.Lbl2.TabIndex = 6;
            this.Lbl2.Text = "2";
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl2.Tipo = null;
            this.Lbl2.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.Lbl2.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // Lbl3
            // 
            this.Lbl3.AllowDrop = true;
            this.Lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl3.BackColor = System.Drawing.Color.White;
            this.Lbl3.Columna = 2;
            this.Lbl3.Font = new System.Drawing.Font("Rubik", 12F);
            this.Lbl3.Location = new System.Drawing.Point(64, 4);
            this.Lbl3.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(22, 26);
            this.Lbl3.TabIndex = 7;
            this.Lbl3.Text = "borderedLabel3";
            this.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl3.Tipo = null;
            this.Lbl3.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.Lbl3.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // Lbl4
            // 
            this.Lbl4.AllowDrop = true;
            this.Lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl4.BackColor = System.Drawing.Color.White;
            this.Lbl4.Columna = 3;
            this.Lbl4.Font = new System.Drawing.Font("Rubik", 12F);
            this.Lbl4.Location = new System.Drawing.Point(94, 4);
            this.Lbl4.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(22, 26);
            this.Lbl4.TabIndex = 8;
            this.Lbl4.Text = "borderedLabel4";
            this.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl4.Tipo = null;
            this.Lbl4.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.Lbl4.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // Lbl5
            // 
            this.Lbl5.AllowDrop = true;
            this.Lbl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl5.BackColor = System.Drawing.Color.White;
            this.Lbl5.Columna = 4;
            this.Lbl5.Font = new System.Drawing.Font("Rubik", 12F);
            this.Lbl5.Location = new System.Drawing.Point(124, 4);
            this.Lbl5.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(22, 26);
            this.Lbl5.TabIndex = 9;
            this.Lbl5.Text = "borderedLabel5";
            this.Lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl5.Tipo = null;
            this.Lbl5.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.Lbl5.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // UcConstruccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrincipal);
            this.Name = "UcConstruccion";
            this.Size = new System.Drawing.Size(150, 35);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private CustomControls.BorderedLabel Lbl1;
        private CustomControls.BorderedLabel Lbl5;
        private CustomControls.BorderedLabel Lbl4;
        private CustomControls.BorderedLabel Lbl3;
        private CustomControls.BorderedLabel Lbl2;
    }
}
