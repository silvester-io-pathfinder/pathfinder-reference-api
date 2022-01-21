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
    public class Whip : Template
    {
        public static readonly Guid ID = Guid.Parse("35cd5f74-df96-445c-ac79-76372f2bb36e");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Whip",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("d8766f21-ea11-4448-b6ad-e90bd91ab4e3"),
				Name = "Whip",
				Price = 10,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("8cbfa1a3-d4f0-46dc-949f-f4c1824dc71f"), "This long strand of thick leather, often braided, delivers a painful but nonlethal slash at a distance, usually accompanied by a distinctive cracking sound.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8a4135fb-1345-4bcf-861c-fadfe4d0cf32"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("da24c88a-09cc-47fe-8a62-61ab28e351b0"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("5716ed61-706c-4fd1-85c7-083c3cbfe04c"), Traits.Instances.Nonlethal.ID);
            builder.Add(Guid.Parse("12c5dd03-a018-437e-aafc-adcf52af95cd"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("e507e39c-54d4-4a06-a16f-c7987b15980f"), Traits.Instances.Trip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5233e7f-ca17-4835-9efc-2544bef86514"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
