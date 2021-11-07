using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Wortwitch : Template
    {
        public static readonly Guid ID = Guid.Parse("76ab7180-a51b-4e9b-8b7f-c73aa21c6e20");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wortwitch",
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
            yield return new TextBlock { Id = Guid.Parse("eec82bf2-0bd2-4148-98e3-76534a01ab90"), Type = TextBlockType.Text, Text = "You have a particular affinity for leafy plants. Your patron grants you a leshy familiar. If you already had a familiar, this leshy replaces your previous familiar, as if your previous familiar had been slain. In addition, you gain the ability to see through leaves, vines, and other foliage. You don’t take circumstance penalties to ranged spell attacks or Perception checks caused by foliage, and your targeted attacks don’t require a flat check to succeed against a target concealed only by such vegetation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a6641af-54a2-4762-8ef0-f49904cf3ea3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
