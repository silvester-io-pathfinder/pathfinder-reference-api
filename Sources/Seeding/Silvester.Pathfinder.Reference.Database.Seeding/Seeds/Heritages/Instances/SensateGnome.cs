using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SensateGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("d4c74254-f221-41a2-b2b9-2d8ad741cbc0");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Sensate Gnome"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fa01fced-6292-48ce-90df-c1e78bb7a5f4"), Type = TextBlockType.Text, Text = "You see all colors as brighter, hear all sounds as richer, and especially smell all scents with incredible detail. You gain a special sense: imprecise scent with a range of 30 feet. This means you can use your sense of smell to determine the exact location of a creature. The GM will usually double the range if you're downwind from the creature or halve the range if you're upwind." };
            yield return new TextBlock { Id = Guid.Parse("e30ea7be-2b7c-4fe9-b543-a79ee504d749"), Type = TextBlockType.Text, Text = "In addition, you gain a + 2 circumstance bonus to Perception checks whenever you're trying to locate an undetected creature that is within the range of your scent." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("f2c255bc-a6b9-47f8-a308-c4bd754956f0"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificSkillCircumstanceBonus(Guid.Parse("0cdf0a47-baee-43f5-9c27-1dfc28d8ceb3"), Skills.Instances.Perception.ID, bonus: 2, addendum: "Only applies when you're trying to locate an undetected creature that is within the range of your scent.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d271e493-a4cf-4e91-b715-48e0f45206a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 44
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnome.ID;
        }
    }
}
