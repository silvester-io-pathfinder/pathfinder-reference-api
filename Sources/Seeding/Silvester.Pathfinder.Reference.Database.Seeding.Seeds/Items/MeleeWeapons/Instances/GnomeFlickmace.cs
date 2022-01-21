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
    public class GnomeFlickmace : Template
    {
        public static readonly Guid ID = Guid.Parse("a954ad09-22bd-4f8b-945a-05dddea08cdc");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Gnome Flickmace",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c72d6845-37e9-46e5-869c-4d4a6a06f056"),
				Name = "Gnome Flickmace",
				Price = 300,
				Hands = "1",
				Damage = "1d8",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("13e26ff0-fc5a-4c28-a7af-0219f369d6b5"), "More a flail than a mace, this weapon has a short handle attached to a length of chain with a ball at the end. The ball is propelled to its reach with the flick of the wrist, the momentum of which brings the ball back to the wielder after the strike.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("eebe4249-3f28-4ca8-9b06-fd00350081e4"), Traits.Instances.Gnome.ID);
            builder.Add(Guid.Parse("63b93102-5177-4e0d-a662-4c3689cbdedc"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("63c8ecc3-b84f-4470-bf68-12f53c5ac5fe"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("477ef8a4-079c-4527-bbea-ab4a0cb22e7d"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
