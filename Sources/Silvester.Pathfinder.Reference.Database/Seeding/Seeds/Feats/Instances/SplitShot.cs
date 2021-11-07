using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SplitShot : Template
    {
        public static readonly Guid ID = Guid.Parse("d708cd4e-dc8c-4007-915d-522fbe61737a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Split Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12c06343-b794-400e-8739-aade08dd7881"), Type = TextBlockType.Text, Text = "You fragment a ranged spell into a pair of smaller shots. If your next action is to (activity: Cast a Spell) without a duration that requires an attack roll against a single target and has no effect beyond dealing damage, you roll a single attack roll and compare the result to the AC of two targets within the spell’s range. The spell deals only half its usual damage to each target. This counts as one attack for your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83ecc66e-68d8-443a-9be9-955afb30801a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
