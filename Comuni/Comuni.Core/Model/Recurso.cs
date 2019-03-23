using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Comuni.Core.Model
{
    public static class EdificiosGenericosFactory
    {
        public static EdificioBuilder Generico(int nivel) => new EdificioBuilder(nivel, "Consistorio").
            SetEconomico().SetMilitar().SetCultural().SetReligioso();
    }
    public static class EdificiosEconomicosFactory
    {
        public static EdificioBuilder Granja => new EdificioBuilder(1, "Granja").SetEconomico();
        public static EdificioBuilder Mercado => new EdificioBuilder(2, "Mercado").SetEconomico();
        public static EdificioBuilder Molino => new EdificioBuilder(3, "Molino").SetEconomico();
        public static EdificioBuilder CentroUrbano => new EdificioBuilder(4, "Centro urbano").SetEconomico();
    }

    public static class EdificiosMilitaresFactory
    {
        public static EdificioBuilder Herreria => new EdificioBuilder(1, "Herrería").SetMilitar();
        public static EdificioBuilder Cuartel => new EdificioBuilder(2, "Cuartel").SetMilitar();
        public static EdificioBuilder Castillo => new EdificioBuilder(3, "Castillo").SetMilitar();
        public static EdificioBuilder Fortaleza => new EdificioBuilder(4, "Fortaleza").SetMilitar();
    }

    public static class EdificiosCulturalesFactory
    {
        public static EdificioBuilder Taller => new EdificioBuilder(1, "Taller").SetCultural();
        public static EdificioBuilder Biblioteca => new EdificioBuilder(2, "Biblioteca").SetCultural();
        public static EdificioBuilder Universidad => new EdificioBuilder(3, "Universidad").SetCultural();
        public static EdificioBuilder Teatro => new EdificioBuilder(4, "Teatro").SetCultural();
    }

    public static class EdificiosReligiososFactory
    {
        public static EdificioBuilder Capilla => new EdificioBuilder(1, "Capilla").SetReligioso();
        public static EdificioBuilder Iglesia => new EdificioBuilder(2, "Iglesia").SetReligioso();
        public static EdificioBuilder Monasterio => new EdificioBuilder(3, "Monasterio").SetReligioso();
        public static EdificioBuilder Catedral => new EdificioBuilder(4, "Catedral").SetReligioso();
    }

    public interface IEdificioFactory
    {
        IEnumerable<Edificio> Create();
    }

    public static class EdificiosFactory
    {
        public static IEnumerable<Edificio> GenerarEdificios()
        {
            foreach (var factory in new List<IEdificioFactory>() { new MazoAFactory() })
            {
                foreach (var edificio in factory.Create().Select(x => x))
                    yield return edificio;
            }
        }
    }

    internal class MazoBFactory : IEdificioFactory
    {
        public IEnumerable<Edificio> Create()
        {
            yield return EdificiosEconomicosFactory.Granja.SetLetraB().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraB().Edificio;
            yield return EdificiosEconomicosFactory.Molino.SetLetraB().SetNumeroMaximo4().Edificio;
            yield return EdificiosEconomicosFactory.CentroUrbano.SetLetraB().Edificio;

            yield return EdificiosMilitaresFactory.Herreria.SetLetraB().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraB().Edificio;
            yield return EdificiosMilitaresFactory.Castillo.SetLetraB().SetNumeroMaximo4().Edificio;
            yield return EdificiosMilitaresFactory.Fortaleza.SetLetraB().Edificio;

            yield return EdificiosCulturalesFactory.Taller.SetLetraB().SetNumeroMaximo5().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraB().Edificio;
            yield return EdificiosCulturalesFactory.Universidad.SetLetraB().Edificio;
            yield return EdificiosCulturalesFactory.Teatro.SetLetraB().SetNumeroMaximo3().Edificio;

            yield return EdificiosReligiososFactory.Capilla.SetLetraB().SetNumeroMaximo5().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraB().Edificio;
            yield return EdificiosReligiososFactory.Monasterio.SetLetraB().Edificio;
            yield return EdificiosReligiososFactory.Catedral.SetLetraB().SetNumeroMaximo3().Edificio;

            yield return EdificiosGenericosFactory.Generico(2).SetNumeroMaximo3().Edificio;
            yield return EdificiosGenericosFactory.Generico(2).Edificio;
        }
    }

    internal class MazoAFactory : IEdificioFactory
    {
        public IEnumerable<Edificio> Create()
        {
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().SetNumeroMaximo4().Edificio;
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosEconomicosFactory.Molino.SetLetraA().SetNumeroMaximo4().Edificio;

            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().SetNumeroMaximo4().Edificio;
            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosMilitaresFactory.Castillo.SetLetraA().Edificio;

            yield return EdificiosCulturalesFactory.Taller.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Taller.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Taller.SetLetraA().SetNumeroMaximo4().Edificio;
            yield return EdificiosCulturalesFactory.Taller.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosCulturalesFactory.Universidad.SetLetraA().SetNumeroMaximo4().Edificio;

            yield return EdificiosReligiososFactory.Capilla.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Capilla.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Capilla.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosReligiososFactory.Capilla.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosReligiososFactory.Monasterio.SetLetraA().SetNumeroMaximo4().Edificio;
        }
    }

 

    public class EdificioBuilder
    {
        public Edificio Edificio { get; private set; }

        public EdificioBuilder(int nivel, string nombre)
        {
            Edificio = Edificio.Create(nivel, nombre);
        }

        public EdificioBuilder SetLetraA()
        {
            Edificio.LetraMazo = Letra.A;
            return this;
        }
        public EdificioBuilder SetLetraB()
        {
            Edificio.LetraMazo = Letra.B;
            return this;
        }
        public EdificioBuilder SetLetraC()
        {
            Edificio.LetraMazo = Letra.C;
            return this;
        }
        public EdificioBuilder SetLetraD()
        {
            Edificio.LetraMazo = Letra.D;
            return this;
        }

        public EdificioBuilder SetNumeroMaximo3()
        {
            Edificio.NumeroMaximoJugadores = 3;
            return this;
        }
        public EdificioBuilder SetNumeroMaximo4()
        {
            Edificio.NumeroMaximoJugadores = 4;
            return this;
        }
        public EdificioBuilder SetNumeroMaximo5()
        {
            Edificio.NumeroMaximoJugadores = 5;
            return this;
        }

        public EdificioBuilder SetEconomico()
        {
            Edificio.AddTipo(TipoPoder.Economico);
            return this;
        }

        public EdificioBuilder SetMilitar()
        {
            Edificio.AddTipo(TipoPoder.Militar);
            return this;
        }

        public EdificioBuilder SetCultural()
        {
            Edificio.AddTipo(TipoPoder.Cultural);
            return this;
        }

        public EdificioBuilder SetReligioso()
        {
            Edificio.AddTipo(TipoPoder.Religioso);
            return this;
        }

        //public Edificio SetMilitar => edificio.SetTipos(TipoPoder.Militar);
        //public Edificio SetCultural => edificio.SetTipos(TipoPoder.Cultural);
        //public Edificio SetReligioso => edificio.SetTipos(TipoPoder.Religioso);
        //public Edificio SetGenerico => edificio.SetTipos(TipoPoder.Economico, TipoPoder.Militar, TipoPoder.Cultural, TipoPoder.Religioso);
        //public Edificio SetCulturalMilitar => edificio.SetTipos(TipoPoder.Militar, TipoPoder.Cultural);
        //public Edificio SetEconomicoReligioso => edificio.SetTipos(TipoPoder.Economico, TipoPoder.Religioso);
        //public Edificio SetEconomicoCultural => edificio.SetTipos(TipoPoder.Economico, TipoPoder.Cultural);
        //public Edificio SetMilitarReligioso => edificio.SetTipos(TipoPoder.Militar, TipoPoder.Religioso);
        //public Edificio SetCulturalReligioso => edificio.SetTipos(TipoPoder.Cultural, TipoPoder.Religioso);
        //public Edificio SetEconomicoMilitar => edificio.SetTipos(TipoPoder.Economico, TipoPoder.Militar);
    }

    public class Recurso
    {
        private const string AnyName = "Cualquiera";

        public static Recurso Any => new Recurso(AnyName, Color.Transparent);
        public static Recurso Oro => new Recurso("Oro", Color.Gold);
        public static Recurso Ejercito => new Recurso("Efército", Color.Black);
        public static Recurso Artesano => new Recurso("Artesano", Color.White);
        public static Recurso Peregrino => new Recurso("Peregrino", Color.SaddleBrown);

        public string Nombre { get; }
        public Color Color { get; }

        private Recurso(string nombre, Color color)
        {
            Nombre = nombre;
            Color = color;
        }

        public bool IsConcreteColor => !IsAny;
        public bool IsAny => Nombre.Equals(AnyName);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Nombre.Equals(((Recurso)obj).Nombre);
        }

        public override int GetHashCode() => Nombre.GetHashCode();
        public override string ToString() => Nombre;
    }


}
