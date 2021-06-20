using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comuni.Core.Model;
using Comuni.Forms.CustomControls;

namespace Comuni.Forms.UserControls
{
    public partial class UcFilaConstruccion : UcBase
    {
        public bool Active
        {
            get => HuecosConstruccion.Active;
            set => HuecosConstruccion.Active = value;
        }

        public BuildingType Tipo
        {
            get => HuecosConstruccion.Tipo;
            set
            {
                if (value != null)
                {
                    HuecosConstruccion.Tipo = value;
                    LblTitulo.Text = value.Nombre;
                    TlpGeneral.BackColor = value.Color;
                    Btn.Visible = !value.EsMuralla;

                    if (!value.EsMuralla)
                    {
                        CantidadRecursos.Tipo = value.Recurso.GetResourceType;
                        Btn.IconChar = value.Icon;
                        Btn.BackColor = value.Color;
                    }
                }
            }
        }

        public UcFilaConstruccion()
        {
            InitializeComponent();
        }

        public void Inicializar(IEnumerable<Construccion> construcciones, IEnumerable<Resource> recursos)
        {
            HuecosConstruccion.InicializarConstrucciones(construcciones);
            CantidadRecursos.Cantidad = recursos.Count(x => x.Equals(Tipo.Recurso));
        }
    }
}
