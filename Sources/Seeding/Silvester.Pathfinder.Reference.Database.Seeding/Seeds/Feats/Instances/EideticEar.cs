using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EideticEar : Template
    {
        public static readonly Guid ID = Guid.Parse("9549d007-883a-4298-957a-1e60392d791d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidetic Ear",
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
            yield return new TextBlock { Id = Guid.Parse("2e41f1d4-90b2-4013-9a7d-6d347b82263e"), Type = TextBlockType.Text, Text = "You have an amazing memory for sound. You gain the (feat: Assurance) (Performance) feat. With a successful DC 8 flat check, you can accurately recall a sound or a snippet of conversation you heard within the last week. You are memorizing by rote rather than content, and can’t use this to cram facts, so this doesn’t grant you any extra ability to (action: Recall Knowledge)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c84b09f5-1579-455d-9056-668cae62485e"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
