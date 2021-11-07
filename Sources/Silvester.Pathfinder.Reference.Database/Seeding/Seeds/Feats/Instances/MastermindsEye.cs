using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MastermindsEye : Template
    {
        public static readonly Guid ID = Guid.Parse("69bfc507-86c9-4d1f-9fff-6d89b15b81d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mastermind's Eye",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b2a4641e-6fa6-488b-9c3e-216cc444d865"), Type = TextBlockType.Text, Text = "When you succeed at identifying a creature using (action: Recall Knowledge), that creature is flat-footed against your attacks until the start of your next turn; if you critically succeed, it&#39;s flat-footed against your attacks for 1 minute. This feat serves as the rogue&#39;s mastermind racket for the purpose of meeting prerequisites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38f6997c-ed4e-47db-bf20-af45dab145f8"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
