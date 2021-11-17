using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SporeCloud : Template
    {
        public static readonly Guid ID = Guid.Parse("c9e4f02e-6b8a-4640-95b5-33e3d5282d46");

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
            yield return new TextBlock { Id = Guid.Parse("e11a59f9-1fa3-4ca0-847e-20ef8aa74803"), Type = TextBlockType.Text, Text = "You unleash a cloud of pollen or similar spores. All creatures in a 10-foot emanation around you must attempt a Fortitude save using your class DC or spell DC (whichever is higher) with the following results. Plants and fungi are immune to this effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d815cd79-700a-41e4-acf4-39d04207bbb7"),
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
                Id = Guid.Parse("6f92158f-afe4-4b29-b0d1-09c5020f6497"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
