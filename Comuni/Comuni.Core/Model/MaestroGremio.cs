namespace Comuni.Core.Model
{
    public class MaestroGremio
    {
        public static MaestroGremio Prestamista => new MaestroGremio("Prestamista", Recurso.Oro);
        public static MaestroGremio Capitan => new MaestroGremio("Capitán", Recurso.Ejercito);
        public static MaestroGremio Arquitecto => new MaestroGremio("Arquitecto", Recurso.Artesano);
        public static MaestroGremio Obispo => new MaestroGremio("Obispo", Recurso.Peregrino);

        public string Nombre { get; }
        public Recurso Beneficio { get; }

        private MaestroGremio(string nombre, Recurso beneficio)
        {
            Nombre = nombre;
            Beneficio = beneficio;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Nombre.Equals(((MaestroGremio)obj).Nombre);
        }

        public override int GetHashCode() => Nombre.GetHashCode();
        public override string ToString() => $"{Nombre} - {Beneficio.ToString()}";
    }


}
