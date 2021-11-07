using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MultifariousMuse : Template
    {
        public static readonly Guid ID = Guid.Parse("0a9ee014-81fe-4f76-80bb-3f7e30ed1ccc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multifarious Muse",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat multiple times. Each time you do, you must choose a different type of muse other than that of your own.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04fbe98b-643f-4d19-ae10-6b2c27ad5598"), Type = TextBlockType.Text, Text = "Your muse doesn’t fall into a single label. Choose a type of muse other than that of your own. You gain a 1st-level feat that requires that muse, and your muse is now also a muse of that type, allowing you to take feats with the other muse as a prerequisite. You don’t gain any of the other effects of the muse you chose." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bea042f-7005-4bc2-a39a-ea711f540388"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
