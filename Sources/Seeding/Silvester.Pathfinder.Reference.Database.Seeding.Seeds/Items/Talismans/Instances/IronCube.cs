using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans.Instances
{
    public class IronCube : Template
    {
        public static readonly Guid ID = Guid.Parse("1003386c-5d3d-4d82-8611-95998f5f35c3");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Iron Cube",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c8c57988-2e37-49dc-bb11-7159eb4e5057"), "This cube of blackened iron is affixed to a weapon with an iron chain.When you activate the cube, you use Knockdown, as the fighter feat(page 146).");
            builder.Text(Guid.Parse("2b8df9a7-9cdc-46ef-bf77-1167ca256e18"), "If you have the Knockdown feat, ignore its normal size restrictions.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("904d3286-33c0-4405-9f8d-a9c6430fac1a"),
                Name = "Iron Cube",
                Usage = "Affixed to a weapon.",
                Level = 6,
                Price = 5000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1053a2a0-d880-42ba-96d5-fd2654430990"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action
                            .Kind("Knockdown")
                            .Requirements("You are an expert with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8b190299-4b3b-4657-8f5a-12ed27263787"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("8e50d10f-8475-45a3-8879-f4b155a72502"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("a940fc87-dee7-4219-8cbf-2170ddc88d48"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d1b27e21-55cb-45b1-aec2-480efa216a1f"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("914f2b95-8bba-4c61-88a8-0c37ffe85b0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
