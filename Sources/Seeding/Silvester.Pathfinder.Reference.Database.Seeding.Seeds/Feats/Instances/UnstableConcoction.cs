using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnstableConcoction : Template
    {
        public static readonly Guid ID = Guid.Parse("f7b811a5-e8f3-488f-9eb6-bb90d72a7b0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unstable Concoction",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b100fa4a-f0f1-43a7-a00e-8c1487a6ec1e"), Type = TextBlockType.Text, Text = "You can create extraordinary – albeit volatile – alchemical wonders, though they have an unfortunate tendency to violently explode when you use them. When you use (feat:lvl--1: Quick Alchemy), you can create an alchemical item from your formula book whose level is up to 2 higher than your advanced alchemy level. You can spend up to 3 additional batches of infused reagents when creating this item to stabilize it. Upon activating the item, attempt a DC 10 flat check; for every additional batch of infused reagents you spent to create the item, reduce this DC by 2. On a success, the item functions normally. On a failure, the item explodes, dealing force damage to the user equal to twice the item's level (doubled on a critical failure)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0257b526-c56b-4c0e-b5ec-d3058ab3143e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
