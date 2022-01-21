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
    public class HandAdze : Template
    {
        public static readonly Guid ID = Guid.Parse("a6a7ebc7-6129-448c-8936-ae2bc8ceda7c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Hand Adze",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Axe.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("4596cc2c-bd23-497e-91d4-9927d529d1fd"),
				Name = "Hand Adze",
				Price = 50,
				Hands = "1",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("9234cfce-1a7d-47fc-adf9-dd8e99ee7bb1"), "This is a smaller version of an adze, useful for more delicate woodworking or projects in cramped spaces. Gripplis use the hand adze for crafting and as close quarters weapons.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("059b5349-b96d-4909-b436-645d836d46ec"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("7a08f018-3847-40ce-83c3-cb69efc1b3b5"), Traits.Instances.Forceful.ID);
            builder.Add(Guid.Parse("d6e036af-d938-4bd6-8fd1-754a4d71753b"), Traits.Instances.Grippli.ID);
            builder.Add(Guid.Parse("07f7dca1-5bb6-4d3c-96c3-2dc7c40748e8"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("ecd74ef0-05bb-4b23-8800-ec39aa7ced71"), Traits.Instances.Thrown.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43895f3a-5f46-4fae-a25a-85dc5b30acbc"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
