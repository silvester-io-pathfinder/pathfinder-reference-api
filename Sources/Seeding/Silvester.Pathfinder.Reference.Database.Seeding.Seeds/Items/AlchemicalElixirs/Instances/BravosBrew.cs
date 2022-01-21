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
    public class BravosBrew : Template
    {
        public static readonly Guid ID = Guid.Parse("8d0d85f9-d1bf-49c2-ab32-d6caa627de83");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                Name = "Bravo's Brew",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bed0c6dc-af90-431a-93a5-f6a126f7e4d2"), "This flask of foaming beer grants courage. For the next hour after drinking this elixir, you gain an item bonus to Will saves, which is greater when attempting Will saves against fear."); ;
        }

        protected override IEnumerable<AlchemicalElixirVariant> GetAlchemicalElixirVariants()
        {
            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("e35d119e-d943-4fac-be53-d75d079be8c4"),
                Name = "Bravo's Brew (Lesser)",
                Usage = "Held in 1 hand",
                Level = 2,
				Price = 700,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e4046d12-dfd7-496b-a7d0-813ef457576c"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("8b71bab8-7e4b-4f8f-8476-bd9ffaf61b4b"), "The bonus on Will saves is +1, or +2 against fear.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("924eb7b5-50b7-48d8-857d-18dd705ec6ab"),
                Name = "Bravo's Brew (Moderate)",
                Usage = "Held in 1 hand",
                Level = 10,
				Price = 15000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b3409942-89bd-456e-93ba-3ebb847e91a2"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("45ca7c11-482c-4531-bf0f-4257068ec541"), "The bonus on Will saves is +2, or +3 against fear.")
                    .Build(),
            };

            yield return new AlchemicalElixirVariant
            {
                Id = Guid.Parse("198da97d-cf25-453b-93ce-94591ba46529"),
                Name = "Bravo's Brew (Greater)",
                Usage = "Held in 1 hand",
                Level = 15,
				Price = 70000,
				BulkId = Bulks.Instances.LightBulk.ID,
				PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f1ad0ffc-c089-4cbb-b3b3-9958a72266f3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build(),
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e5149cb7-9d89-4645-9892-7355b1ddd5e3"), "The bonus on Will saves is +3, or +4 against fear. If you roll a success on a save against fear, you get a critical success instead.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("14c2350b-4529-4372-b7d4-8d14fdcd9e50"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("0ec0196c-dc0b-4973-a998-a0d1a07c33d5"), Traits.Instances.Elixir.ID);
            builder.Add(Guid.Parse("ff8fd58c-058b-452b-893e-27f4f79adca7"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("43863d20-0697-4759-8496-108f4fc826cf"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b4598c1-dd52-41da-aadb-13768ee8f885"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
