using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class AxeMusket : Template
    {
        public static readonly Guid ID = Guid.Parse("51b4df4f-a32d-44a7-a8d1-a975450b0571");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Axe Musket",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("80eb248e-5fe6-4649-b85a-ac0e26ca67f9"), "This item, favored by firearms-using dwarves and barbarians, takes the form of a sturdy musket with an axeblade attached near the muzzle."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid meleeComponentId = Guid.Parse("c1f94797-f261-4c2d-bb1d-5dafe480aa37");
            Guid rangedComponentId = Guid.Parse("e31e0b9d-8cb1-491d-b584-41f480727b58");

            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("d39e92b6-a8e9-4842-a0bd-15e502f81e86"),
                Name = "Axe Musket",
                Price = 1000,
                Hands = "2",
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d8",
                    WeaponGroupId = WeaponGroups.Instances.Axe.ID,
                    DamageTypeId = DamageTypes.Instances.Slashing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("c0b72f89-646c-4ab2-addb-fd9419ad0b2c"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("661a028e-b39c-4295-b40d-5d6dc4d7f016"), Traits.Instances.Sweep.ID)
                        .Build()
                },
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 40,
                    Reload = 1,
                    Damage = "1d6",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("563005dd-daa3-4eeb-acd9-42cbd645c9db"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("612f0e24-8be0-4ec7-b05b-d286acca992f"), Traits.Instances.Fatal.ID, "d10")
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b34362c1-8773-4bb7-ac74-f382b3a71fea"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
