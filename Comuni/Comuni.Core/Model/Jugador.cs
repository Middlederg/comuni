using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core.Model
{
    public class Jugador
    {
        public Ciudad Ciudad { get; set; }
        public int Index => Ciudad.Numero;
        public override string ToString() => Ciudad.Nombre;
        public IEnumerable<Recurso> Recursos { get; private set; }
        public IEnumerable<Recurso> Edificios { get; private set; }
        public int Emisarios { get; set; }

        public int Gold => Recursos.Count(x => x.IsGold);
        public int Armies => Recursos.Count(x => x.IsArmy);
        public int Craftsmans => Recursos.Count(x => x.IsCraftsman);
        public int Pilgrims => Recursos.Count(x => x.IsPilgrim);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Jugador)obj).Index == Index;
        }
        public override int GetHashCode() => Index.GetHashCode();
    }
}
