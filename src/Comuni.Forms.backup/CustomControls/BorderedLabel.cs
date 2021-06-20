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
    public partial class BorderedLabel : Label
    {
        private BuildingType tipo;
        public BuildingType Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
                if (tipo != null)
                {
                    Update();
                }
            }
        }
        public int Columna { get; set; }

        public BorderedLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (tipo != null)
            {
                var color = Tipo.GetColorBorde;
                ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle,
                            color, 1, ButtonBorderStyle.Solid,
                            color, 1, ButtonBorderStyle.Solid,
                            color, 1, ButtonBorderStyle.Solid,
                            color, 1, ButtonBorderStyle.Solid);
            }
        }
    }
}
