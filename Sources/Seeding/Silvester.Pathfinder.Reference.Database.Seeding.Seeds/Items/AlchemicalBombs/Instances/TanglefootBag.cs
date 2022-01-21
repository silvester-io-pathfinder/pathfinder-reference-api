using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalBombs.Instances
{
    public class TanglefootBag : Template
    {
        public static readonly Guid ID = Guid.Parse("e7825926-436e-4914-940a-09de6052cab1");

        protected override AlchemicalBomb GetAlchemicalBomb()
        {
            return new AlchemicalBomb
            {
                Id = ID,
                Name = "Tanglefoot Bag",
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c5ae0bbb-d82d-414a-bb78-5f3790d2589e"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("077ecd2f-425a-4e1e-8297-c948b2d08a63"), Traits.Instances.Bomb.ID);
            builder.Add(Guid.Parse("eb979d42-8787-4ecc-bfce-24254b0c36bd"), Traits.Instances.Consumable.ID);
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f7f13e63-3728-470d-8a1f-b7cd65d855df"), "A tanglefoot bag is filled with sticky substances. When you hit a creature with a tanglefoot bag, that creature takes a status penalty to its Speeds for 1 minute. Many types of tanglefoot bag also grant an item bonus on attack rolls.");;
            builder.Text(Guid.Parse("694ea8b3-8bd7-4a4e-b925-446ba77959f6"), "On a critical hit, a creature in contact with a solid surface becomes stuck to the surface and immobilized for 1 round, and a creature flying via wings has its wings tangled, causing it to fall safely to the ground and become unable to Fly again for 1 round. Tanglefoot bags are not effective when used on a creature that is in water.");;
            builder.Text(Guid.Parse("3d23b44a-67d3-4cbe-b73e-528f36790ac4"), "The target can end any effects by Escaping or spending a total of 3 Interact actions to carefully remove the sticky substances. These Interact actions don't have to be consecutive, and other creatures can provide the actions as well.");;
        }

        protected override IEnumerable<AlchemicalBombVariant> GetAlchemicalBombVariants()
        {
            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("294e2585-b769-4685-8a98-5174ec4d4fc2"),
                Name = "Tanglefoot Bag (Lesser)",
                Usage = "Held in 1 hand",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Lesser.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("5602bbe1-e29a-4e34-95ec-ff0f217f6c03"), "The target takes a –10-foot penalty, and the Escape DC is 17.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("0e6c90de-a92b-419b-8912-50f3950aa3e8"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("6778bc68-53d6-4432-8f96-ccca5073ee48"),
                Name = "Tanglefoot Bag (Moderate)",
                Usage = "Held in 1 hand",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Moderate.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("1a05f9b1-1015-4f38-9104-bd0da2364423"), "You gain a +1 item bonus to attack rolls, the target takes a –15-foot penalty, and the Escape DC is 19.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("7eab7ab7-9e7e-435c-bd57-ba3f1e28a1a8"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("44ac5c08-5ccd-4cba-b822-f4b6a37573c4"),
                Name = "Tanglefoot Bag (Greater)",
                Usage = "Held in 1 hand",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("abe6e7ca-6bf4-477c-9fae-09b5f9974129"), "You gain a +2 item bonus to attack rolls, the target takes a –15-foot penalty, and the Escape DC is 28.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("ac32593f-d68e-4175-b8e1-f2922a38c6e0"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };

            yield return new AlchemicalBombVariant
            {
                Id = Guid.Parse("ebfa4694-3931-4d55-9b70-ac6cc73e2837"),
                Name = "Tanglefoot Bag (Major)",
                Usage = "Held in 1 hand",
                Level = 17,
                Price = 250000,
                BulkId = Bulks.Instances.LightBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
				RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("7e4777b0-7dba-4be8-a2fa-71198c0ec13b"), "You gain a +3 item bonus to attack rolls, the target takes a –20-foot penalty, and the Escape DC is 37.")
					.Build(),
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("08b4f0b8-9a43-46ef-a3d6-af632acc7fe0"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
					{
						action.Kind("Strike");
					})
					.Build(),
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3cc038d-b67e-4cf7-a23e-cdb9464ad5a8"),
                SourceId = CoreRulebook.ID,
                Page = 545
            };
        }
    }
}
