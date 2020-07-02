﻿using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace DiplomacyFixes.DiplomaticAction.NonAggressionPact
{
    class HasEnoughGoldCondition : IDiplomacyCondition
    {
        public bool ApplyCondition(Kingdom kingdom, Kingdom otherKingdom, out TextObject textObject, bool forcePlayerCharacterCosts = false)
        {
            textObject = null;
            bool hasEnoughGold = DiplomacyCostCalculator.DetermineCostForFormingNonAggressionPact(kingdom, otherKingdom, forcePlayerCharacterCosts).GoldCost.CanPayCost();
            if (!hasEnoughGold)
            {
                textObject = new TextObject(StringConstants.NOT_ENOUGH_GOLD);
            }
            return hasEnoughGold;
        }
    }
}
