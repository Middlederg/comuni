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
    public partial class UcCuboLabel : UcBase
    {
        private int cantidad;
        public int Cantidad
        {
            get => cantidad;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(cantidad));
                cantidad = value;
                UpdateCubo();
            }
        }

        public Recurso Recurso => CuboInterior.Recurso;
        public bool Is(TipoRecurso tipo) => Tipo == tipo;

        public TipoRecurso Tipo
        {
            get => CuboInterior.Tipo;
            set
            {
                CuboInterior.Tipo = value;
                UpdateCubo();
            }
        }

        public void Add(int cantidad)
        {
            if (Cantidad + cantidad < 0)
                throw new ArgumentOutOfRangeException($"El resultado de {Cantidad} + {cantidad} no puede ser menor que 0");
            Cantidad += cantidad;
            UpdateCubo();
        }

        public UcCuboLabel()
        {
            InitializeComponent();
        }

        private void UpdateCubo()
        {
            if (Cantidad <= 0) SetToolTip("");
            else SetToolTip(Texto);
            LblText.Visible = CuboInterior.Visible = Cantidad > 0;
            LblText.Text = cantidad.ToString();
        }

        public string Texto => new Recursos(Cantidad, Recurso).ToString();

        private void SetToolTip(string texto)
        {
            ToolTipAyuda.SetToolTip(LblText, texto);
            CuboInterior.SetToolTip(texto);
        }
    }
}
