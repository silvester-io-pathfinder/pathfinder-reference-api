using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalElixirs.Instances
{
    public class Vaccine : Template
    {
        public static readonly Guid ID = Guid.Parse("740b5120-8af7-46c3-983c-28c89fb15303");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Vaccine",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fb6ecf08-9899-4d08-9cf7-b33283f46f28"), "A vaccine grants a creature immunity to a specific strain of disease of a level equal to or less than the vaccine's level, and a +2 item bonus on all saving throws against other strains of the same disease. For example, a vaccine could grant immunity to filth fever inflicted by otyughs, but would only grant a +2 saving throw bonus against filth fever inflicted by a giant rat.");
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("6a0efbd2-3d80-487c-96d2-ec1be26e5355"),
                Name = "Vaccine (Minor)",
                CraftingRequirements = "Creating a vaccine requires a sample of the disease in question.",
                Usage = "Held in 1 hand.",
                Level = 1,
                Price = 400,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Minor.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("422f716c-c6d8-49c2-a8ea-4dfa63df3bde"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("54e564bf-cbad-4578-9a6b-45a723dc7372"), "The duration is 1 hour.");
                            }); 
                    })
                    .Build()
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("56814ae5-6ba1-40ed-b8de-602376e27c6b"),
                Name = "Vaccine (Lesser)",
                CraftingRequirements = "Creating a vaccine requires a sample of the disease in question.",
                Usage = "Held in 1 hand.",
                Level = 3,
                Price = 1200,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Lesser.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4725f78d-e57e-4b8f-b7da-2877c0795bd9"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("ea90448c-fab1-475d-959b-98ccc6c331e3"), "The duration is 25 hours.");
                            });
                    })
                    .Build()
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("168581cf-a15a-410a-9018-bb16f3463b8a"),
                Name = "Vaccine (Moderate)",
                CraftingRequirements = "Creating a vaccine requires a sample of the disease in question.",
                Usage = "Held in 1 hand.",
                Level = 6,
                Price = 5000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Moderate.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("640a14dc-a152-474a-a616-b7abad89bb0a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("04f7e647-129c-4202-90cf-006f03d02db2"), "The duration is 1 week.");
                            });
                    })
                    .Build()
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("4c0d6e2f-7627-4f88-b269-2cdf2f02552e"),
                Name = "Vaccine (Greater)",
                CraftingRequirements = "Creating a vaccine requires a sample of the disease in question.",
                Usage = "Held in 1 hand.",
                Level = 12,
                Price = 40000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("57a94800-72c8-4694-b3b4-9ff8b5f64a25"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("63f9b378-7e8b-4b9e-b3a4-559b524753eb"), "The duration is 1 year.");
                            });
                    })
                    .Build()
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("f307df34-16c4-4209-a026-40d96d6e5412"),
                Name = "Vaccine (Major)",
                CraftingRequirements = "Creating a vaccine requires a sample of the disease in question.",
                Usage = "Held in 1 hand.",
                Level = 18,
                Price = 500000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1d16f2de-29cb-4846-9ac6-c54e716b0fe9"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("5a8739d8-5a8f-416b-a83f-31510ae18daf"), "The duration is permanent.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4659a68a-08e8-49bf-80cb-e36909bed94f"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("d956083f-e640-4385-a389-c2a41b995c2d"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("54e35751-cd2e-4dba-9866-ca74d0828d89"), Traits.Instances.Elixir.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6c26590-7f7e-47a5-82c3-b9fe9b240726"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 71
            };
        }
    }
}
