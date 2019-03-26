namespace Comuni.Forms.Views
{
    partial class FrmBaseDialog
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
            this.TlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAceptar = new Comuni.Forms.CustomControls.CustomIconButton();
            this.BtnCancelar = new Comuni.Forms.CustomControls.CustomIconButton();
            this.TlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 3;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TlpBotones.Controls.Add(this.BtnAceptar, 1, 0);
            this.TlpBotones.Controls.Add(this.BtnCancelar, 2, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TlpBotones.Location = new System.Drawing.Point(0, 560);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TlpBotones.RowCount = 1;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpBotones.Size = new System.Drawing.Size(800, 40);
            this.TlpBotones.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAceptar.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnAceptar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnAceptar.IconSize = 21;
            this.BtnAceptar.Location = new System.Drawing.Point(540, 0);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Rotation = 0D;
            this.BtnAceptar.Size = new System.Drawing.Size(120, 30);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancelar.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BtnCancelar.IconSize = 21;
            this.BtnCancelar.Location = new System.Drawing.Point(670, 0);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Rotation = 0D;
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmBaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TlpBotones);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Maximizable = true;
            this.Mimizable = true;
            this.Name = "FrmBaseDialog";
            this.Text = "FrmBaseDialog";
            this.Controls.SetChildIndex(this.TlpBotones, 0);
            this.TlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private CustomControls.CustomIconButton BtnAceptar;
        private CustomControls.CustomIconButton BtnCancelar;
    }
}