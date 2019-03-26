namespace Comuni.Core.Model
{
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
    }


}
