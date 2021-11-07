using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EarnedGlory : Template
    {
        public static readonly Guid ID = Guid.Parse("a6a5de50-452a-4616-9c1c-57882f717f0c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Earned Glory",
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
            yield return new TextBlock { Id = Guid.Parse("78c343b9-b476-4ff9-a79c-51a5a0af31f8"), Type = TextBlockType.Text, Text = "Elves are often skeptical of their half-elven kin, and you are experienced at telling stories of your accomplishments to gain their respect. You are trained in Performance. If you would automatically become trained in Performance (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("329dec9c-65e2-411e-af74-20581835e401"), Type = TextBlockType.Text, Text = "You gain the (feat: Impressive Performance) feat. When you attempt a Performance check to (action: Make an Impression) on an elf, if you roll a critical failure, you get a failure instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76dc6716-1bae-4103-bbfe-704c3b8cf382"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
