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
    public class BloodhoundShoony : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Bloodhound Shoony"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ancestors were famous trackers, and you carry in your blood that same gift of the hunt. You gain a special sense: imprecise scent with a range of 30 feet. This means you can use your sense of smell to determine the location of a creature, but it remains hidden. In addition, you gain a +2 circumstance bonus to Survival checks to Track creatures that you have previously sensed with your scent." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse(""), Skills.Instances.Survival.ID, SkillActions.Instances.Track.ID, bonus: 2, addendum: "Only applies to creatures that you have previously sensed with your scent.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.Pathfinder153.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Shoony.ID;
        }
    }
}
