using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("cc3d5770-499a-4312-aca0-3e8739398d29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Shadow",
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
            yield return new TextBlock { Id = Guid.Parse("178cf9db-f480-4478-bcf8-9c613af038a7"), Type = TextBlockType.Text, Text = "~ Lesson Type: Greater" };
            yield return new TextBlock { Id = Guid.Parse("7b2bae56-1f96-4fe6-b2d9-0ff48e838053"), Type = TextBlockType.Text, Text = "You gain the (spell: malicious shadow) hex, and your familiar learns (spell: chilling darkness)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73219b9d-6e98-417b-b5e8-0df6280ab0eb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
