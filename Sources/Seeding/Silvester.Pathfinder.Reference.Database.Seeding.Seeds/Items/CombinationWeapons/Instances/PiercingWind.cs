using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class PiercingWind : Template
    {
        public static readonly Guid ID = Guid.Parse("89ad8bf9-56f2-4c8e-9430-a78853160cef");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Piercing Wind",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("337d9e3f-056a-4615-863e-74fe33c27115"), "Favored by caravan guards who traverse the Mana Wastes, a piercing wind is similar to a jezail, in that you can carry it in one hand as long as the other hand�s free, by holding it under one arm. Additionally, it�s fitted with an underslung curved blade."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("f9869b58-8344-46a1-8344-f0366e2c8d0e");
            Guid meleeComponentId = Guid.Parse("034d4051-7324-4189-a9ca-3411082e6297");
           
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("9754d766-51d5-440a-903a-db8c9607e7e2"),
                Name = "Piercing Wind",
                Price = 1500,
                Hands = "1",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 40,
                    Reload = 1,
                    Damage = "1d6",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("3eca7f73-102f-4fc0-896f-2295bb617513"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("d8f33ff8-7734-4d23-939c-c7424bd952a3"), Traits.Instances.FatalAim.ID, "d10")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Sword.ID,
                    DamageTypeId = DamageTypes.Instances.Slashing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("a1accf9d-f787-47f8-a24b-56c866a4e033"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("9e47b8fc-4e5f-42a3-9fb2-111baa534e89"), Traits.Instances.Finesse.ID)
                        .Add(Guid.Parse("b4651d68-fe61-4e33-934e-a7c20a9e5593"), Traits.Instances.Forceful.ID)
                        .Add(Guid.Parse("8e427308-d70f-4efa-8807-cfe7899531f3"), Traits.Instances.Sweep.ID)
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c8d412b-aedb-4fc9-9fba-9d3d6a867e40"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
