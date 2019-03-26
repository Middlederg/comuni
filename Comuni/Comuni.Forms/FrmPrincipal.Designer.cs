namespace Comuni.Forms
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.customIconButton1 = new Comuni.Forms.CustomControls.CustomIconButton();
            this.ucSelectableCubo1 = new Comuni.Forms.UserControls.UcSelectableCubo();
            this.SuspendLayout();
            // 
            // customIconButton1
            // 
            this.customIconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.customIconButton1.FlatAppearance.BorderSize = 0;
            this.customIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customIconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.customIconButton1.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customIconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.customIconButton1.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.customIconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.customIconButton1.IconSize = 21;
            this.customIconButton1.Location = new System.Drawing.Point(343, 121);
            this.customIconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.customIconButton1.Name = "customIconButton1";
            this.customIconButton1.Rotation = 0D;
            this.customIconButton1.Size = new System.Drawing.Size(120, 30);
            this.customIconButton1.TabIndex = 1;
            this.customIconButton1.Text = "customIconButton1";
            this.customIconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customIconButton1.UseVisualStyleBackColor = false;
            this.customIconButton1.Click += new System.EventHandler(this.customIconButton1_Click);
            // 
            // ucSelectableCubo1
            // 
            this.ucSelectableCubo1.BackColor = System.Drawing.Color.White;
            this.ucSelectableCubo1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSelectableCubo1.Location = new System.Drawing.Point(278, 260);
            this.ucSelectableCubo1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSelectableCubo1.Name = "ucSelectableCubo1";
            this.ucSelectableCubo1.Size = new System.Drawing.Size(150, 30);
            this.ucSelectableCubo1.TabIndex = 2;
            this.ucSelectableCubo1.Tipo = Comuni.Core.Model.TipoRecurso.Any;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cerrable = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucSelectableCubo1);
            this.Controls.Add(this.customIconButton1);
            this.Maximizable = true;
            this.Mimizable = true;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.customIconButton1, 0);
            this.Controls.SetChildIndex(this.ucSelectableCubo1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomIconButton customIconButton1;
        private UserControls.UcSelectableCubo ucSelectableCubo1;
    }
}

