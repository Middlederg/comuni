using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comuni.Forms.Views
{
    public partial class FrmBaseDialog : FrmBase
    {
        public event EventHandler AceptarClicked;
        public event EventHandler CancelarClicked;

        public bool ShowCancelar
        {
            get { return BtnCancelar.Visible; }
            set
            {
                BtnCancelar.Visible = value;
                if (value) TlpBotones.ColumnStyles[2].Width = 130;
                else TlpBotones.ColumnStyles[2].Width = 0;
            }
        }

        public FrmBaseDialog()
        {
            InitializeComponent();
            BtnCancelar.Click += CloseWindow;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e) => AceptarClicked?.Invoke(sender, e);
        private void BtnCancelar_Click(object sender, EventArgs e) => CancelarClicked?.Invoke(sender, e);
    }
}
