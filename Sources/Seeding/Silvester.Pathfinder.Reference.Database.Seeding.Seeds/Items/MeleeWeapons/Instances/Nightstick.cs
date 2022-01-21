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
    public class Nightstick : Template
    {
        public static readonly Guid ID = Guid.Parse("8dde67f3-49e5-4231-aa23-7e1d4abd63cc");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Nightstick",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("4e511d60-32a9-4c09-931e-f74dbdb2f5e5"),
				Name = "Nightstick",
				Price = 100,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("6d5b9253-0331-44ef-8151-b6c6e3ee3d2d"), "This collapsible baton consists of several nested, telescoping metal shafts that can be extended as a free action by flicking the wrist. Once extended to its full length (usually around 2 feet), the baton locks into shape until the wielder uses an Interact action to collapse it—a collapsed nightstick is 8 inches long, making it easily concealed. Lighter and more maneuverable than an ordinary club or truncheon, nightsticks are designed to subdue foes without causing permanent injury. A nightstick is an uncommon simple melee weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("73950ae1-46af-4eb8-9386-0fa63514bb1c"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("3a9e6e4d-8bac-438e-a6d5-10c58290ba97"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("290b0293-ffb6-4641-8569-0c9acab18e31"), Traits.Instances.Nonlethal.ID);
            builder.Add(Guid.Parse("4817267d-cf9d-45c4-a67e-3c584d8d1ef3"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("4566a28b-f46b-4d56-ab35-7245cf4e0772"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fc416c1-9963-4fc1-ba94-dab2a33c37ea"),
                SourceId = Pathfinder157.ID,
                Page = 78
            };
        }
    }
}
