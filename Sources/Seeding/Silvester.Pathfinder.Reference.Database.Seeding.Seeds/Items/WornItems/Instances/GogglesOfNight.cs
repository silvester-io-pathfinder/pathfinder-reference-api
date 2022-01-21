using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class GogglesOfNight : Template
    {
        public static readonly Guid ID = Guid.Parse("4abe08a4-dcf3-4379-b939-01246f2f57c3");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Goggles of Night",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("290da1a5-a0ff-46b2-a2e2-ffc0f8d611b3"), "The opaque crystal lenses of these sleek goggles do not obscure vision, but rather enhance it. While wearing the goggles, you gain a +1 item bonus to Perception checks involving sight.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2faa0c9b-0d62-4ce7-bef2-41d478d96cf0"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("bd1170a8-6afd-40bf-9070-e1053e14f9bf"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("8e682e4c-f63d-4345-8354-cfbf1bc76c46"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("217afa27-4041-4451-9a62-8cd5f2c21b4f"),
                Name = "Goggles of Night",
                Usage = "Worn eyepiece.",
                Level = 5,
                Price = 15000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1b2b0bb9-1b04-4df2-8a1c-75cce2b3fc8a"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("1dd3a794-456c-4cf3-a92a-108a663cd4eb"), "Rotating the lenses 90 degrees, you gain darkvision for 1 hour.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("929603f2-f38a-40b6-8342-365e8552f4aa"),
                Name = "Goggles of Night",
                Usage = "Worn eyepiece.",
                Level = 11,
                Price = 125000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6be7d80e-fffc-4845-84e4-9826b285fe67"), "The item bonus is +2, and the darkvision lasts until you rotate the lenses back or the item is no longer invested by you, whichever comes first.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bb6acbb3-be28-47a1-aa35-9f46b0732d6c"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("cb43a953-3afc-401d-b9c9-9aa0526f5a86"), "Rotating the lenses 90 degrees, you gain darkvision until you rotate the lenses back or the item is no longer invested by you, whichever comes first.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("6d1d3a7a-6a5d-45b4-81d0-87fdbc90af3b"),
                Name = "Goggles of Night (Major)",
                Usage = "Worn eyepiece.",
                Level = 18,
                Price = 2000000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0de345cb-06f4-4cb1-87fb-d982e42a9ac8"), "The item bonus is +3, and the goggles grant greater darkvision, which lasts until you rotate the lenses back or the item is no longer invested by you, whichever comes first.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("77e81221-501c-4a55-ac24-2973f6475a70"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("85fe78ad-3248-4710-bc70-ef9ef543931a"), "Rotating the lenses 90 degrees, you gain greater darkvision until you rotate the lenses back or the item is no longer invested by you, whichever comes first.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab3c1246-2e90-43d7-8e12-6bfc5f946f5d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 610
            };
        }
    }
}
