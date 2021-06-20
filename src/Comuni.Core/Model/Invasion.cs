namespace Comuni.Core.Model
{
    public class Invasion
    {
        public Invasion Venezia => new Invasion(Letra.A, "Venezia", 4, 2, 1);
        public Invasion ElPapado => new Invasion(Letra.A, "El Papado", 4, 3, 1);
        public Invasion ReyFrancia => new Invasion(Letra.A, "Rey de Francia", 4, 4, 2);
        public Invasion Emperador => new Invasion(Letra.D, "El emperador", 16, 6, 3);

        public Letra Letra { get; }
        public string Nombre { get; }
        public int Fuerza { get; }
        public int RecompensaCampeon { get; }
        public int RecompensaSubcampeon { get; }
        public bool HaOcurrido { get; set; }

        private Invasion(Letra letra, string nombre, int fuerza, int recompensaCampeon, int recompensaSubcampeon)
        {
            Letra = letra;
            Nombre = nombre;
            Fuerza = fuerza;
            RecompensaCampeon = recompensaCampeon;
            RecompensaSubcampeon = recompensaSubcampeon;
            HaOcurrido = false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Invasion)obj).Letra == Letra;
        }
        public override int GetHashCode() => Letra.GetHashCode();
    }
}
