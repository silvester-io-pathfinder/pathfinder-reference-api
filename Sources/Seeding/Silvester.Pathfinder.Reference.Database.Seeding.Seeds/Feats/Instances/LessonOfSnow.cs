using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfSnow : Template
    {
        public static readonly Guid ID = Guid.Parse("8fb5e878-92b8-4ee0-b799-69f64619ff43");

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
            yield return new TextBlock { Id = Guid.Parse("c4009cb3-c4a1-47e7-aa0e-48949d97711a"), Type = TextBlockType.Text, Text = "~ Lesson Type: Greater" };
            yield return new TextBlock { Id = Guid.Parse("3fd6512a-fc49-4265-9484-bb91b2c08596"), Type = TextBlockType.Text, Text = "You gain the (spell: personal blizzard) hex, and your familiar learns (spell: wall of wind)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36840961-4d9c-459d-8ecd-5dd8c2381135"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
