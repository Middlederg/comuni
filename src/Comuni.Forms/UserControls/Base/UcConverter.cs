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
    public partial class UcConverter : UcBase
    {
        public event EventHandler ConversionClicked;

        public Recurso RecursoOrigen => CuboLabel.Recurso;
        public TipoRecurso TipoOrigen
        {
            get => CuboLabel.Tipo;
            set
            {
                CuboLabel.Tipo = value;
                ToolTipAyuda.SetToolTip(Btn, Texto);
            }
        }

        public Recurso RecursoDestino => Recurso.Create(TipoDestino);
        public TipoRecurso TipoDestino
        {
            get => CuboDestino.Tipo;
            set
            {
                CuboDestino.Tipo = value;
                ToolTipAyuda.SetToolTip(Btn, Texto);
            }
        }

        public new bool Enabled
        {
            get => Btn.Enabled;
            set
            {
                Btn.Enabled = value;
                base.Enabled = value;
            }
        }
        public string Texto => $"Convertir {CuboLabel.Texto} en {Recurso.Create(TipoDestino).ToString()}";

        public UcConverter()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ConversionClicked?.Invoke(this, new ConverterEventArgs(RecursoOrigen, RecursoDestino));
        }
    }

    
}
