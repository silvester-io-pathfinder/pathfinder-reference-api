using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinShotKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("1962cc23-3fea-471e-bb1b-f6c32b1e0c8a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Shot Knockdown",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42c39630-27b6-40c2-9ef7-74c664199b31"), Type = TextBlockType.Text, Text = "You fire at an enemy while targeting a part of its anatomy that will disrupt its balance. Make two (action: Strikes|Strike) against the same target, one with each of the required weapons. If both (action: Strikes|Strike) are successful, the target is also knocked prone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("865cbb84-10c9-42ec-b640-c4e44fb0b10e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
