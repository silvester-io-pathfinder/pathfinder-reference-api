using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoreRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("c77a6711-a269-4113-a6d2-e6af7227f6bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Core Rejuvenation",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You have the dying condition and are about to attempt a recovery check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9b1deea-1824-464e-85dc-330104101e04"), Type = TextBlockType.Text, Text = "Your soul taps into your core’s power to push against the grasp of death and allow you to recover consciousness. You’re restored to 1 Hit Point, lose the dying and unconscious conditions, and can act normally on this turn. You gain or increase the wounded condition as normal when losing the dying condition in this way." };
            yield return new TextBlock { Id = Guid.Parse("dd0d041e-c9ba-4ebd-9c72-78e080a6429b"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("e41a2410-0d7b-4b38-a984-1d56db12eae8"), Type = TextBlockType.Text, Text = "~ Enhancement: Your soul can draw even more power from your core, granting you additional benefits. When you use Core Rejuvenation, you also gain a number of temporary Hit Points equal to three times your level. These Hit Points remain for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4b2c685-caee-403a-9d95-efa7c92410b4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
