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
    public class WaterproofJournal : Template
    {
        public static readonly Guid ID = Guid.Parse("008da8ab-fa02-4ad0-9ba2-40dca2c5e0be");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Waterproof Journal",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("95c90f90-5864-4c66-bb03-94a7200c29f5"), "This leather-bound tome is specially treated to protect from water damage and comes with a key and a treated slipcase that bears a simple lock to keep the tome secure. This journal is commonly used by adventuring scholars and ship navigators for recording their journeys.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0aff4d54-e834-4083-8658-9ad231a6a171"),
                Name = "Waterproof Journal",
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c79be0a7-c09d-4a03-9bbe-94e6e7a94ed1"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 30
            };
        }
    }
}
