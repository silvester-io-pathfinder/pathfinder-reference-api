using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders.Instances
{
    public class Stone : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Stone",
                Description = "You're as enduring as stone, and you take comfort in its steadfast presence, both natural and worked. You're trained in Crafting. You also gain the Steadying Stone druid feat. You gain the crushing ground order spell. Poisoning or polluting the land and heedlessly carving the earth to plunder its natural resources are anathema to your order (this doesn't prevent you from responsibly digging or mining).",
            };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Crafting.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.SteadyingStone.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.CrushingGround.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 
            };
        }
    }
}
