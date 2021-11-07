using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrototypeCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("6d885962-3260-45e5-b938-261eda30e42b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prototype Companion",
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
            yield return new TextBlock { Id = Guid.Parse("d427f5c7-98fa-45f4-9c9d-c256a08f7ed7"), Type = TextBlockType.Text, Text = "You have created a construct companion, and while it might not be an innovation, it serves as a trustworthy minion. You gain a prototype construct companion (G&amp;G pg. 32)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2793f1de-6448-407f-933d-db9055281390"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
