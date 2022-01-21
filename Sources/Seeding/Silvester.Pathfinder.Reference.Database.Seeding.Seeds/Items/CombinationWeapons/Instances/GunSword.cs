using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class GunSword : Template
    {
        public static readonly Guid ID = Guid.Parse("042cb900-e746-4181-a515-e781e2c3f1ed");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Gun Sword",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f978cc9c-fc1a-4597-91e6-566ff7fbc677"), "This weapon consists of a large sword with a powerful gun based on a harmona gun down the center. Vanguards and other characters who rely on Strength and Dexterity enjoy the power and flexibility of a gun sword."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("8f3294ed-26d0-44f7-a005-4bdd7909c799");
            Guid meleeComponentId = Guid.Parse("fc276fab-9b6d-48cf-a6c1-e597f685949a");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("945605b7-a148-4711-af61-eb812a4f3955"),
                Name = "Gun Sword",
                Price = 1300,
                Hands = "2",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 50,
                    Reload = 1,
                    Damage = "1d8",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("263e2e6c-a17f-432a-b11a-ebf64a6111c3"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("991f4348-0031-40ff-91e7-b6b7cf6621b4"), Traits.Instances.Kickback.ID)
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d8",
                    WeaponGroupId = WeaponGroups.Instances.Sword.ID,
                    DamageTypeId = DamageTypes.Instances.Slashing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("817cec7b-3763-4b93-b8b1-7a3071e92d2b"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("da729bb6-e879-414d-9a64-0caac22cfe8d"), Traits.Instances.Versatile.ID, "P")
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3eb30a75-e343-4398-bab5-e134156fd00b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
