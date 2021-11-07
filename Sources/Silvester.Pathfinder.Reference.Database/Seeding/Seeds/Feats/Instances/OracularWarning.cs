using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OracularWarning : Template
    {
        public static readonly Guid ID = Guid.Parse("de123484-b92c-4369-b457-0c96330cf2f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oracular Warning",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("122c2102-2645-444e-ad5f-6b0f2d9ddbaa"), Type = TextBlockType.Text, Text = "You have a flash of insight about impending danger related to one ally, and you can shout or gesture to warn that ally of the threat a moment before it materializes. One ally of your choice can roll twice for initiative and use the better result; this is a (trait: fortune) effect. If you are legendary in Religion, you receive two visions and can warn two allies, granting them both this benefit." };
            yield return new TextBlock { Id = Guid.Parse("23f2ac5f-6eb6-486e-a809-7e85423b6179"), Type = TextBlockType.Text, Text = "You are momentarily thrown off by the divine insight, however, and you must roll twice for your initiative roll and use the worse result. This is a (trait: misfortune) effect. The two effects are tied together; if you would avoid the misfortune effect for any reason, or if any of your allies would negate their fortune effect, your Oracular Warning does nothing. Depending on whether you use gestures or call out, this action gains either the (trait: visual) or (trait: auditory) trait, respectively." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ef75b2f-d449-481f-a007-caef3d876a1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
