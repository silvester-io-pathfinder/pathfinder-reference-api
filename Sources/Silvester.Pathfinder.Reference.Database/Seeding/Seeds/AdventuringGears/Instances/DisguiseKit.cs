using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "2",
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dff4bfc6-9f41-44aa-9d99-6139c02bfdf8"), Type = TextBlockType.Text, Text = "This small wooden box contains cosmetics, false facial hair, spirit gum, and a few simple wigs. You usually need a disguise kit to set up a disguise in order to Impersonate someone using the Deception skill. You can draw and replace a worn disguise kit as part of the action that uses it." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("f9040db4-e4df-429a-9970-e1fe53d90f12"),
                NameAddendum = "Replacement Cosmetics",
                DescriptionAddendum = "If you've crafted a large number of disguises, you can replenish your cosmetics supply with replacement cosmetics suitable for the type of your disguise kit.",
                ItemLevel = 0,
                Price = 10,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2aa5120f-4773-407e-9347-0aced34e5780"),
                NameAddendum = "Elite",
                DescriptionAddendum = "An elite disguise kit adds a +1 item bonus to relevant checks.",
                ItemLevel = 3,
                Price = 4000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4560c10a-7046-4951-92d5-1b0d358e3ce4"),
                NameAddendum = "Elite Replacement Cosmetics",
                DescriptionAddendum = "If you've crafted a large number of disguises, you can replenish your cosmetics supply with replacement cosmetics suitable for the type of your disguise kit.",
                ItemLevel = 3,
                Price = 50,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3215583-b79b-4ae2-90ce-0b8ec62fc026"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
