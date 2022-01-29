using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgelessPatience : Template
    {
        public static readonly Guid ID = Guid.Parse("2c99e99d-e1e8-4905-9f79-11417aeacf82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ageless Patience",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8a9f006-44a2-45a3-ad60-5456648a4876"), Type = TextBlockType.Text, Text = $"You work at a pace born from longevity that enhances your thoroughness. You can voluntarily spend twice as much time as normal on a Perception check or skill check to gain a +2 circumstance bonus to that check. You also don't treat a natural 1 as worse than usual on these checks; you get a critical failure only if your result is 10 lower than the DC. For example, you could get these benefits if you spent 2 actions to Seek, which normally takes 1 action. You can get these benefits during exploration by taking twice as long exploring as normal, or in downtime by spending twice as much downtime." };
            yield return new TextBlock { Id = Guid.Parse("3a90ec62-ca63-446a-960a-96bf7586d4f5"), Type = TextBlockType.Text, Text = $"The GM might determine a situation doesn't grant you a benefit if a delay would be directly counterproductive to your success, such as a tense negotiation with an impatient creature." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Elf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f8e8292-7e99-4944-bc13-c707b7fc46ec"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
