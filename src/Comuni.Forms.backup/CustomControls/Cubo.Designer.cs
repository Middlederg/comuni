namespace Comuni.Forms.CustomControls
{
    partial class Cubo
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
            this.components = new System.ComponentModel.Container();
            this.ToolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Cubo
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(30, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTipAyuda;
    }
}
