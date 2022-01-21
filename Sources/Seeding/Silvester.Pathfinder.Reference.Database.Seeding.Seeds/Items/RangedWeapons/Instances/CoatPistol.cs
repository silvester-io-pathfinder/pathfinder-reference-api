using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class CoatPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("63b03901-677d-4de2-b671-e3467a3d6190");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Coat Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a9c5bfdd-de63-4308-8857-dc22b3acac13"), "This small pistol is easily concealed inside a jacket or some other article of clothing. Rarely kept as a primary weapon, coat pistols are equally favored by clever assassins and traveling Alkenstar aristocrats.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("4312fb67-a9c4-4a55-b0f6-be46c3c8b5a8"),
				Name = "Coat Pistol",
				Hands = "1",
				Price = 600,
				Reload = 1,
				Range = 30,
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2553643f-ef5f-4fad-9124-69708434bbd6"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("a13f5c06-7f07-4a01-98e6-bcf16949d122"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("414cb7c0-b381-4997-b926-2bda9e1ae43c"), Traits.Instances.Fatal.ID, "d8"); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f9caaeb-e8fd-41ec-97ee-702af71b890b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
