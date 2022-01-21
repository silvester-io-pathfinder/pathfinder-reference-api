using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class ThreePeakedTree : Template
    {
        public static readonly Guid ID = Guid.Parse("f7cb0368-318a-47c3-b31a-75ed9299c2da");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Three Peaked Tree",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cd9e47a4-37af-4fef-b1db-b95b9a929b5c"), "A recently developed weapon created for an elven champion from Jinin, the three-peaked tree can be used as both a trident and a mithral tree. A three-peaked tree has a length of silken rope attached to the butt of its haft, allowing it to be quickly retrieved after thrown.");;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("05bf4ce0-2a41-479d-ada5-d32f89682c31");
            Guid meleeComponentId = Guid.Parse("a08c4b7b-f9ef-495b-9596-b086b71faa64");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("24000b42-8a63-40fa-bc31-1a3a7c525c0a"),
                Name = "Three Peaked Tree",
                Price = 1200,
                Hands = "2",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 60,
                    Reload = 1,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("48fc4221-54ad-49bc-9f42-9ad2fc8cf1b7"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("7b470e48-392f-4606-aa22-681c7ccb2b17"), Traits.Instances.Elf.ID)
                        .Add(Guid.Parse("3a049c7b-2730-4d93-9ac6-5aa54e3bb38d"), Traits.Instances.Fatal.ID, "1d8")
                        .Add(Guid.Parse("2e5a5ef4-8111-4d0d-8629-fc05535bbb23"), Traits.Instances.Parry.ID)
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d8",
                    WeaponGroupId = WeaponGroups.Instances.Spear.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("fc1a48d2-f392-45ad-9664-86a4cd2f0ec8"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("5f6ba8f7-67c8-4b10-9622-865707b66cf1"), Traits.Instances.Elf.ID)
                        .Add(Guid.Parse("d9f58f54-9bb2-455b-9c14-4e1be7dc89a7"), Traits.Instances.Tethered.ID)
                        .Add(Guid.Parse("160aba22-dbdf-42dc-ab64-61f3eebfd37b"), Traits.Instances.Thrown.ID, "20 ft.")
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("496ee455-1ba4-4c3d-85cb-78a10ce557b0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
