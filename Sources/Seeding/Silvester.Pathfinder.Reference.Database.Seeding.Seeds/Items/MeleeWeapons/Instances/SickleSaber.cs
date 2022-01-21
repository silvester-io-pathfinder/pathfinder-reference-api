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
    public class SickleSaber : Template
    {
        public static readonly Guid ID = Guid.Parse("c638e5fe-974c-4e77-a2d5-956d8b608b04");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Sickle-Saber",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("74001d51-fda9-401a-9dbe-0eb82f196734"),
				Name = "Sickle-Saber",
				Price = 500,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("0f27649d-36e5-47c8-956f-278ed0c6b749"), "A classical weapon of Irrisenis who lacked magical talent, the sickle-saber has seen a resurgence since the coronation of Queen Anastasia. The queen was fascinated with the sickle-sabers in the palace treasury, and now the unusual blades are carried by her honor guard and Irriseni diplomats alike. The sickle-saber's blade curves multiple times along its 4-foot length, and its hilt is similarly curved. A small, secondary grip on the blade lets the wielder rapidly and unpredictably twist the cutting edges.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("902c4ef5-84ae-4098-9e6e-e8fa7ebef1b8"), Traits.Instances.Backswing.ID);
            builder.Add(Guid.Parse("8e21a4cc-7376-4900-ac4e-0c7a7926255f"), Traits.Instances.Forceful.ID);
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acdf43aa-1d3b-4b76-a287-6cf66d178e01"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 106
            };
        }
    }
}
