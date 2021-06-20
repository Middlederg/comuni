using Comuni.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comuni.Forms
{
    public class ConverterEventArgs : EventArgs
    {
        public Resource RecursoOrigen { get; }
        public Resource RecursoDestino { get; }

        public ConverterEventArgs(Resource recursoOrigen, Resource recursoDestino)
        {
            RecursoOrigen = recursoOrigen;
            RecursoDestino = recursoDestino;
        }
    }
}
