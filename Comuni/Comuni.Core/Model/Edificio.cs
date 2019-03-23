using System.Collections.Generic;

namespace Comuni.Core.Model
{
    public class Edificio
    {
        public static Edificio Create(int nivel, string nombre) => new Edificio(nivel, nombre);

        public int Nivel { get; }
        public string Nombre { get; }
        public Letra LetraMazo { get; internal set; }
        public List<TipoPoder> Tipos { get; private set; }
        public int NumeroMaximoJugadores { get; internal set; }

        private Edificio(int nivel, string nombre)
        {
            Nivel = nivel;
            Nombre = nombre;
            NumeroMaximoJugadores = 0;
            Tipos = new List<TipoPoder>();
        }

        internal void AddTipo(TipoPoder tipo) => Tipos.Add(tipo);

        public bool CoincidenTipos(Edificio edificioObjetivo) => Tipos.Any(x => edificioObjetivo.Tipos.Contains(x));
        public int Coste(Edificio edificioSobreElqueConstruir) => System.Math.Max((edificioSobreElqueConstruir.Nivel - Nivel), 0);
    }


}
