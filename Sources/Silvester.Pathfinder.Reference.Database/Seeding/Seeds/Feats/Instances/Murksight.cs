using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Murksight : Template
    {
        public static readonly Guid ID = Guid.Parse("767c28d5-c974-4479-b3bb-9df099da8b34");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Murksight",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5d197e0-920f-4769-8bac-6bb8f54933a2"), Type = TextBlockType.Text, Text = "Your vision pierces through non-magical fog, mist, rain, and snow. You don’t take circumstance penalties to ranged attacks or Perception checks caused by non-magical precipitation, and your targeted attacks don’t require a flat check to succeed against a target concealed only by such effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94d99574-958e-47c1-97d7-ece0cafdea36"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
