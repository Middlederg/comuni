using Comuni.Core.Model;
using Comuni.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comuni.Forms
{
    public partial class FrmPrincipal : FrmBase
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            ucEdificio1.Edificio = EdificiosEconomicosFactory.Granja.Edificio;
            ucEdificio2.Edificio = EdificiosEconomicosFactory.Mercado.Edificio;
            //ucEdificio2.Edificio = EdificiosCulturalesFactory.Universidad.Edificio;
            ucEdificio3.Edificio = EdificiosMilitaresFactory.Fortaleza.Edificio;
            ucEdificio4.Edificio = EdificiosReligiososFactory.Iglesia.Edificio;

            //ucEdificio1.Edificio = new EdificioBuilder(4, "Palacio").SetLetraD().SetEconomico().SetCultural().SetNumeroMaximo3().Edificio;
            //ucEdificio2.Edificio = new EdificioBuilder(4, "Templo de la orden").SetLetraD().SetMilitar().SetReligioso().SetNumeroMaximo3().Edificio;
            //ucEdificio3.Edificio = new EdificioBuilder(4, "Seminario").SetLetraD().SetReligioso().SetCultural().SetNumeroMaximo5().Edificio;
            //ucEdificio4.Edificio = new EdificioBuilder(4, "Ciudadela").SetLetraD().SetEconomico().SetMilitar().SetNumeroMaximo5().Edificio;

            ucFilaConstruccion2.Tipo = BuildingType.Economico;
            ucFilaConstruccion2.Inicializar(Construcciones(), new List<Resource>() { Resource.Oro, Resource.Oro, Resource.Army});
            ucFilaConstruccion1.Tipo = BuildingType.Militar;
            ucFilaConstruccion3.Tipo = BuildingType.Cultural;
            ucFilaConstruccion4.Tipo = BuildingType.Religioso;
            ucFilaConstruccion5.Tipo = BuildingType.Murallas;
        }

        private void customIconButton1_Click(object sender, EventArgs e)
        {
            new FrmBaseDialog().Show();
        }

        private IEnumerable<Construccion> Construcciones()
        {
            yield return new Construccion(EdificiosEconomicosFactory.Granja.Edificio, BuildingType.Economico, 0);
            yield return new Construccion(EdificiosEconomicosFactory.Mercado.Edificio, BuildingType.Economico, 1);
            yield return new Construccion(EdificiosEconomicosFactory.Molino.Edificio, BuildingType.Economico, 1);
            yield return new Construccion(EdificiosEconomicosFactory.CentroUrbano.Edificio, BuildingType.Economico, 2);
            yield return new Construccion(EdificiosEconomicosFactory.Molino.Edificio, BuildingType.Economico, 2);
            yield return new Construccion(EdificiosEconomicosFactory.CentroUrbano.Edificio, BuildingType.Economico, 2);
            yield return new Construccion(EdificiosEconomicosFactory.Molino.Edificio, BuildingType.Economico, 3);
            yield return new Construccion(EdificiosEconomicosFactory.CentroUrbano.Edificio, BuildingType.Economico, 3);
            yield return new Construccion(EdificiosEconomicosFactory.Molino.Edificio, BuildingType.Economico, 3);
            yield return new Construccion(EdificiosEconomicosFactory.CentroUrbano.Edificio, BuildingType.Economico, 3);
        }

        private void customIconButton1_Click_1(object sender, EventArgs e)
        {
            new FrmConstruccion().ShowDialog();
        }
    }
}
