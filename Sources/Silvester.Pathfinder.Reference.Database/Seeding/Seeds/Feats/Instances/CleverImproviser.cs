using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CleverImproviser : Template
    {
        public static readonly Guid ID = Guid.Parse("fcce7725-3b2c-480d-8548-b446946bff22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clever Improviser",
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
            yield return new TextBlock { Id = Guid.Parse("8988342c-50f0-4f38-b1aa-914794a71b8b"), Type = TextBlockType.Text, Text = "You’ve learned how to handle situations when you’re out of your depth. You gain the (feat: Untrained Improvisation) general feat. In addition, you can attempt skill actions that normally require you to be trained, even if you are untrained." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e14692a4-a852-4bad-8906-0eb2cb745196"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
