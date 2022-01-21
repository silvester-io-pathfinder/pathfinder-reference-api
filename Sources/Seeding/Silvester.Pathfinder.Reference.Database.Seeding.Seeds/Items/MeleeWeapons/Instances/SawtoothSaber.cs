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
    public class SawtoothSaber : Template
    {
        public static readonly Guid ID = Guid.Parse("cc1b83d3-b2b8-4268-b434-e0d84b418d1b");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Sawtooth Saber",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("c11f530e-d460-4965-ad31-b74dcdcf9de9"),
				Name = "Sawtooth Saber",
				Price = 500,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("cc9ff4b0-485b-4364-9c09-2ed522f83090"), "The signature weapon of the Red Mantis assassins, this curved blade is serrated like a saw, hence the name.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("120fa3f2-be90-43c1-af95-e9dd172adb17"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("e3256a4d-3f2e-4343-8ec9-aa667f35fcc6"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("29f88a11-9743-44f6-8ec3-b369afd3e53e"), Traits.Instances.Twin.ID);
            builder.Add(Guid.Parse("de252827-23a6-4fa4-b6ee-c89f101acaa1"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9fe72e6-dd0d-4721-9550-cdb6a86ec81f"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
