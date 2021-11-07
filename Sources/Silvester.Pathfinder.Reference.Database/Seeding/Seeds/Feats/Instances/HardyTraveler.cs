using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HardyTraveler : Template
    {
        public static readonly Guid ID = Guid.Parse("adc5d3d4-e5e9-45f3-acaa-952e7fc6bcb9");

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
            yield return new TextBlock { Id = Guid.Parse("b600c178-52f3-402d-a886-3dc6db9e5f76"), Type = TextBlockType.Text, Text = "There’s no journey too far or burden too heavy when your friends are at your side. Increase your maximum and encumbered Bulk limits by 1. In addition, you gain a +10-foot circumstance bonus to your Speed during overland travel." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1bfbb31-34f5-4487-97e3-a381b4626df2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
