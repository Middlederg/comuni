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

            ucEdificio1.Edificio = EconomicBuildingFactory.Farm.Building;
            ucEdificio2.Edificio = EconomicBuildingFactory.Market.Building;
            //ucEdificio2.Edificio = EdificiosCulturalesFactory.Universidad.Edificio;
            ucEdificio3.Edificio = MilitaryBuildingFactory.Fortress.Building;
            ucEdificio4.Edificio = ReligousBuildingFactory.Church.Building;

            //ucEdificio1.Edificio = new EdificioBuilder(4, "Palacio").SetLetraD().SetEconomico().SetCultural().SetNumeroMaximo3().Edificio;
            //ucEdificio2.Edificio = new EdificioBuilder(4, "Templo de la orden").SetLetraD().SetMilitar().SetReligioso().SetNumeroMaximo3().Edificio;
            //ucEdificio3.Edificio = new EdificioBuilder(4, "Seminario").SetLetraD().SetReligioso().SetCultural().SetNumeroMaximo5().Edificio;
            //ucEdificio4.Edificio = new EdificioBuilder(4, "Ciudadela").SetLetraD().SetEconomico().SetMilitar().SetNumeroMaximo5().Edificio;

            ucFilaConstruccion2.Tipo = BuildingType.Economic;
            ucFilaConstruccion2.Inicializar(Construcciones(), new List<Resource>() { Resource.Oro, Resource.Oro, Resource.Army});
            ucFilaConstruccion1.Tipo = BuildingType.Military;
            ucFilaConstruccion3.Tipo = BuildingType.Cultural;
            ucFilaConstruccion4.Tipo = BuildingType.Religious;
            ucFilaConstruccion5.Tipo = BuildingType.Walls;
        }

        private void customIconButton1_Click(object sender, EventArgs e)
        {
            new FrmBaseDialog().Show();
        }

        private IEnumerable<Construction> Construcciones()
        {
            yield return new Construccion(EconomicBuildingFactory.Farm.Building, BuildingType.Economic, 0);
            yield return new Construccion(EconomicBuildingFactory.Market.Building, BuildingType.Economic, 1);
            yield return new Construccion(EconomicBuildingFactory.Mill.Building, BuildingType.Economic, 1);
            yield return new Construccion(EconomicBuildingFactory.UrbanCentre.Building, BuildingType.Economic, 2);
            yield return new Construccion(EconomicBuildingFactory.Mill.Building, BuildingType.Economic, 2);
            yield return new Construccion(EconomicBuildingFactory.UrbanCentre.Building, BuildingType.Economic, 2);
            yield return new Construccion(EconomicBuildingFactory.Mill.Building, BuildingType.Economic, 3);
            yield return new Construccion(EconomicBuildingFactory.UrbanCentre.Building, BuildingType.Economic, 3);
            yield return new Construccion(EconomicBuildingFactory.Mill.Building, BuildingType.Economic, 3);
            yield return new Construccion(EconomicBuildingFactory.UrbanCentre.Building, BuildingType.Economic, 3);
        }

        private void customIconButton1_Click_1(object sender, EventArgs e)
        {
            new FrmConstruccion().ShowDialog();
        }
    }
}
