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
    public class AddictionSuppressant : Template
    {
        public static readonly Guid ID = Guid.Parse("6ca13a50-b47a-45ed-8282-a16560ef2a1d");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Addiction Suppressant",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e43f8c9b-94e5-48d8-9ff4-7a03653f8bcb"), "When you use a dose of addiction suppressant, it suppresses the effects of that addiction for 1 day, as if you had taken an actual dose of the drug, but without any of the drug's effects, and it doesn't increase the addiction DC. You also gain an item bonus against the ongoing save against the drug's addiction depending on the type of addiction suppressant.");
            builder.Text(Guid.Parse("a8a11978-7dbd-4aa4-b861-d64bf8421bb8"), "For every drug, a specific suppressant must be crafted - no generalized addiction suppressant yet exists. In order to create an addiction suppressant, you must begin with a dose of the drug to be suppressed, then use alchemical reagents to generate an elixir that can be used to fight that drug's addiction. An addiction suppressant must be a higher level than the drug it is meant to suppress in order to work.");
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("81a9c56e-af56-4833-8508-df96d9980d12"),
                Name = "Addiction Suppressant (Lesser)",
                Usage = "Held in 1 hand.",
                Level = 1,
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Lesser.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("30ab2ea1-62fd-4136-9cf0-dc4d8e55ab1e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("52544a29-89c3-4858-a1c9-dbb1bd21346f"), "You gain a +1 item bonus.");
                            });
                    })
                    .Build()
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("dac51736-fd5c-4ba1-8b90-4d9b5f268f0e"),
                Name = "Addiction Suppressant (Moderate)",
                Usage = "Held in 1 hand.",
                Level = 6,
                Price = 3000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Moderate.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("920dfbc7-dcef-47a5-87a9-cddb75361f6a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("d21d36b4-5a7a-448f-b9b5-7f138af7c4fc"), "You gain a +2 item bonus.");
                            });
                    })
                    .Build()
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("18ae28d1-cd0c-4350-bf30-5513342b666a"),
                Name = "Addiction Suppressant (Greater)",
                Usage = "Held in 1 hand.",
                Level = 10,
                Price = 14000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c065ba49-dcf8-43db-b986-03eaa6aef003"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e1df7d0e-738b-47de-8c27-707a856250dc"), "You gain a +3 item bonus.");
                            });
                    })
                    .Build()
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("e6e49484-6c0c-4101-a34e-eeefd5e982c4"),
                Name = "Addiction Suppressant (Major)",
                Usage = "Held in 1 hand.",
                Level = 14,
                Price = 50000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9eb6778a-6c38-4365-8933-0130df97c3fa"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7675030d-5863-48c0-aa25-e9a6fd4a1f91"), "You gain a +4 item bonus.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f544af2e-9f8d-4f92-a384-b860f218cce9"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("37d9309e-4256-4102-997d-0efda61bdddb"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("802d28b4-3f59-46b5-835b-4919c6b1efd0"), Traits.Instances.Elixir.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("282c0a1f-cff7-460a-9c54-0db3d72bcc81"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 72
            };
        }
    }
}
