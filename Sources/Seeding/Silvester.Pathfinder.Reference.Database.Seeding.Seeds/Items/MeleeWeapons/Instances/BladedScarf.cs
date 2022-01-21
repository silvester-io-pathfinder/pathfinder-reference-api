using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class BladedScarf : Template
    {
        public static readonly Guid ID = Guid.Parse("2c97c992-70f8-4dfa-950b-ebbaf0148267");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Bladed Scarf",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("8bd95258-8106-41dd-816d-4fd4551913f3"),
				Name = "Bladed Scarf",
				Price = 300,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("b10bac05-d335-4dd0-a218-6ca75e7ab4a1"), "The thin metal plates interwoven throughout this long scarf turn a fashion accessory into a deadly weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d1e98d1f-31f7-4453-98a5-e0873830b70e"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("6f12321f-ecee-41d1-a2f2-14a7885582e3"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("331f9db2-c598-466b-92b2-4d97912a9d8c"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("1993c8af-d6a8-416d-b9d2-f00c47be5b8f"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("3b7f6e38-b737-4397-a843-fe80ea45e12f"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12be0d39-76bb-475b-b107-b2b4a8f87d48"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 120
            };
        }
    }
}
