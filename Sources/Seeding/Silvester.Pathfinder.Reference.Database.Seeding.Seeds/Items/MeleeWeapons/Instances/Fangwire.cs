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
    public class Fangwire : Template
    {
        public static readonly Guid ID = Guid.Parse("0776b01d-d10c-41fa-8832-a7c718b7ff8e");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Fangwire",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Brawling.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("f6b649bc-c5be-463d-8c77-94c56d227ee3"),
				Name = "Fangwire",
				Price = 400,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("61a8b9c1-45b4-4e7b-b372-634bb21050b9"), "This kobold wire is thin and hard to see, making it perfect for an ambush. The wielder wraps the wire around a vulnerable spot, such as the neck, and twists it to inflict potentially fatal lacerations. The name derives from the use of a similar wire in traps, or slow fangs, with the word “slow” removed, as a fangwire gets quick results.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e0457844-084a-4d2c-91a1-873298028c32"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("2705e269-22a0-4e6f-9fca-464c88e9c844"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("6dfcc81f-3ef5-493e-864e-3b0c88f2ec19"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("452e3b68-d649-43a6-92f7-52338387100a"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("079444c5-f27b-4618-9138-579f552588d7"), Traits.Instances.Grapple.ID);
            builder.Add(Guid.Parse("213baa22-9dd1-4213-8ae2-dc482d1def48"), Traits.Instances.Kobold.ID);
            builder.Add(Guid.Parse("5972deab-95e0-4566-a531-adb06f855420"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae96e147-fe45-4bb1-821b-504c3658cd4a"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
