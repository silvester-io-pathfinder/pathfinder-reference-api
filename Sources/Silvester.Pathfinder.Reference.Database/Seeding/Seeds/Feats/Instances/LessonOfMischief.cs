using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfMischief : Template
    {
        public static readonly Guid ID = Guid.Parse("0dab11df-4aaa-41cb-a8e4-37bdddb70bc5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Mischief",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0da3e92-ec1a-4aa8-8463-100f5e63f05a"), Type = TextBlockType.Text, Text = "~ Lesson Type: Greater" };
            yield return new TextBlock { Id = Guid.Parse("3ba2f7ec-9ba7-4ab0-bd6a-7308e8a17831"), Type = TextBlockType.Text, Text = "You gain the (spell: deceiver&#39;s cloak) hex, and your familiar learns (spell: mad monkeys)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f13738ed-1e97-464a-941f-7fae934478d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
