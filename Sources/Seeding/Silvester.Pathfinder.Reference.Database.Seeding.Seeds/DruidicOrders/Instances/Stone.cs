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
        public static readonly Guid ID = Guid.Parse("70e719b4-47df-4a8d-9307-e94a5ee06825");
        
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
            builder.GainSpecificSkillProficiency(Guid.Parse("0c64ddfe-b625-486b-9592-c63b3a3eac3d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificFeat(Guid.Parse("15f8c8ba-4f9b-41a6-a75c-9668798e88f6"), Feats.Instances.SteadyingStone.ID);
            builder.GainSpecificSpell(Guid.Parse("f7ee43e8-a0ba-4df9-b04d-6a4d9ddfe470"), Spells.Instances.CrushingGround.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0da8dd46-496a-48e0-bc2a-731ee2a92b71"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 198
            };
        }
    }
}
