using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comuni.Core.Model;

namespace Comuni.Forms.UserControls
{
    public partial class UcEdificio : UcBase
    {
        public bool Arrastrable { get; set; }

        private BuildingCard edificio;
        public BuildingCard Edificio
        {
            get => edificio;
            set
            {
                edificio = value;
                UpdateEdificio();
            }
        }

        private void UpdateEdificio()
        {
            if (edificio is null)
            {
                LblNumero.Text = "";
                Pbx.IconChar = FontAwesome.Sharp.IconChar.None;
                LblNombre.Text = "";
                ToolTipAyuda.SetToolTip(Pbx, "");
                BackColor = Color.Transparent;
            }
            else
            {
                LblNumero.Text = edificio.Level.ToString();
                Pbx.IconChar = edificio.GetIconChar;
                LblNombre.Text = edificio.name;
                ToolTipAyuda.SetToolTip(Pbx, string.Join("\n", edificio.TypesAllowed.Select(x => x.ToString())));
                BackColor = edificio.GetBackColor;
            }
        }

        public UcEdificio()
        {
            InitializeComponent();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (Arrastrable && edificio != null)
                DoDragDrop(Edificio, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var color = edificio?.GetBorderColor ?? Color.Black;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                      color, 1, ButtonBorderStyle.Solid,
                      color, 1, ButtonBorderStyle.Solid,
                      color, 1, ButtonBorderStyle.Solid,
                      color, 1, ButtonBorderStyle.Solid);
        }
    }
}
