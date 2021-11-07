using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CorneredFury : Template
    {
        public static readonly Guid ID = Guid.Parse("4b19d279-5516-4419-abe7-890d615e7d81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cornered Fury",
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
            yield return new TextBlock { Id = Guid.Parse("62b7a836-c99c-4cbb-b94d-ca53bae53fe1"), Type = TextBlockType.Text, Text = "When physically outmatched, you fight with unexpected ferocity. If a foe of a larger size than you critically hits and damages you, that foe is flat-footed to you for 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03eebf9b-d9c0-45ba-b795-e77d7fbdf188"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
