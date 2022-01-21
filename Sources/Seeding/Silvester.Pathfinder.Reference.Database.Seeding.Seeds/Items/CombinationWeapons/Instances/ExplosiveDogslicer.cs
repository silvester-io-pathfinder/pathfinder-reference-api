using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class ExplosiveDogslicer : Template
    {
        public static readonly Guid ID = Guid.Parse("d7b33ff3-12d5-4c3d-ac4c-2d5a77a7ef12");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Explosive Dogslicer",
                WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("67f40ac0-fc7b-459c-8716-19622b14e709"), "An explosive dogslicer is a sneaky, explosive weapon that often brings perverse joy to the goblins who use them. At first glance, it appears to be a triple-bladed dogslicer with an oversized guard."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("2fde2375-10ff-458e-9cf1-78d39be82ee6");
            Guid meleeComponentId = Guid.Parse("0bfff252-245c-45ac-bcd5-95b701a2a834");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("2042aba8-6ff2-4a9e-822d-9b9987d34c82"),
                Name = "Explosive Dogslicer",
                Price = 1000,
                Hands = "2",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 20,
                    Reload = 1,
                    Damage = "1d6",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Slashing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                    .Add(Guid.Parse("e4a84a52-b9f6-4544-ab21-556c5f203e0a"), Traits.Instances.Backstabber.ID)
                    .Add(Guid.Parse("7afdb2b4-95d5-4348-bf99-ab9c02a71924"), Traits.Instances.Goblin.ID)
                    .Add(Guid.Parse("802a780b-d170-45e2-a950-5bea4a00a697"), Traits.Instances.Scatter.ID, "5 ft.")
                    .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d6",
                    WeaponGroupId = WeaponGroups.Instances.Sword.ID,
                    DamageTypeId = DamageTypes.Instances.Slashing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                    .Add(Guid.Parse("c64481bf-6121-4856-89c9-ee6915386239"), Traits.Instances.Backstabber.ID)
                    .Add(Guid.Parse("6816816e-b51b-4f55-80c9-8b5c79efdc4f"), Traits.Instances.CriticalFusion.ID)
                    .Add(Guid.Parse("3ab5d48b-c36f-4181-a461-cdea6126bc23"), Traits.Instances.Finesse.ID)
                    .Add(Guid.Parse("6d9fd401-1493-44d1-8099-c6a90201cc92"), Traits.Instances.Goblin.ID)
                    .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbd8adf1-5b1c-4003-b971-fa7f04d2f73b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
