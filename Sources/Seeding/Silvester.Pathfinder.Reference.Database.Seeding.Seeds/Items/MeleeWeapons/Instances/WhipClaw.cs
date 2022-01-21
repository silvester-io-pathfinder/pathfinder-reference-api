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
    public class WhipClaw : Template
    {
        public static readonly Guid ID = Guid.Parse("a3dfa737-402e-48c5-8010-bf305d77ca60");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Whip Claw",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Flail.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("dee3ac0f-77b9-4ee2-abbe-c2858f7cbcd7"),
				Name = "Whip Claw",
				Price = 500,
				Hands = "2",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("16b47c05-cf32-49a5-91d5-1a00aae9b52d"), "The whip claw is a long tether affixed to clawlike daggers, allowing the wielder to fling and retract them with deadly precision. Catfolk developed this weapon to provide extended reach when hunting dangerous animals and wield them with unmatched expertise.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("dd173f34-324c-4f0e-9232-8304d5c5282d"), Traits.Instances.Catfolk.ID);
            builder.Add(Guid.Parse("3a19d325-7ac5-4c81-9f85-0a8863602a0c"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("751ed439-45cd-4681-8032-76211e907eb9"), Traits.Instances.Hampering.ID);
            builder.Add(Guid.Parse("602a9ab2-a41f-4292-b3e2-9a0a85abe80e"), Traits.Instances.Reach.ID);
            builder.Add(Guid.Parse("2c87eb11-f6cc-484b-a342-ac22524a3b5e"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fcd29f0-25f5-4dd6-b4a4-f8828a27dfe6"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
