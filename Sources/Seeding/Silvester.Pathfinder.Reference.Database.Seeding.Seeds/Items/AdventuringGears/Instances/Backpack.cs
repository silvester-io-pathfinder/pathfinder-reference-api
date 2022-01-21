using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Backpack : Template
    {
        public static readonly Guid ID = Guid.Parse("4ca4df89-46d6-41aa-8467-078b97c85852");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Backpack",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e33ba36b-fe08-4558-80ff-a386ac5904cc"), "A backpack holds up to 4 Bulk of items. and the first 2 Bulk of these items don't count against your Bulk limits. If you're carrying or stowing the pack rather than wearing it on your back, its Bulk is light instead of negligible.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fffdb618-fe7b-4117-8b82-d8101d134f86"),
                Name = "Backpack",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b04fdee6-3960-4bc9-bc85-e0ea7a6cc1a8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
