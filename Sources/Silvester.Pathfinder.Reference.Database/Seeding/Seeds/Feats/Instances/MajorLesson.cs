using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MajorLesson : Template
    {
        public static readonly Guid ID = Guid.Parse("990f56db-05a8-4a52-8199-c23a7b9ed555");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Major Lesson",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat a second time if you're 14th level or higher, and a third time if you're 18th level or higher. Choose a different lesson each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("832acb25-7d58-4d21-9aa9-30f29b5fe44a"), Type = TextBlockType.Text, Text = "Your patron grants you even greater secrets. Choose a major, greater, or basic lesson. You gain its associated hex, and your familiar learns the associated spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9c8033b-a421-4d24-bfe8-d72988b7d31f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
