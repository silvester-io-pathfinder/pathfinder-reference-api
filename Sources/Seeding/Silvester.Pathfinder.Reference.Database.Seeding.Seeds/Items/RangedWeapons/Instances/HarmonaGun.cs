using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class HarmonaGun : Template
    {
        public static readonly Guid ID = Guid.Parse("2ebd9923-235a-43d1-b968-67298167425b");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Harmona Gun",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5593e37a-ca8a-4bb7-ac3a-fb8427703d68"), "A favored weapon of monster hunters in Arcadia, the harmona gun is a large-bore long gun that fires a heavy, slow-moving round. The gun got its name due to the eerie similarity between the buzzing sound its oversized projectiles make flying through the air and the flight of a fey bird called a harmona.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("dc03d824-3411-499f-95c7-9412ab924163"),
				Name = "Harmona Gun",
				Hands = "2",
				Price = 1000,
				Reload = 1,
				Range = 150,
				Damage = "1d10",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4045c816-c314-41e8-a962-513cecf2d74d"), Traits.Instances.Kickback.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6f2b206-9c88-46f0-bc7f-bf856bcee6eb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
