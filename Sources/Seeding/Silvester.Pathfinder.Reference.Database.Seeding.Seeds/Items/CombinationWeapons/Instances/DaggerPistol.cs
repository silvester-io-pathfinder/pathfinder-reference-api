using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class DaggerPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("1b0e0ff0-15b5-41e8-bfe5-3112cc11b0d7");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Dagger Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ba529dce-e832-41db-af9e-2e3afd23e3cf"), "This weapon, favored by rangers and other wilderness wanderers, takes the form of a stoutly built pistol with a dagger blade attached beneath the barrel and extending out past the muzzle."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId  = Guid.Parse("6ae11703-1b79-43b9-8aa2-68983a50c65c");
            Guid meleeComponentId = Guid.Parse("05ecac9a-316c-4a3c-81b2-8c9eeecf7608");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("da71968a-1545-4e6c-9898-35733f6ebbdc"),
                Name = "Dagger Pistol",
                Price = 800,
                Hands = "1",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 30,
                    Reload = 1,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("6c477115-3a29-492e-95df-7543050808c1"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("6370e87f-580e-4055-974e-fb15d57ebf9e"), Traits.Instances.Fatal.ID, "d8")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Knife.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("6364a940-a8e4-4b27-8454-3d0e9ec77596"), Traits.Instances.Agile.ID)
                        .Add(Guid.Parse("0ed4f2b7-ed64-4cbf-8265-079dafc8ed74"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("2ee256af-32f1-4da9-b936-d212a14bff1e"), Traits.Instances.Finesse.ID)
                        .Add(Guid.Parse("a064e987-b9f5-4110-bc76-7466b9d2f469"), Traits.Instances.Thrown.ID, "10 ft.")
                        .Add(Guid.Parse("2ad5a73d-17ea-4360-b187-e14300ca020c"), Traits.Instances.Versatile.ID, "P")
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eaf12a00-4a83-43b0-b64e-810a202a1a35"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
