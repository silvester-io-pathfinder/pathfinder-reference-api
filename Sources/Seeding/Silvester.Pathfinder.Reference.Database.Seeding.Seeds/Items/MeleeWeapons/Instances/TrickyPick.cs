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
    public class TrickyPick : Template
    {
        public static readonly Guid ID = Guid.Parse("c4b2cc2b-36d9-459f-9361-1660a0243944");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Tricky Pick",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Pick.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("cb13af64-8dc4-41c9-94f1-da2f1bf1a2b6"),
				Name = "Tricky Pick",
				Price = 1000,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Modular.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("2da80a50-0814-45ed-8dfb-8f0575efa713"), "This ingenious kobold pick conceals several hidden traps, which the wielder can activate to trick and befuddle foes with a variety of damaging blades and bludgeoning surfaces.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("713fd855-267e-4f6c-9b9a-37b45279ae58"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("3572cb32-49b4-42b4-b353-24357de2e9de"), Traits.Instances.Fatal.ID);
            builder.Add(Guid.Parse("fa11bb90-4afa-453b-aef4-c97f5b2d3863"), Traits.Instances.Kobold.ID);
            builder.Add(Guid.Parse("ef1c0737-b103-406c-9355-1f46995069ac"), Traits.Instances.Modular.ID);
            builder.Add(Guid.Parse("ea59a4ba-9ca1-4902-a252-f99301011891"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bf406fa-0c9f-4013-a491-d0ef11f6cc6e"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
