using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FleshWound : Template
    {
        public static readonly Guid ID = Guid.Parse("10ce20e1-d3ba-47da-919a-eec841b18863");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flesh Wound",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3abe3580-270a-40c5-a090-e9f46db12d61"), Type = TextBlockType.Text, Text = "You fire to ensure that even if your shot doesn't land cleanly, it still lands close enough to deal some damage. Make a ranged (action: Strike). It gains the following effect on a failure (though not a critical failure)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d7c7cf76-b495-4707-9b18-16fe298e53b5"),
                
                
                Failure = "Though your attack misses, it still deals one die of damage plus any damage from your weapon specialization class feature. This uses your weapon's normal damage die and damage type. This attack doesn't add extra damage from any other sources or abilities.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8ffe8f0-ab16-4ff1-9176-b854c3271702"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
