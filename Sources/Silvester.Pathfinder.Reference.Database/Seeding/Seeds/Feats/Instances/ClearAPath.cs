using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClearAPath : Template
    {
        public static readonly Guid ID = Guid.Parse("298bcb98-7faa-4407-89b3-11e595d0ae9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clear a Path",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85e22329-1585-4295-b5f6-a00ff14ae6c5"), Type = TextBlockType.Text, Text = "You push outward with your weapon to clear some space before quickly reloading a fresh round. You make an Athletics check to (action: Shove) an opponent within your reach using your weapon, then (action: Interact) to reload. For this (action: Shove), you don’t need a free hand, and you add the weapon’s item bonus on attack rolls (if any) to the Athletics check. If your last action was a ranged (action: Strike) with the weapon, use the same multiple attack penalty as that (action: Strike) for the (action: Shove); the (action: Shove) still counts toward your multiple attack penalty on further attacks as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0eeb6fb1-3e45-48b8-ad91-6497ef4d2853"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
