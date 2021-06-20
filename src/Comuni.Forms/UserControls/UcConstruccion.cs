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
    public partial class UcConstruccion : UcBase
    {
        public bool Active { get; set; }

        private TipoPoder tipo;
        public TipoPoder Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
                if (value != null)
                {
                    BackColor = tipo.Color;
                    for (int i = 0; i < TlpPrincipal.ColumnCount; i++)
                    {
                        var lbl = TlpPrincipal.Controls[i] as BorderedLabel;
                        lbl.Tipo = value;
                    }
                }
            }
        }

        private List<Construccion> construcciones;
        private IEnumerable<string> GetColumnaToolTip(int columna)
        {
            int i = 1;
            foreach (var construccion in construcciones.Where(x => x.Columna == columna))
            {
                yield return $"{i++}. {construccion.Edificio.Nombre}";
            }
        }
        public void InicializarConstrucciones(IEnumerable<Construccion> construcciones)
        {
            this.construcciones = construcciones.ToList();
            for (int i = 0; i < 5; i++)
            {
                int numero = construcciones.Count(x => x.Tipo.Equals(Tipo) && x.Columna == i);
                var lbl = TlpPrincipal.Controls[i] as BorderedLabel;
                lbl.Text = numero.ToString();
                ToolTipAyuda.SetToolTip(lbl, string.Join("\n", GetColumnaToolTip(lbl.Columna)));
            }
        }

        public UcConstruccion()
        {
            InitializeComponent();
            InicializarConstrucciones(new List<Construccion>());
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            var edificio = e.Data.GetData(typeof(Edificio)) as Edificio;
            if (Active && edificio.ContieneTipo(Tipo) && LowerThan4(sender))
                e.Effect = DragDropEffects.Move;
        }


        private void OnDragDrop(object sender, DragEventArgs e)
        {
            if (LowerThan4(sender))
            {
                var lbl = sender as BorderedLabel;
                int nivel = GetNivel(lbl);
                var edificio = e.Data.GetData(typeof(Edificio)) as Edificio;
                nivel++;
                construcciones.Add(new Construccion(edificio, tipo, lbl.Columna));
                ToolTipAyuda.SetToolTip(lbl, string.Join("\n", GetColumnaToolTip(lbl.Columna)));
                lbl.Text = nivel.ToString();
            }
        }

        //private void UpdateConstrucciones()
        //{
        //    for (int i = 0; i < TlpPrincipal.ColumnCount; i++)
        //    {
        //        var lbl = TlpPrincipal.Controls[i] as BorderedLabel;
        //        lbl.Text = construcciones.Count(x => x.Columna == i).ToString();
        //        ToolTipAyuda.SetToolTip(lbl, string.Join("\n", construcciones.Where(x => x.Columna == i).Select(x => x.Edificio.ToString())));
        //    }
        //}

        private bool LowerThan4(object sender)
        {
            Label lbl = sender as Label;
            if (Int32.TryParse(lbl.Text, out int nivel))
                return (nivel < 4);
            else throw new ArgumentException($"{lbl.Text} debería ser un número");
        }

        private int GetNivel(Label lbl)
        {
            if (Int32.TryParse(lbl.Text, out int nivel))
                return nivel;
            else throw new ArgumentException($"{lbl.Text} debería ser un número");
        }
    }
}
