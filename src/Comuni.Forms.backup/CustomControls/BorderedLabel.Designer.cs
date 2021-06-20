namespace Comuni.Forms.CustomControls
{
    partial class BorderedLabel
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
            this.SuspendLayout();
            // 
            // BorderedLabel
            // 
            this.AllowDrop = true;
            this.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Rubik", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(22, 26);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResumeLayout(false);

        }

        #endregion
    }
}
