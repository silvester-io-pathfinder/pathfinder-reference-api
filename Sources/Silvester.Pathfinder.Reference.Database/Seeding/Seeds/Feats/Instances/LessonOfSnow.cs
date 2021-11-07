using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfSnow : Template
    {
        public static readonly Guid ID = Guid.Parse("46612a72-e051-4bb1-805d-900fac196992");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Snow",
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
            yield return new TextBlock { Id = Guid.Parse("aad75015-7a02-46bd-86a7-93e12159e89d"), Type = TextBlockType.Text, Text = "~ Lesson Type: Greater" };
            yield return new TextBlock { Id = Guid.Parse("0b4d0a8f-c090-4fa0-a0f7-74f31c881692"), Type = TextBlockType.Text, Text = "You gain the (spell: personal blizzard) hex, and your familiar learns (spell: wall of wind)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef3e737f-0695-4276-993a-aea1ee197faa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
