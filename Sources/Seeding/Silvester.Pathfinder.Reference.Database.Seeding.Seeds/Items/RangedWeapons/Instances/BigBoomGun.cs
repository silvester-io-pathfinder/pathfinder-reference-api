using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class BigBoomGun : Template
    {
        public static readonly Guid ID = Guid.Parse("a4d74720-efb2-45ee-abf4-8fbc1a9a7fb6");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Big Boom Gun",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("596d3865-845f-4c11-93bd-e1366739bd9a"), "Developed by a goblin weaponsmith who missed the 'hand' part of 'hand cannon', this comically-oversized gun has a heavily reinforced barrel and is loaded with a worrisome quantity of gunpowder. This hand cannon is a martial weapon, instead of a simple weapon. It has the fatal d12 trait and a range of 20 feet. It also has the following modified critical failure condition:");;
            builder.Enumeration(Guid.Parse("c3f5a1a5-f1ba-4747-84f6-b7a41f52973a"), "Critical Failure The attack misses, the weapon misfires, and you take 1d12 fire damage as it explodes in your face.");
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("1bce524d-67fa-4604-85af-282737d57384"),
				Name = "Big Boom Gun",
				Hands = "2",
				Price = 1000,
				Reload = 1,
				Range = 20,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Modular.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5d18a1c5-9a8a-4831-8cdc-53933753e099"), Traits.Instances.Cobbled.ID);
            builder.Add(Guid.Parse("bc8c9e5a-5dc8-482b-bc88-bebf87f4abf0"), Traits.Instances.Fatal.ID, "d12");
            builder.Add(Guid.Parse("bd70be62-afff-4e89-88f8-a1ce4641a32c"), Traits.Instances.Goblin.ID);
            builder.Add(Guid.Parse("0cee4030-613e-4d05-bfd8-08c9af8a5692"), Traits.Instances.Modular.ID, "B, P or S");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77a30d29-f07e-4dd7-a027-05133329fa2e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 157
            };
        }
    }
}
