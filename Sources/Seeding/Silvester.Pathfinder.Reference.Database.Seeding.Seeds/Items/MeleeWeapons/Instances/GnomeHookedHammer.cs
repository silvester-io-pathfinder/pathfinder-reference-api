using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class GnomeHookedHammer : Template
    {
        public static readonly Guid ID = Guid.Parse("f828cf37-ae7a-4534-a5f3-d12558d731eb");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Gnome Hooked Hammer",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Hammer.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("5337e54f-09c1-45f5-af32-e5bf49000df7"),
				Name = "Gnome Hooked Hammer",
				Price = 200,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("045bbb85-3f28-459d-a5de-19d0a5119865"), "This gnome tool and weapon features a hammer at one end and a curved pick on the other. It's such a strange and awkward weapon that others think the gnomes are slightly erratic for using it.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2e895d5d-2909-45d3-a152-89acd2aef087"), Traits.Instances.Gnome.ID);
            builder.Add(Guid.Parse("e8cf710a-6caa-40c2-a946-aff1f242c8de"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("64d57259-85f4-4346-ae0b-ba3f2b14c5d4"), Traits.Instances.TwoHand.ID);
            builder.Add(Guid.Parse("51118520-4777-42a2-8743-7bf946e65b51"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("dd10753f-268e-4aaf-960b-d3d15ad37fda"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbbc98d4-cb52-4c9a-8d48-973996f7585b"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
