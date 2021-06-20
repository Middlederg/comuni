namespace Comuni.Core.Model
{
    public class GuildMaster
    {
        public static GuildMaster Moneylender => new GuildMaster("Prestamista", Resource.Oro);
        public static GuildMaster Captain => new GuildMaster("Capitán", Resource.Army);
        public static GuildMaster Architect => new GuildMaster("Arquitecto", Resource.Craftsman);
        public static GuildMaster Bishop => new GuildMaster("Obispo", Resource.Pilgrim);

        public string Nombre { get; }
        public Resource Beneficio { get; }

        private GuildMaster(string nombre, Resource beneficio)
        {
            Nombre = nombre;
            Beneficio = beneficio;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Nombre.Equals(((GuildMaster)obj).Nombre);
        }

        public override int GetHashCode() => Nombre.GetHashCode();
        public override string ToString() => $"{Nombre} - {Beneficio.ToString()}";
    }


}
