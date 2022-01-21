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
    public class TempleSword : Template
    {
        public static readonly Guid ID = Guid.Parse("a460d789-3935-4629-a976-f9b71d96181c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Temple Sword",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("ed0e7ffc-7a24-4ec2-a960-7131fd47023b"),
				Name = "Temple Sword",
				Price = 200,
				Hands = "1",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("b88a8658-c312-4f98-89a1-e920e561351e"), "This heavy blade is favored by guardians of religious sites. It has a distinctive, crescent-shaped blade that seems to be a mix of a sickle and sword. It often has holes drilled into the blade or the pommel so that bells or other holy trinkets can be affixed to the weapon as an aid for prayer or mediation.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("739e12f9-453e-4337-a2d7-26544f584c3c"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("41fd2ef4-ac12-4d33-bb17-64581443e6d5"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("b9db5431-f8b9-4f87-9ad7-4360639eb68c"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("210b63cd-cf1e-401e-9166-893d1b8bfb09"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
