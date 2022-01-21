using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class MithralTree : Template
    {
        public static readonly Guid ID = Guid.Parse("3e29ca23-15f5-41fc-a2ba-04af78ce1411");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Mithral Tree",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ab2a1a59-30f4-47ea-9893-1e3eecbf844c"), "Neither mithral nor a tree, this long gun takes its name from the legends of the elves of Jinin and is most commonly found within the nation. An elegant weapon, a mithral tree does somewhat resemble a tree; its fanned stock and long, sweeping barrel reinforced with metal rings enable a wielder to parry melee attacks while moving back into safe firing range.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("74c55e2d-f3a4-4a5e-bf3f-94542fc62ea2"),
				Name = "Mithral Tree",
				Hands = "2",
				Price = 900,
				Reload = 1,
				Range = 150,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("80f4410f-8ca1-4b7d-889c-c119d0a82066"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("12da677d-d337-42be-85b1-d7dd892d90da"), Traits.Instances.Elf.ID);
            builder.Add(Guid.Parse("959b8e28-c297-4000-9c2c-b05de0fbe55c"), Traits.Instances.Fatal.ID, "d10");
            builder.Add(Guid.Parse("b6c572f7-4974-4993-8764-874ad2485a82"), Traits.Instances.Parry.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfb4dea2-14f4-43f0-a297-c9ee08646284"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
