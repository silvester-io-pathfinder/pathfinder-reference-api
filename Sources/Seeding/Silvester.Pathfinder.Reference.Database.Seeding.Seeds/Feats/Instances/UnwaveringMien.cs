using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnwaveringMien : Template
    {
        public static readonly Guid ID = Guid.Parse("759f25e5-2b07-4114-bfc7-b73e6662d76f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unwavering Mien",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da659ae0-6864-4d3a-a233-23cbb408b1ac"), Type = TextBlockType.Text, Text = $"Your mystic control and meditations allow you to resist external influences upon your consciousness. Whenever you are affected by a mental effect that lasts at least 2 rounds, you can reduce the duration by 1 round." };
            yield return new TextBlock { Id = Guid.Parse("fa0f9297-7d72-4b1f-ae16-3930256e5e38"), Type = TextBlockType.Text, Text = $"You still require natural sleep, but you treat your saving throws against effects that would cause you to fall asleep as one degree of success better. This protects only against sleep effects, not against other forms of falling unconscious." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf41ca38-0647-47a3-bfe5-6c3afe698832"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
