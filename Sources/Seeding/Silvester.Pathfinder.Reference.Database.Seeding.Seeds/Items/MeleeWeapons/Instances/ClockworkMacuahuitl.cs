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
    public class ClockworkMacuahuitl : Template
    {
        public static readonly Guid ID = Guid.Parse("6176c957-3934-45c2-b507-036a34f4164c");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Clockwork Macuahuitl",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("57723e0a-46e2-49d9-b902-940536b5029a"),
				Name = "Clockwork Macuahuitl",
				Price = 55000,
				Hands = "2",
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("a12d670b-dd57-454b-85d0-d0ed8ff5834b"), "This finely-made wooden club has a beautiful, lacquered finish that gleams in the sunlight. A heavy ring of gears lined with sharpened pieces of obsidian automatically and constantly spin around the bulk of the wooden club lengthwise. Striking a foe digs the obsidian gears into the enemy's flesh and tears it with its blades. The ever-turning gears also help to dislodge an enemy's defensive position against the weapon.")
					.Text(Guid.Parse("b5e1f305-3550-4f19-9dda-372279f7c2c5"), "The clockwork macuahuitl deals 1d10 slashing damage and has the backswing, forceful, and versatile B traits. The clockwork macuahuitl is a two-handed advanced weapon in the club weapon group.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7235698b-492e-4352-bbcb-ff6eb1f1621e"), Traits.Instances.Backswing.ID);
            builder.Add(Guid.Parse("f6bdbc52-eaa1-4abb-8ec4-747e64884fe7"), Traits.Instances.Clockwork.ID);
            builder.Add(Guid.Parse("d8adf4ff-ad51-479e-8b98-4c30782ed557"), Traits.Instances.Forceful.ID);
            builder.Add(Guid.Parse("e13da139-308a-42a2-b89a-da40d8a7af5c"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("f12d8684-ffd3-41d2-a800-eaf2cb203b32"), Traits.Instances.Versatile.ID, "B");
		}

		protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c24af547-a5d1-4044-9267-6618f046d9b5"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 22
            };
        }
    }
}
