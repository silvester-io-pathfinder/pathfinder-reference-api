using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClimbingClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("0a1b0e05-3a95-4b72-9a54-c7e92e15e732");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Climbing Claws",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a6b2242-bb02-4c13-8e7f-412b1ebb61d4"), Type = TextBlockType.Text, Text = "You can extend your claws to aid you in climbing. You gain a climb Speed of 10 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("811f31a1-ae3d-48eb-8312-898ed038cd31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
