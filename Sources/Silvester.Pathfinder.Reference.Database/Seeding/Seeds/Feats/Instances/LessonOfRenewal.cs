using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfRenewal : Template
    {
        public static readonly Guid ID = Guid.Parse("b84b512e-74db-43b3-9b05-b9bfdaacff45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Renewal",
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
            yield return new TextBlock { Id = Guid.Parse("fb8214b6-61c8-492b-ad95-ac166213e329"), Type = TextBlockType.Text, Text = "~ Lesson Type: Major" };
            yield return new TextBlock { Id = Guid.Parse("b80a0e94-f380-4da1-885e-65f1e74228d4"), Type = TextBlockType.Text, Text = "You gain the (spell: restorative moment) hex, and your familiar learns (spell: field of life)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d92052be-27d4-4263-b4c6-4c1de324cdf2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
