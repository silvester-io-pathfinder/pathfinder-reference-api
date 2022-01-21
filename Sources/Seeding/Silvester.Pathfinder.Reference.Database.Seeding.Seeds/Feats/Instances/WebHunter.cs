using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WebHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("16d28b1e-27dd-4bcb-8347-2a52a4c97098");

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
            yield return new TextBlock { Id = Guid.Parse("e32ee5f2-0b07-4493-9f19-75ae843691fd"), Type = TextBlockType.Text, Text = "Through the careful cultivation of highly sensitive hairs, you've developed the ability to sense creatures without seeing them. You gain imprecise tremorsense at a range of 15 feet. When you and a creature are both touching the same anchored, threadlike object (such as a rope, webbing, or wire), your imprecise tremorsense can sense that creature at a range of 60 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("391ead7f-4681-49ac-92d3-b4702578b8b6"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
