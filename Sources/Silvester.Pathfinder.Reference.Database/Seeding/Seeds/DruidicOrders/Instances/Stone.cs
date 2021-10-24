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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.SteadyingStone.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CrushingGround.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 198
            };
        }
    }
}
