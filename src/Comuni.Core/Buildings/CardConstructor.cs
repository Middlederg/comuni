﻿using Comuni.Core.Players;

namespace Comuni.Core.Buildings;

public class CardConstructor
{
    private readonly Player player;

    public CardConstructor(Player player)
    {
        this.player = player;
    }

    public bool CanBeBuild(ConstructionSlot slot, Building card, bool isFirstTurn)
    {
        if (!slot.CanBePlaced(card))
            return false;

        int cost = slot.Cost(card, isFirstTurn);

        return cost > player.Resources.Craftsmans;
    }

    public void Build(ConstructionSlot slot, Building card, bool isFirstTurn)
    {
        if (!CanBeBuild(slot, card, isFirstTurn))
            throw new DomainException($"Card {card} can not be build in slot {this}");

        int cost = slot.Cost(card, isFirstTurn);

        player.Resources.PayCraftsmen(cost);

    }
}
