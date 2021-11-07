using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WebHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("a58f95a0-711a-436f-81e2-d377d086b8f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Web Hunter",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c6bc2e5-d342-4fc0-9a47-6943b06cfcf9"), Type = TextBlockType.Text, Text = "Through the careful cultivation of highly sensitive hairs, you’ve developed the ability to sense creatures without seeing them. You gain imprecise tremorsense at a range of 15 feet. When you and a creature are both touching the same anchored, threadlike object (such as a rope, webbing, or wire), your imprecise tremorsense can sense that creature at a range of 60 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0129dfb4-d949-462f-854a-5ea696dfe16e"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
