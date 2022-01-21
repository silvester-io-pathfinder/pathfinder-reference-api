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
    public class Shears : Template
    {
        public static readonly Guid ID = Guid.Parse("1b8c3bae-b8b0-4613-ab32-0103efb6bab0");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Shears",
				WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("df9dce6e-1447-4b22-b517-1cc6444a32ca"),
				Name = "Shears",
				Price = 50,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("839ab154-f76a-4488-8877-1b8cec604f39"), "No description was provided for this weapon.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c915aceb-e832-40f6-b3ac-3bb67dba2715"), Traits.Instances.Deadly.ID);
            builder.Add(Guid.Parse("c09f71e0-0474-43ba-8b55-87930572bcc2"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("d47fd978-b01a-4cac-b740-060b98508f48"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("3677f8e8-01f0-4061-93aa-050ec303e7bd"), Traits.Instances.Versatile.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fe3990b-51c4-4f74-8279-6b2e7051b614"),
                SourceId = Bestiary2.ID,
                Page = 184
            };
        }
    }
}
