using Comuni.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Comuni.Forms.Model
{
    public class Recursos
    {
        public int Cantidad { get; private set; }
        public Resource Recurso { get; private set; }

        public bool Empty => Cantidad <= 0;
        private bool plural => Cantidad != 1;

        public Recursos(int cantidad, Resource recurso)
        {
            Cantidad = cantidad;
            Recurso = recurso;
        }
        public override string ToString() => $"{Cantidad} {Recurso.ToString()}{(plural ? "s" : "")}";
        public bool Visible => !Empty;
    }
}
