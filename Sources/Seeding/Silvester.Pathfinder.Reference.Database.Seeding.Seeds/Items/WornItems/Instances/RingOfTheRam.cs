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
    public class RingOfTheRam : Template
    {
        public static readonly Guid ID = Guid.Parse("db07df52-c9b7-4251-b0b0-1f6b0044f0c5");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of the Ram",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a38e7f3c-bbe6-49a0-bf82-373512db6208"), "This heavy iron ring is shaped to look like the head of a ram, with curling horns.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d3f5a22b-8499-4827-ac4e-a6083d29bcde"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("b70c3978-3a86-4c2a-9d33-13ef5eb3139e"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("9dcf1b52-bad6-4756-83f2-5ad736471066"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("8a898b60-8c19-4fda-994f-5af85b3e0d49"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("e2265de3-f608-4219-ac39-21c8abc3058a"),
                Name = "Ring of the Ram",
                CraftingRequirements = "",
                Usage = "Worn.",
                Level = 6,
                Price = 22000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3aebce4d-e167-4fc4-b466-c9e98fdd060e"), ActionTypes.Instances.OneToThreeActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("1b6c9d5f-479c-4770-8f11-40f5642864ac"), "A ram-shaped blast of force slams into one foe that you can see within 60 feet. The number of actions you spend to Activate this Item (from 1 to 3) determines the intensity of the force. The blow deals 2d6 force damage per action spent and pushes the target 5 feet per action spent. The target must attempt a DC 22 Fortitude save.");
                            })
                            .RollableEffect(Guid.Parse("924d8a6d-34e9-4313-ba95-4d2866ba8de1"), effect =>
                            {
                                effect
                                    .CriticalSuccess("The target is unaffected.")
                                    .Success("The target takes half damage and is pushed half the distance.")
                                    .Failure("The target takes full damage and is pushed the full distance.")
                                    .CriticalFailure("The target takes double damage and is pushed twice the distance.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("49f10fbe-97b4-4aab-86ce-f2cda5fa0940"),
                Name = "Ring of the Ram",
                CraftingRequirements = "",
                Usage = "Worn.",
                Level = 13,
                Price = 270000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                     .Text(Guid.Parse("76e740a9-39b5-4027-b865-2716eccf7af3"), "The ring deals 3d6 force damage per action spent, and the save DC is 32. When you activate the ring using 3 actions, you can disperse the force into multiple magical rams, targeting all creatures in a 30-foot cone instead of one target within 60 feet.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ffdabf88-1d3b-4dc0-b9e4-2350e3f28fad"), ActionTypes.Instances.OneToThreeActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("7d26ce0d-8cac-4043-99f4-1f6473cddf0f"), "A ram-shaped blast of force slams into one foe that you can see within 60 feet. The number of actions you spend to Activate this Item (from 1 to 3) determines the intensity of the force. The blow deals 3d6 force damage per action spent and pushes the target 5 feet per action spent. The target must attempt a DC 32 Fortitude save.");
                            })
                            .RollableEffect(Guid.Parse("47bf131f-cffc-49a2-8a48-dbea5742a9d3"), effect =>
                            {
                                effect
                                    .CriticalSuccess("The target is unaffected.")
                                    .Success("The target takes half damage and is pushed half the distance.")
                                    .Failure("The target takes full damage and is pushed the full distance.")
                                    .CriticalFailure("The target takes double damage and is pushed twice the distance.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecde6a75-f8d2-45f8-8a60-9d50ac938259"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 615
            };
        }
    }
}
