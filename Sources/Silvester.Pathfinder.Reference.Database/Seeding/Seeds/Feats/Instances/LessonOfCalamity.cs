using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfCalamity : Template
    {
        public static readonly Guid ID = Guid.Parse("eb7ef350-943b-4c6c-b757-1076c494b93b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Calamity",
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
            yield return new TextBlock { Id = Guid.Parse("7388cd3b-5b3d-4fbf-a6d7-a00c6eefbf7b"), Type = TextBlockType.Text, Text = "~ Lesson Type: Basic" };
            yield return new TextBlock { Id = Guid.Parse("f991cb05-d6f1-441b-b313-33562c66b81f"), Type = TextBlockType.Text, Text = "You gain the (spell: stumbling curse) hex, and your familiar learns (spell: ill omen)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36970d13-6c7e-486b-a830-419686e7d269"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
