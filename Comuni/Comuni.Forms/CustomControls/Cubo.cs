using Comuni.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comuni.Forms.CustomControls
{
    public partial class Cubo : Panel
    {
        protected Recurso recurso;
        public Recurso Recurso => recurso;

        public TipoRecurso Tipo
        {
            get => recurso.GetTipoRecurso;
            set
            {
                recurso = Recurso.Create(value);
                UpdateRecurso();
            }
        }

        public Cubo()
        {
            InitializeComponent();
            recurso = Recurso.Any;
        }

        protected void UpdateRecurso()
        {
            if (recurso != null)
                BackColor = recurso.Color;

            BackgroundImage = (recurso == null || recurso.IsAny) ? Properties.Resources.multicolor : null;
        }
    }
}
