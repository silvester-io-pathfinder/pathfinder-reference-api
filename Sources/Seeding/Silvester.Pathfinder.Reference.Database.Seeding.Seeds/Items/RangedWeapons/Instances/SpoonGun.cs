using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class SpoonGun : Template
    {
        public static readonly Guid ID = Guid.Parse("fc8c787a-300d-457b-a212-32cc2727950a");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Spoon Gun",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("60b3d845-bdd8-4d05-af9c-b2342fcea4e1"), "No one's entirely certain who developed the spoon gun, but all authorities agree that it was probably a goblin. Essentially a terrible idea in firearm form, the spoon gun is a spring-powered hand cannon with a modified grip that uses miscellaneous knives, forks, chopsticks, and spoons as ammunition. Users typically upend the entire contents of their cutlery drawer into the gun, aim it in the general direction of the foe, and hope it hits something.");;
            builder.Text(Guid.Parse("5cf01952-93ca-4559-94d5-5f492c719cba"), "This hand cannon is a martial weapon, instead of a simple weapon. It has the scatter (5 feet) trait and uses cutlery or similar-sized objects as ammunition instead of bullets (enough cheap cutlery to fire ten shots costs 1 sp).");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("c8a4d69e-b41c-407a-9f53-1e086a2b74a8"),
				Name = "Spoon Gun",
				Hands = "1",
				Price = 1000,
				Reload = 1,
				Range = 30,
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Modular.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c2abbfe-0fa0-4fd1-9ee1-8f45873f69e0"), Traits.Instances.Cobbled.ID);
            builder.Add(Guid.Parse("be23cac6-7f18-45bb-abad-ec12854706de"), Traits.Instances.Goblin.ID);
            builder.Add(Guid.Parse("f67dc71d-7f69-4022-89b3-81b18b952eaa"), Traits.Instances.Modular.ID, "B, P or S");
            builder.Add(Guid.Parse("1bc8db36-6b9d-4e84-b913-3745d2c3d343"), Traits.Instances.Scatter.ID, "5 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8105c28f-f26f-4427-9a74-b99347ac8b14"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 157
            };
        }
    }
}
