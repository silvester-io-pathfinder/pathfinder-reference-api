using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpressiveLanding : Template
    {
        public static readonly Guid ID = Guid.Parse("7f7934be-6020-4601-935a-0003d6f8b7c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impressive Landing",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fall at least 10 feet and land on a solid surface.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7ba1c2a-c255-4cda-b3bc-e58433250ea1"), Type = TextBlockType.Text, Text = "You slam into the ground, shattering it around you. Treat the fall as 10 feet shorter. You land on your feet. All adjacent spaces become difficult terrain, and creatures in those spaces when you land take 5 bludgeoning damage as the debris hits them and are flat-footed until the start of their next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9c65108-472b-4239-996d-5e8698674420"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
