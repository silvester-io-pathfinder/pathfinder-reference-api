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
    public class MagnifyingGlass : Template
    {
        public static readonly Guid ID = Guid.Parse("9417ac00-4b72-460a-a6dc-ad961c03ab14");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Magnifying Glass"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("302c42ec-e59f-4f42-8e90-0073770e9f95"), "This quality handheld lens gives you a +1 item bonus to Perception checks to notice minute details of documents, fabric, and the like.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("042104b4-9798-4379-8503-de78fa75a146"),
                Name = "Magnifying Glass",
                Hands = "1",
                Level = 3,
                Price = 4000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d8a755d-21da-415f-aadf-a0b8b4a4c185"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
