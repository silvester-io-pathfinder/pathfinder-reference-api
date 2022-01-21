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
    public class HookSword : Template
    {
        public static readonly Guid ID = Guid.Parse("caded408-d3ee-4c78-9ffe-165191d4a08d");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Hook Sword",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("5fe0ae7e-75f3-446d-a526-18e6b8c45469"),
				Name = "Hook Sword",
				Price = 300,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("b87991c9-f9b3-45fa-b51a-846731ea9803"), "This long sword has a hook near the tip which makes it easy to snag an opponent or their weapons.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("307e24ff-06e2-4a90-b4b1-1065166c8162"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("17460d8f-6150-43af-84de-e5121664efbf"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("32c358b5-77ad-4a67-9e90-f0f14389fdb3"), Traits.Instances.Parry.ID);
            builder.Add(Guid.Parse("9bd45b72-1a21-49e8-b51a-38cf32be37d7"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("381f3c6c-04ad-4bb7-a903-07c49f6e5e13"), Traits.Instances.Twin.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a88588d0-065b-491a-930d-5455db0cdcf2"),
                SourceId = Sources.Instances.Pathfinder166.ID,
                Page = 76
            };
        }
    }
}
