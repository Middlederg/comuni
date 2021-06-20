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

        public Resource Recurso => CuboInterior.Recurso;
        public ResourceType Tipo
        {
            get => CuboInterior.Tipo;
            set
            {
                CuboInterior.Tipo = value;
                LblText.Text = Recurso.Name;
                EnableDisableButtons();
            }
        }

        public UcSelectableCubo()
        {
            InitializeComponent();
            Tipo = ResourceType.Gold;
        }

        private void BtnIzq_Click(object sender, EventArgs e)
        {
            if (Tipo != ResourceType.Gold)
            {
                Tipo = (ResourceType)(((int)Tipo) - 1);
                CuboSelectionChanged?.Invoke(this, e);
            }
        }

        private void BtnDerecha_Click(object sender, EventArgs e)
        {
            if (Tipo != ResourceType.Pilgrim)
            {
                Tipo = (ResourceType)(((int)Tipo) + 1);
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
