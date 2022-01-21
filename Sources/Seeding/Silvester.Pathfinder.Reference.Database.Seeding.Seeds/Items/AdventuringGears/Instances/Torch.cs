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
    public class Torch : Template
    {
        public static readonly Guid ID = Guid.Parse("e71752ce-5078-41c3-a4bd-8313073efd3d");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Torch",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b4b6d8b8-e2aa-41d4-a74a-e8b6c910b5fc"), "A torch sheds bright light in a 20-foot radius (and dim light to the next 20 feet) for 1 hour. It can be used as an improvised weapon that deals 1d4 bludgeoning damage plus 1 fire damage.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("19264cdd-57ee-4b17-9519-0d9d8416aa73"),
                Name = "Torch",
                Level = 0,
                Hands = "1",
                Price = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88e2daa7-f121-495c-9159-084ce47aacb9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
