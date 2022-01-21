using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class FakeBloodPack : Template
    {
        public static readonly Guid ID = Guid.Parse("b40e16a1-974b-4ecf-8b26-3fde3a8f1434");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Fake Blood Pack",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4aafbad4-4c28-455e-b1c9-003404b73e53"), "Adventurers have found a number of uses for these animal blood�filled bladders, which were originally used in theatrical productions. Whenever you take slashing or piercing damage with the fake blood pack under your clothes or armor, roll a DC 11 flat check. On a success, the blood pack is punctured. You or an ally can puncture the hidden pack intentionally. When faking an injury, the blood pack grants a +2 item bonus to relevant Deception checks, such as to Lie about being injured. Abilities that trigger when a creature deals bleed damage, determine if a creature is bleeding, or are otherwise based on bleed damage don't trigger or apply for blood from a fake blood pack, which might mean creatures with such abilities automatically realize the ruse.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5e6fd4f9-0622-417b-82e2-d7b85575eb00"),
                Name = "Fake Blood Pack",
                Usage = "Worn under light armor or clothes.",
                Level = 0,
                Price = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b07a6a3b-1581-464a-bf47-a1f8f80f6396"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 92
            };
        }
    }
}
