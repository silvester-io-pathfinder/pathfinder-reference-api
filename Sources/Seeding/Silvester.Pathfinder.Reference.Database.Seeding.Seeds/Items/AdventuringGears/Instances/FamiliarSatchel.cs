using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class FamiliarSatchel : Template
    {
        public static readonly Guid ID = Guid.Parse("1e2cf39c-7aa0-47df-93cd-81dae8de27a3");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Familiar Satchel",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("066484ea-92fd-4672-b69e-12e0cbba8a2d"), "This armored case is made to protect any Tiny or smaller creature contained within. It includes air holes (which can be plugged with cork stoppers for underwater travel) and two receptacles for food and water. Any creature inside has neither line of sight nor line of effect to the outside world but also cannot be targeted by attacks that require a line of effect while in the satchel. However, an area effect that deals enough damage to break the case also damages the creature inside. The satchel is made of leather (Hardness 4, HP 16, BT 8). A creature can enter or exit the satchel by using a total of 2 actions: an Interact action to open the satchel and a single action with the move trait to enter or exit.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("da70844c-33e1-4a6b-9e67-436a894867fc"),
                Name = "Familiar Satchel",
                Level = 0,
                Price = 500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }
        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0899601a-1040-474c-abbc-f669c6b26f33"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
