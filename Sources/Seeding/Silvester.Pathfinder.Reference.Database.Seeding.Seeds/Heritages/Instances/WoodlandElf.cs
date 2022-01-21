using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class WoodlandElf : Template
    {
        public static readonly Guid ID = Guid.Parse("29b23245-8101-4e3b-b35c-14825448dc40");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Woodland Elf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("beda77e3-2dc9-4294-8a8d-c2053faaa306"), Type = TextBlockType.Text, Text = "You're adapted to life in the forest or the deep jungle, and you know how to climb trees and use foliage to your advantage. When Climbing trees, vines, and other foliage, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed." };
            yield return new TextBlock { Id = Guid.Parse("e09c40b6-dd13-458e-a0ae-5e34c3f176d7"), Type = TextBlockType.Text, Text = "You can always use the Take Cover action when you are within forest terrain to gain cover, even if you're not next to an obstacle you can Take Cover behind." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("a61dd8e5-fed8-46c2-9636-25b3415e1f66"), "When Climbing trees, vines, and other foliage, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed.");
            builder.Manual(Guid.Parse("cb4725c6-6d88-4963-bb3f-1a7bc97c90ad"), "You can always use the Take Cover action when you are within forest terrain to gain cover, even if you're not next to an obstacle you can Take Cover behind.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58a163c3-a872-4de5-8ed2-b45e0195e010"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 40
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Elf.ID;
        }
    }
}
