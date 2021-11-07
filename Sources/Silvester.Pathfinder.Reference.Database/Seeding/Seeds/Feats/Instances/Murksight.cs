using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Murksight : Template
    {
        public static readonly Guid ID = Guid.Parse("8d4227f0-cb2f-48ae-92e4-e957bc9ebd26");

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
            yield return new TextBlock { Id = Guid.Parse("9bd47d37-3233-4a7c-9136-60d51e5e0396"), Type = TextBlockType.Text, Text = "Your vision pierces through non-magical fog, mist, rain, and snow. You don’t take circumstance penalties to ranged attacks or Perception checks caused by non-magical precipitation, and your targeted attacks don’t require a flat check to succeed against a target concealed only by such effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("544eea21-cf97-44c1-86d7-8873b48e064c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
