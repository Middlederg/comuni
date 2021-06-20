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
        protected Resource recurso;
        public Resource Recurso => recurso;

        public ResourceType Tipo
        {
            get => recurso.GetResourceType;
            set
            {
                recurso = Resource.Create(value);
                UpdateRecurso();
            }
        }

        public Cubo()
        {
            InitializeComponent();
            recurso = Resource.Any;
        }

        protected void UpdateRecurso()
        {
            if (recurso != null)
                BackColor = recurso.Color;

            BackgroundImage = (recurso == null || recurso.IsAny) ? Properties.Resources.multicolor : null;
        }

        public void SetToolTip(string texto)
        {
            ToolTipAyuda.SetToolTip(this, texto);
        }
    }
}
