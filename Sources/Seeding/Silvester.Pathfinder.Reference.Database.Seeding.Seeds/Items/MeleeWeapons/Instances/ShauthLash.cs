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
    public class ShauthLash : Template
    {
        public static readonly Guid ID = Guid.Parse("fdd7f7db-241e-4d1c-bc53-7b280dc679f1");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Shauth Lash",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("7c6942c8-3e9c-4a3b-ac20-1fd0f8c3bffc"),
				Name = "Shauth Lash",
				Price = 800,
				Hands = "2",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("0f913c65-09c6-4dfe-8a40-9c98ab801024"), "This metal chain bears hook-like barbs made of alchemically strengthened urdefhan teeth. Magical shauth lashes have the same ability to channel an urdefhan wielder's Wicked Bite as magical shauth blades, and urdefhans hold these weapons with the same reverence as they do shauth blades.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e31f5921-2fb6-4b04-ab46-500417afe30b"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("fe4026b4-36a6-455e-8ae5-0fb0fca60e11"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("f769e53f-24f0-4fba-a62d-de862485ab24"), Traits.Instances.Trip.ID);
            builder.Add(Guid.Parse("1edd0b43-2b27-439b-9c57-8c862e69debd"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a764b309-d1f9-4236-9c0f-cc9d74c262d9"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
