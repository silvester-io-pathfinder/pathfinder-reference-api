using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Grig : Template
    {
        public static readonly Guid ID = Guid.Parse("8711e88a-3b4d-4003-bedb-e2552a84e179");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Grig"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("94a67ba0-433e-4dd4-a6be-b4efc982dda2"), Type = TextBlockType.Text, Text = "You have the hindquarters of a cricket and adore art and music. Your cricket legs grant you a +2 circumstance bonus on Athletics checks to High Jump or Long Jump, and you gain ghost sound as a primal innate cantrip." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("2610fa83-5512-4c47-b66f-675c741bc7a7"), Skills.Instances.Athletics.ID, SkillActions.Instances.HighJump.ID, bonus: 2);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("861bd00e-5615-41e6-9079-633b5922d438"), Skills.Instances.Athletics.ID, SkillActions.Instances.LongJump.ID, bonus: 2);
            builder.GainSpecificInnateSpell(Guid.Parse("b1396fee-b78d-403e-afb6-df1fe97eca6f"), Spells.Instances.GhostSound.ID, MagicTraditions.Instances.Primal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe547574-c887-4d34-97b9-75e21c769c66"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 129
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Sprite.ID;
        }
    }
}
