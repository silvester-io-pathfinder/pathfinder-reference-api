using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalElixirs.Instances
{
    public class BestialMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("1a2e2a1c-f468-48ec-b023-e81756740a11");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Bestial Mutagen",
                Benefit = "You gain an item bonus to Athletics checks and unarmed attack rolls. You gain a claw unarmed attack with the agile trait and a jaws unarmed attack.",
                Drawback = "You take a –1 penalty to AC and a –2 penalty to Reflex saves.",

            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("029c1cd3-93f2-472e-90a1-7f67847a6752"), "Your features transform into something bestial and you take on muscle mass, but your lumbering form is clumsy."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("8174165c-3f20-49c8-98aa-a9a26f730ce0"),
                Name = "Bestial Mutagen (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
				Price = 400,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("cec34f8f-5da9-4bb3-af6b-fc7217b1a82d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b6c223a1-e825-460f-9ab3-c5a517d0d8e3"), "You gain a +1 item bonus, your claw deals 1d4 slashing damage, your jaws deal 1d6 piercing damage, and the duration is 1 minute.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("d44d57f8-b3f3-494a-8ee0-4e8ac3a1aa1b"),
                Name = "Bestial Mutagen (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
				Price = 1200,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bdf2bedc-205e-4286-a8bf-96e4f4d891d0"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("9a7534a3-58d7-43ce-896b-1b16aa6d1115"), "You gain a +2 item bonus, your claw deals 1d6 slashing damage, your jaws deal 1d8 piercing damage, and the duration is 10 minutes.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("fb2d067c-923e-468a-99bd-f92fa90011e3"),
                Name = "Bestial Mutagen (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
				Price = 30000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f20b58b9-727e-403f-8837-7a6e7ea55300"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d091ebea-f985-414b-8dec-27d38bb631f5"), "You gain a +3 item bonus, your claw deals 1d8 slashing damage, your jaws deal 1d10 piercing damage, and the duration is 1 hour.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("b71b9fc1-1ec2-4c5e-85cf-83ab3b3722e3"),
                Name = "Bestial Mutagen (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
				Price = 300000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f097fc3c-e692-47c4-a94a-9f17fdd4ab18"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b982627a-a825-4e8f-b4e0-17e166c2f0b1"), "You gain a +4 item bonus, your claw deals 1d8 slashing damage, your jaws deal 1d10 piercing damage, and the duration is 1 hour. You gain weapon specialization with the claws and jaws, or greater weapon specialization, if you already have weapon specialization with these unarmed attacks.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("815b58b7-1c61-475f-8a23-4e21778d0717"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("804162b7-bd78-4d5e-a436-f840d49aacf8"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("a4c16edb-4422-45ba-8031-ad2e717b9d8c"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("0e7cacf4-742c-41af-a78f-05c20a4fd8f0"), Traits.Instances.Mutagen.ID);
            builder.Add(Guid.Parse("6a7c659b-b197-423c-987b-59b2be488a41"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b71b9fc1-1ec2-4c5e-85cf-83ab3b3722e3"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
