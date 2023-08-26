using Comuni.Core.Resources;

using System.Drawing;

namespace Comuni.Core.Players;

public class CityFactory
{
    public static City Luca => new(1, "Luca", Color.DeepSkyBlue,
        new ResourceBuilder()
            .AddGold(2)
            .AddArmies(1)
            .AddPilgrims(3)
            .AddCraftsmen(1)
            .Build(),
        ResourceFactory.Pilgrim, null);

    public static City Firenze => new(2, "Firenze", Color.Purple,
         new ResourceBuilder()
            .AddGold(2)
            .AddArmies(1)
            .AddPilgrims(1)
            .AddCraftsmen(3)
            .Build(),
                ResourceFactory.Craftsman, null);

    public static City Siena => new(3, "Bologna", Color.ForestGreen,
         new ResourceBuilder()
            .AddGold(2)
            .AddArmies(3)
            .AddPilgrims(1)
            .AddCraftsmen(1)
            .Build(),
                ResourceFactory.Army, null);

    public static City Bologna => new(4, "Siena", Color.Red,
         new ResourceBuilder()
            .AddGold(3)
            .AddArmies(2)
            .AddPilgrims(1)
            .AddCraftsmen(1)
            .Build(),
        ResourceFactory.Gold, null);

    public static City Milano => new(5, "Milano", Color.Orange,
         new ResourceBuilder()
            .AddGold(2)
            .AddArmies(2)
            .AddPilgrims(2)
            .AddCraftsmen(2)
            .Build(),
            null, null);
}
