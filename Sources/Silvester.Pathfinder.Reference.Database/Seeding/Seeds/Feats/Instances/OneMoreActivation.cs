using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneMoreActivation : Template
    {
        public static readonly Guid ID = Guid.Parse("8c33d5a4-84fd-41f8-9aa3-2e4519fa6cf3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One More Activation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0610ebc8-3828-4723-ae2d-41d126eadd03"), Type = TextBlockType.Text, Text = "You’ve forged a deeper connection to your invested items, allowing you to activate them more than usual. Once each day, you can (action: Activate an Item) you’ve invested even after you’ve used that activation the maximum number of times for its frequency. You can do so only if the item’s level is half your level or lower, has a frequency of once per day or more, and you haven’t already used the activation this round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b04a913b-da3f-4d9e-be5d-d20a1726c407"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
