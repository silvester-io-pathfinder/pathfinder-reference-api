using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FollowUpAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("0f8790ba-e0b8-4cfa-a1e9-f58a356b2cf5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Follow-Up Assault",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("089bf0e3-48c1-438e-819b-6d638a97312b"), Type = TextBlockType.Text, Text = "Even in the face of failure you press the attack, determined to succeed. Make a (action: Strike) with the same weapon, adding the effects of the (trait: backswing) and (trait: forceful) weapon traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49ca9354-1392-468b-b650-e4de64716bcc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
