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
    public class HuntingCatfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("f80d1769-c926-4cda-abf4-7cf62e605eec");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Hunting Catfolk", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("090263be-4f2c-45b8-ae4c-f2e00f750f87"), Type = TextBlockType.Text, Text = "You come from a long line of skilled hunters and trackers and have a particularly keen sense of smell. You gain imprecise scent with a range of 30 feet. This means you can use your sense of smell to determine a creature's location. The GM will usually double the range if you're downwind from the creature or halve the range if you're upwind." };
            yield return new TextBlock { Id = Guid.Parse("48aaa4ba-59d5-4f43-918a-ddb2469df8b3"), Type = TextBlockType.Text, Text = "In addition, you gain a +2 circumstance bonus to Track a creature or object if you've smelled it before." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("d2329aed-56a2-40f0-8fad-85cc08d7f211"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse("40a93d8e-4fc9-4fcd-840a-18553d1d85f1"), SkillActions.Instances.Track.ID, bonus: 1);        
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e478ec5-c980-433b-bb57-7aeaa7c11d5c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 9
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
        }
    }
}
