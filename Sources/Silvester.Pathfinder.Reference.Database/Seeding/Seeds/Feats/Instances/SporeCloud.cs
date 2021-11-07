using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SporeCloud : Template
    {
        public static readonly Guid ID = Guid.Parse("28930781-600e-4236-b104-86b6fdacc451");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spore Cloud",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70505ed5-d7f0-4183-948d-e486196182d6"), Type = TextBlockType.Text, Text = "You unleash a cloud of pollen or similar spores. All creatures in a 10-foot emanation around you must attempt a Fortitude save using your class DC or spell DC (whichever is higher) with the following results. Plants and fungi are immune to this effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("36196c4e-5893-4eb2-8f2a-33766d3236f4"),
                CriticalSuccess = "No effect.",
                Success = "The creature is dazzled for 1 round.",
                Failure = "The creature is dazzled and can see only 10 feet away for 1 round.",
                CriticalFailure = "The creature is blinded for 1 round.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0dd55ce-3058-4cc6-9943-d45077642190"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
