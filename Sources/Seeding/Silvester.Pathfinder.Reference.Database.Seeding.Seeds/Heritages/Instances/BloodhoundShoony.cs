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
        public static readonly Guid ID = Guid.Parse("ce2ef1e7-30aa-405b-b82b-7af585ec9c4d");

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
            yield return new TextBlock { Id = Guid.Parse("8a140ca7-64c2-4217-bab2-4b005a6c1f39"), Type = TextBlockType.Text, Text = "Your ancestors were famous trackers, and you carry in your blood that same gift of the hunt. You gain a special sense: imprecise scent with a range of 30 feet. This means you can use your sense of smell to determine the location of a creature, but it remains hidden. In addition, you gain a +2 circumstance bonus to Survival checks to Track creatures that you have previously sensed with your scent." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("68cb588d-057e-4dce-b3ce-8726d67cf03f"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("01742fa5-f04b-489f-827d-a1239a083ade"), Skills.Instances.Survival.ID, SkillActions.Instances.Track.ID, bonus: 2, addendum: "Only applies to creatures that you have previously sensed with your scent.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a663c3cc-8a4c-4ab8-8a75-6d94c12e12ee"),
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
