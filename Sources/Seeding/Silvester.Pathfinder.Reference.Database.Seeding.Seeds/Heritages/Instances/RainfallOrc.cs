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
    public class RainfallOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("1cc325a4-f149-4a56-bd20-83a968e5dc1d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rainfall Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c58cf4af-e471-428d-9845-f0be2329c2cd"), Type = TextBlockType.Text, Text = "You were born in a rain forest with only tangles of trees providing protection from torrential rainstorms and flash floods. You've learned to move adeptly through jungle terrain and resist the various ailments common in humid environs. You gain a +2 circumstance bonus to Athletics checks to Climb or Swim and a +1 circumstance bonus to saving throws against diseases." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("b1d5f9c6-5982-44c2-9084-8da3a6c8da26"), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, bonus: 1);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("ea97f29f-f06e-487a-9236-83002031851c"), Skills.Instances.Athletics.ID, SkillActions.Instances.Swim.ID, bonus: 1);
            builder.GainSpecificTraitAnySavingThrowCircumstanceBonus(Guid.Parse("6917e97e-bb27-4bcc-8f34-f697036a67a5"), Traits.Instances.Disease.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6c30628-8808-4245-a2bc-c047db219af6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 18
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
