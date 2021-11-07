using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnwaveringMien : Template
    {
        public static readonly Guid ID = Guid.Parse("d4f06292-fab2-4ab1-93b8-4d757e590f6c");

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
            yield return new TextBlock { Id = Guid.Parse("5f2c2044-9afe-4fe1-b17b-e03968e29e5d"), Type = TextBlockType.Text, Text = "Your mystic control and meditations allow you to resist external influences upon your consciousness. Whenever you are affected by a mental effect that lasts at least 2 rounds, you can reduce the duration by 1 round." };
            yield return new TextBlock { Id = Guid.Parse("17164ceb-913c-4f16-bdce-c4f7bd1ac664"), Type = TextBlockType.Text, Text = "You still require natural sleep, but you treat your saving throws against effects that would cause you to fall asleep as one degree of success better. This protects only against sleep effects, not against other forms of falling unconscious." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6beb0deb-0409-4650-a159-1e041ff775e6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
