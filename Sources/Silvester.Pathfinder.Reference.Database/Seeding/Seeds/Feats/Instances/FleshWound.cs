using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FleshWound : Template
    {
        public static readonly Guid ID = Guid.Parse("815402b8-9cc0-4bd3-96ba-c6fc742db04b");

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
            yield return new TextBlock { Id = Guid.Parse("55309ce6-bc9c-4948-82c1-d1b71b42e4f8"), Type = TextBlockType.Text, Text = "You fire to ensure that even if your shot doesn’t land cleanly, it still lands close enough to deal some damage. Make a ranged (action: Strike). It gains the following effect on a failure (though not a critical failure)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ed86c4e1-f877-4353-b835-b67a7f41d97c"),
                
                
                Failure = "Though your attack misses, it still deals one die of damage plus any damage from your weapon specialization class feature. This uses your weapon’s normal damage die and damage type. This attack doesn’t add extra damage from any other sources or abilities.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17254592-3ff6-4ecb-be1d-05de39a0398e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
