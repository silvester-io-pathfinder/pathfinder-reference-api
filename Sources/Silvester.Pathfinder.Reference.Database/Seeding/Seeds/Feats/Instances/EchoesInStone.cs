using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EchoesInStone : Template
    {
        public static readonly Guid ID = Guid.Parse("f460c588-75f6-4e4c-8ca1-454f4d0ffab4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Echoes in Stone",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fcf8996d-b643-4833-90fa-f9f4e0f16475"), Type = TextBlockType.Text, Text = "You pause a moment to attune your senses to the stone around you. Until the start of your next turn, you gain a new sense: imprecise tremorsense with a range of 20 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f8ac048-4c8b-43f7-9159-8aeb11730ae7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
