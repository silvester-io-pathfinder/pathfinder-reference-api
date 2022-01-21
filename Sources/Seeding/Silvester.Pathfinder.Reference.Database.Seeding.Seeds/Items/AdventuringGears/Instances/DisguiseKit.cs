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
    public class DisguiseKit : Template
    {
        public static readonly Guid ID = Guid.Parse("e428fd54-cd8a-4d30-b6e2-3c48a2490910");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Disguise Kit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("dff4bfc6-9f41-44aa-9d99-6139c02bfdf8"), "This small wooden box contains cosmetics, false facial hair, spirit gum, and a few simple wigs. You usually need a disguise kit to set up a disguise in order to Impersonate someone using the Deception skill. You can draw and replace a worn disguise kit as part of the action that uses it.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a3b0fe27-cd9b-4b7e-9389-326f0e2f8115"),
                Name = "Disguise Kit",
                Level = 0,
                Hands = "2",
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("f9040db4-e4df-429a-9970-e1fe53d90f12"),
                Name = "Disguise Kit (Replacement Cosmetics)",
                Hands = "2",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2ab8f15a-d2f4-4d30-9597-866169e998a5"), "If you've crafted a large number of disguises, you can replenish your cosmetics supply with replacement cosmetics suitable for the type of your disguise kit.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2aa5120f-4773-407e-9347-0aced34e5780"),
                Name = "Disguise Kit (Elite)",
                Hands = "2",
                Level = 3,
                Price = 4000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("15ef8668-10ab-44b5-85e0-89e10d063b38"), "An elite disguise kit adds a +1 item bonus to relevant checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4560c10a-7046-4951-92d5-1b0d358e3ce4"),
                Name = "Disguise Kit (Elite Replacement Cosmetics)",
                Hands = "2",
                Level = 3,
                Price = 50,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("256c4617-d0a1-4f9f-9387-40646ed74a60"), "If you've crafted a large number of disguises, you can replenish your cosmetics supply with replacement cosmetics suitable for the type of your disguise kit.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3215583-b79b-4ae2-90ce-0b8ec62fc026"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
