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
    public class BoStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("9966d8d0-e1ae-4e62-9411-988d67474769");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Bo Staff",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("3f7ee9db-8b2c-4ef7-8ced-8756caebcc8e"),
				Name = "Bo Staff",
				Price = 20,
				Hands = "2",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("61c13168-1f76-4982-98a9-de550f78e804"), "This strong but slender staff is tapered at the ends and well balanced. It's designed to be an offensive and defensive weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ee0a5a71-e360-461f-b57e-73cc7ef8e532"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("f87ef25a-b3e4-43fd-a7fd-304c624ac97a"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("7f2a1920-6080-4100-91ee-60f1f4429ee2"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("4b889e80-c00b-4224-b320-2458730fb926"), Traits.Instances.Trip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("195ba1fc-dbcf-4884-8d33-b0c40b8c9e42"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
