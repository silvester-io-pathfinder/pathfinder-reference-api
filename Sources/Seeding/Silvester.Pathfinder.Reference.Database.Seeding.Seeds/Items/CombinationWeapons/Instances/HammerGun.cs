using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class HammerGun : Template
    {
        public static readonly Guid ID = Guid.Parse("03a615fd-151c-45a2-8e89-47db40e177b5");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Hammer Gun",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f1702d0e-fdf9-408c-b940-87c11553923d"), "This weapon, favored by dwarves and those who like smashing and shooting, takes the form of a stoutly built gun designed similarly to an arquebus with a hammer head built into the muzzle, decreasing kickback but limiting range."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("4adb3352-7829-4cac-a4d7-38192c2a4321");
            Guid meleeComponentId = Guid.Parse("269aa434-a37d-473c-b011-ebb923f0e79c");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("9106fb4c-f0ac-4ddd-9fea-b9079e8e22ad"),
                Name = "Hammer Gun",
                Price = 1300,
                Hands = "2",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 60,
                    Reload = 1,
                    Damage = "1d6",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("15c6c16e-119c-42f0-b8a1-6f6a940226dc"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("b2ce63ef-2017-4786-886e-6bd24b90c086"), Traits.Instances.Fatal.ID, "d10")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d8",
                    WeaponGroupId = WeaponGroups.Instances.Hammer.ID,
                    DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("edd9ed7b-7260-452b-bd32-8793046243d0"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("27383fa1-21d2-4fe1-bea8-fc6dd0515dc0"), Traits.Instances.Shove.ID)
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f485b5d0-4f53-46bd-8955-2e57b088d605"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
