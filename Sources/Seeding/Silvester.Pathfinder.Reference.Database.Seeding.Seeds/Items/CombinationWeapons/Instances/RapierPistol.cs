using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class RapierPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("78265c5c-0375-4a31-b71a-0023702125e7");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Rapier Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5f97e321-11f2-4ede-a68c-3956999365d3"), "This elegant weapon is shaped similarly to a rapier with a pistol down the length of the blade."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("12518940-c114-42c2-9b87-a71fdc39303d");
            Guid meleeComponentId = Guid.Parse("66fadc5d-8a8a-4b7d-98f3-968573744522");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("37a45453-7c91-4ebc-901a-cb5711d09a03"),
                Name = "Rapier Pistol",
                Price = 1000,
                Hands = "1",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 30,
                    Reload = 1,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("9e6fcec6-0c9c-4f23-a4a7-cae1e2f6e1d1"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("7699dc90-6f0b-4700-9f00-3e2f1a94a5dd"), Traits.Instances.Fatal.ID, "d8")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Sword.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("3529b05b-170f-48fd-afb8-c8fa1d1a7e1e"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("cfdc2c6c-4953-467c-8319-4f897d1b31a4"), Traits.Instances.Deadly.ID, "d8")
                        .Add(Guid.Parse("0054538f-4bd2-4b62-9c22-b6984c3efedc"), Traits.Instances.Disarm.ID)
                        .Add(Guid.Parse("2bdde2cb-e7a9-4f4b-b7eb-fdcb351eb7d6"), Traits.Instances.Finesse.ID)
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f43e2332-9325-4f92-aae3-5afbd7bac2aa"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
