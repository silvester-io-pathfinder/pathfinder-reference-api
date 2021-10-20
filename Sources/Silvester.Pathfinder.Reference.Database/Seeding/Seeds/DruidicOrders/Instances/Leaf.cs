using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Diplomacy.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.LeshyFamiliar.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.Goodberry.ID
            };

            yield return new GainFocusPoolPointEffect
            {
                Id = Guid.Parse(""),
            };
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
