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
    public class Saddlebags : Template
    {
        public static readonly Guid ID = Guid.Parse("53af75a3-f02a-4a31-8a6c-63c292192228");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Saddlebags"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4e1e1d35-9b89-462d-a981-baa50eddd958"), "Saddlebags come in a pair. Each can hold up to 3 Bulk of items, and the first 1 Bulk of items in each doesn't count against your mount's Bulk limit. The Bulk value given is for saddlebags worn by a mount. If you are carrying or stowing saddlebags, they count as 1 Bulk instead of light Bulk.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b117a624-2afe-4563-807a-3f60b2ce9142"),
                Name = "Saddlebags",
                Hands = "2",
                Level = 0,
                Price = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8a0a3c7-2a02-49cf-bb00-7600e9c7a1ae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
