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
using Comuni.Forms.Model;

namespace Comuni.Forms.UserControls
{
    public partial class UcNumericUpDown : UcBase
    {
        public event EventHandler CuboSelectionChanged;

        public int CantidadMaxima { get; set; }

        private int cantidad;
        public int Cantidad
        {
            get => cantidad;
            set
            {
                if (value < 0 || (CantidadMaxima != 0 && value > CantidadMaxima))
                    throw new ArgumentOutOfRangeException(nameof(cantidad));
                cantidad = value;
                UpdateCubo();
                EnableDisableButtons();
            }
        }

        public Recurso Recurso => CuboInterior.Recurso;
        public TipoRecurso Tipo
        {
            get => CuboInterior.Tipo;
            set
            {
                CuboInterior.Tipo = value;
            }
        }

        public UcNumericUpDown()
        {
            InitializeComponent();
        }

        private void UpdateCubo()
        {
            var recursos = new Recursos(Cantidad, Recurso);
            if (recursos.Empty) SetToolTip("");
            else SetToolTip(Texto);
            LblText.Text = cantidad.ToString();
        }

        public string Texto => new Recursos(Cantidad, Recurso).ToString();

        private void SetToolTip(string texto)
        {
            ToolTipAyuda.SetToolTip(LblText, texto);
            CuboInterior.SetToolTip(texto);
        }

        private void BtnUpClick(object sender, EventArgs e)
        {
            if (cantidad < CantidadMaxima)
            {
                Cantidad++;
                CuboSelectionChanged?.Invoke(this, e);
            }
        }

        private void BtnDownClick(object sender, EventArgs e)
        {
            if (Cantidad > 0)
            {
                Cantidad--;
                CuboSelectionChanged?.Invoke(this, e);
            }
        }

        private void EnableDisableButtons()
        {
            BtnDown.Enabled = Cantidad > 0;
            BtnUp.Enabled = Cantidad < CantidadMaxima;
        }
    }
}
