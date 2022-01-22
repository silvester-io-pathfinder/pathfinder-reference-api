using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HardyTraveler : Template
    {
        public static readonly Guid ID = Guid.Parse("dd9634e1-294b-4f2b-98ca-7d47f2489ba8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hardy Traveler",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("64cc6a0f-b4db-43a5-8571-5d3517e58326"), Type = TextBlockType.Text, Text = $"There's no journey too far or burden too heavy when your friends are at your side. Increase your maximum and encumbered Bulk limits by 1. In addition, you gain a +10-foot circumstance bonus to your Speed during overland travel." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86f86d55-5750-4f25-9916-4c700bdf27cd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
