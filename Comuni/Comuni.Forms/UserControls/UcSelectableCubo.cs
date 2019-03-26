using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comuni.Core.Model;
using Comuni.Core;

namespace Comuni.Forms.UserControls
{
    public partial class UcSelectableCubo : UcBase
    {
        public event EventHandler CuboSelectionChanged;

        public Recurso Recurso => CuboInterior.Recurso;
        public TipoRecurso Tipo
        {
            get => CuboInterior.Tipo;
            set
            {
                CuboInterior.Tipo = value;
                LblText.Text = Recurso.Nombre;
                EnableDisableButtons();
            }
        }

        public UcSelectableCubo()
        {
            InitializeComponent();
            Tipo = TipoRecurso.Gold;
        }

        private void BtnIzq_Click(object sender, EventArgs e)
        {
            if (Tipo != TipoRecurso.Gold)
            {
                Tipo = (TipoRecurso)(((int)Tipo) - 1);
                CuboSelectionChanged?.Invoke(this, e);
            }
        }

        private void BtnDerecha_Click(object sender, EventArgs e)
        {
            if (Tipo != TipoRecurso.Pilgrim)
            {
                Tipo = (TipoRecurso)(((int)Tipo) + 1);
                CuboSelectionChanged?.Invoke(this, e);
            }
        }

        private void EnableDisableButtons()
        {
            BtnIzq.Enabled = Tipo > 0;
            BtnDerecha.Enabled = (int)Tipo < 3;
        }
    }
}
