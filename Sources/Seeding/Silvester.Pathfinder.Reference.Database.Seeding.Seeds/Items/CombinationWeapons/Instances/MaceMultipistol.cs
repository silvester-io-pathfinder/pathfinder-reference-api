using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class MaceMultipistol : Template
    {
        public static readonly Guid ID = Guid.Parse("6765ffe0-e6a0-43ca-94d4-d77a72705117");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Mace Multipistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d13f566f-18a4-40db-9e62-71ff8784c615"), "At first glance this weapon looks like nothing more than an iron-bound club. But the top of the weapon features a latch that opens to reveal three rotating pistol muzzles concealed in the mace�s head that can be fired and rotated using triggers built into the weapon�s haft."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("5343bb4a-1aa7-40bc-85c1-5bc777626ddf");
            Guid meleeComponentId = Guid.Parse("5e36e2db-eb69-4b95-a799-7cb5ed0f363b");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("3bf43b49-1533-4a26-8867-f79cab7922a2"),
                Name = "Mace Multipistol",
                Price = 1300,
                Hands = "1",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.OneBulk.ID, 
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 20,
                    Reload = 1,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("3bc01f9a-c2f8-452f-a8b5-049ea95b7a37"), Traits.Instances.Capacity.ID, "3")
                        .Add(Guid.Parse("9b41d9a6-4630-4fba-a8a0-2a8c7b527466"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("4e6f0532-670a-4503-b8f8-74f306f68620"), Traits.Instances.Fatal.ID, "d8")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d6",
                    WeaponGroupId = WeaponGroups.Instances.Club.ID,
                    DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("42569c50-397d-4db1-9bfb-dcc5e940fe12"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("86accfdc-cff1-4df8-ab12-1928ccabecbe"), Traits.Instances.Shove.ID)
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b427370b-93d0-4def-8db9-79fd991d7446"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
