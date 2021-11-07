using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EideticEar : Template
    {
        public static readonly Guid ID = Guid.Parse("ef0502a8-bfc2-45b1-8648-aa33640f7d03");

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
            yield return new TextBlock { Id = Guid.Parse("d3bd16fe-e8f0-4577-ad57-e18aa977f96f"), Type = TextBlockType.Text, Text = "You have an amazing memory for sound. You gain the (feat: Assurance) (Performance) feat. With a successful DC 8 flat check, you can accurately recall a sound or a snippet of conversation you heard within the last week. You are memorizing by rote rather than content, and can’t use this to cram facts, so this doesn’t grant you any extra ability to (action: Recall Knowledge)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2671382-e39b-4d61-b9cf-98870b5b4111"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
