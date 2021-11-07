using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleInitiative : Template
    {
        public static readonly Guid ID = Guid.Parse("93fde992-98fc-461e-bf4f-89bcaac89b0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Initiative",
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
            yield return new TextBlock { Id = Guid.Parse("52b86681-b592-49c7-8217-55faa4f6f249"), Type = TextBlockType.Text, Text = "You react more quickly than others can. You gain a +2 circumstance bonus to initiative rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("949149d0-a352-4b07-9ad0-8801ee79a94a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
