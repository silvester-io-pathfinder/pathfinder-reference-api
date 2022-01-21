using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class DesertRat : Template
    {
        public static readonly Guid ID = Guid.Parse("62e635f9-be82-4832-8e70-ac7eda10816b");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Desert Rat"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a0a8505f-f1f3-4568-b4cd-89bdba2e86ae"), Type = TextBlockType.Text, Text = "You are native to arid plains and likely grew up traveling the roads. You have a leaner build than other ratfolk, with longer limbs and short fur. If you have both hands free, you can increase your Speed to 30 feet as you run on all fours. In addition, environmental heat effects are one step less extreme for you, and you can go 10 times as long as normal before you are affected by starvation or thirst. However, unless you wear protective gear or take shelter, environmental cold effects are one step more extreme for you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("d67699c3-e431-4868-bae5-caec16774092"), "If you have both hands free, you can increase your Speed to 30 feet as you run on all fours.");
            builder.ModifyTemperature(Guid.Parse("5e601b3a-2016-4a45-9d30-d7264179904d"), Temperature.Heat, ModifierType.Subtract, modifier: 1);
            builder.Manual(Guid.Parse("68e34afa-3d52-4e82-af3a-9f61badc437f"), "You can go 10 times as long as normal before you are affected by starvation or thirst.");
            builder.ModifyTemperature(Guid.Parse("9cba4e58-04df-4016-97a2-6d500484e3ff"), Temperature.Cold, ModifierType.Subtract, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c99fbb29-97c2-4a3a-8d3a-dfdcb63a239d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 21
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Ratfolk.ID;
        }
    }
}
