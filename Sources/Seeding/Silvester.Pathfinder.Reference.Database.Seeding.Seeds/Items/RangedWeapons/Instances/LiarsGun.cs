using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class LiarsGun : Template
    {
        public static readonly Guid ID = Guid.Parse("50f9b2af-86c6-4818-8115-e3467fb28e4f");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Liar's Gun",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3ae44e46-e414-4133-9a71-a56d431826af"), "This dubious weapon gets its name from the fact that it's typically crafted with multiple false barrels so that it's more difficult for enemies to predict the weapon's angle of fire from the four working barrels. Most of the time, this gun functions as a +1 striking pepperbox with capacity 4 instead of capacity 3, albeit one with a complicated loading mechanism involving rotating the barrels. In a pinch though, all four of the real barrels can be fired simultaneously.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("3d573bd1-8a2e-4f11-ae5e-bb95605b658e"),
				Name = "Liar's Gun",
				Hands = "1",
				Price = 1200,
				Reload = 1,
				Range = 60,
				Damage = "2d4",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ef897832-2f68-4429-8033-14c154648cfb"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Interact")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("9c20d795-6319-420e-a89b-24f6c437791f"), "Make up to four Strikes with the liar's gun. Each of the four Strikes must be against a different target within a 20-foot cone. You apply and increasing your multiple attack penalty for the four Strikes only after resolving all attacks. If the weapon misfires on any of these attacks, wait to apply the misfire until you resolve all of the attacks.");
                           });
                    })
                    .Build()
            };
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("413dfe45-ff8f-4456-935d-92d2937eaea4"), Traits.Instances.Cobbled.ID);
            builder.Add(Guid.Parse("486c92ce-571f-46e2-ac54-9fcf2c51e9ca"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("fda6a1d4-ec37-4747-8aff-adda9736d38d"), Traits.Instances.Capacity.ID, "4");
            builder.Add(Guid.Parse("a451a807-9c1e-4c87-8495-6366ded6eb94"), Traits.Instances.Fatal.ID, "d8"); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59917762-eecf-46b7-b203-aa06ede2fa81"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 157
            };
        }
    }
}
