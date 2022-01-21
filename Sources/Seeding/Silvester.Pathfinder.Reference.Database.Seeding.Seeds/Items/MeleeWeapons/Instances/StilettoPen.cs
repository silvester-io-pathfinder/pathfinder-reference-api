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
    public class StilettoPen : Template
    {
        public static readonly Guid ID = Guid.Parse("3f47473d-20b7-44af-89d7-0b09b74e0665");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Stiletto Pen",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Dart.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("1d2b7d29-693f-4490-aedf-750d1bdd63a2"),
				Name = "Stiletto Pen",
				Price = 800,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("69678d57-62b5-40c5-9c84-d6558b81663b"), "This weapon is a fully functional, lavish ink pen with a clip that can be attached to a pocket or bandoleer and easily retrieved as a free action. Using an action to Interact with the pen allows its wielder to disengage a stiletto blade that slides free of the upper body or reattach the previously removed blade.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8c3f5c83-4891-4445-86f4-3fdbdeb78d6e"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("6e2b90e7-c405-47ce-bd67-16239ddfb2e6"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("771d86b1-b1df-4626-b3a9-761b66692988"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("5d31b8a6-e1cd-484f-ab77-4a7f8f82faf2"), Traits.Instances.Thrown.ID);
            builder.Add(Guid.Parse("44e14a1c-ab65-4abe-a4d9-8f01e8fad29b"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83d1411d-23e1-4926-abd0-aa4ab8667b0c"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 30
            };
        }
    }
}
