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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You were born in a rain forest with only tangles of trees providing protection from torrential rainstorms and flash floods. You've learned to move adeptly through jungle terrain and resist the various ailments common in humid environs. You gain a +2 circumstance bonus to Athletics checks to Climb or Swim and a +1 circumstance bonus to saving throws against diseases." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse(""), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, bonus: 1);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse(""), Skills.Instances.Athletics.ID, SkillActions.Instances.Swim.ID, bonus: 1);
            builder.GainSpecificTraitAnySavingThrowCircumstanceBonus(Guid.Parse(""), Traits.Instances.Disease.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
