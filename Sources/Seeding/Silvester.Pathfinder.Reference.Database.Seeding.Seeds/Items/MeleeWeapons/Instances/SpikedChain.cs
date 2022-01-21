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
    public class SpikedChain : Template
    {
        public static readonly Guid ID = Guid.Parse("8ada012d-7bc9-4091-8cf7-889d0bbffe7e");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Spiked Chain",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("130a6cc9-1921-4341-80f8-13e99f62e7d3"),
				Name = "Spiked Chain",
				Price = 300,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("bb944e24-511d-4df4-a6ac-01ff213ec41a"), "This 4‑foot‑long length of chain is covered with barbs and has spikes on one or both ends. Some feature metal hoops used as handgrips.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6fbc0199-080c-490b-97b3-e905934187aa"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("9efc57da-ec32-4a84-8e1a-9f8252427c7e"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("f3e41c53-0346-41e9-8a3b-6b5c3c48d97d"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("3f8397e3-94d0-46c2-b01e-e62fceec6cbc"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a815cf76-79c0-4130-936c-6468b6cda683"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
