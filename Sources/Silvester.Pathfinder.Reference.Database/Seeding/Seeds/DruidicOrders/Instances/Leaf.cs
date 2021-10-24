using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders.Instances
{
    public class Leaf : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Leaf",
                Description = "You revere plants and the bounty of nature, acting as both a gardener and warden for the wilderness, teaching sustainable techniques to communities, and helping areas regrow after disasters or negligent humanoid expansion. You are trained in Diplomacy. You also gain the Leshy Familiar druid feat. You gain the goodberry order spell, and you increase the number of Focus Points in your focus pool by 1. Committing wanton cruelty to plants or killing plants unnecessarily is anathema to your order. (This doesn’t prevent you from defending yourself against plants or harvesting them when necessary for survival.)",
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.LeshyFamiliar.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Goodberry.ID);
            builder.GainFocusPoolPoint(Guid.Parse(""));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 131
            };
        }
    }
}
