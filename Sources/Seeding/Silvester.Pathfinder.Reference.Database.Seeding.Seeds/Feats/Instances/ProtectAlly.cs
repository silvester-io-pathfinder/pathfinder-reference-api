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
    public class ProtectAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("7207417f-3efa-45c9-a177-08bcd4dceaee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Protect Ally",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b784dd8c-0c3c-4cdf-95fa-8aa4be71da3b"), Type = TextBlockType.Text, Text = $"You place your body between your friends and your enemies, protecting your allies against oncoming attacks. You choose one adjacent ally. That ally gains a +1 circumstance bonus to AC until the start of your next turn or until that ally is no longer adjacent to you, whichever comes first. You can only protect a single ally in this way. If you choose to Protect a different Ally, the previous ally loses the bonus to AC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0909a1ed-a1f9-43e6-9645-cb2549361fa8"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("62693e1e-c2cb-415e-8609-0700485f53ef"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77602f51-9a81-4259-b509-915faeb447a5"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
