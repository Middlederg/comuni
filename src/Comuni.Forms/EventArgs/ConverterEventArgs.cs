using Comuni.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comuni.Forms
{
    public class ConverterEventArgs : EventArgs
    {
        public Recurso RecursoOrigen { get; }
        public Recurso RecursoDestino { get; }

        public ConverterEventArgs(Recurso recursoOrigen, Recurso recursoDestino)
        {
            RecursoOrigen = recursoOrigen;
            RecursoDestino = recursoDestino;
        }
    }
}
