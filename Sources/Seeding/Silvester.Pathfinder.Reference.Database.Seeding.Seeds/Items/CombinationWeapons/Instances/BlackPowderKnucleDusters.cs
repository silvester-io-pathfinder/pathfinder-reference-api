using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class BlackPowderKnucleDusters : Template
    {
        public static readonly Guid ID = Guid.Parse("9ec24ef4-43be-428d-bfb6-e1d694f9cc95");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Black Powder Knucle Dusters",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a3b8c61e-4f42-48d0-9660-51dff20a60b9"), "This pair of knuckle dusters is fitted with an explosive charge of black powder within the hollowed spikes of the weapon and a firing mechanism you hold in your hand while in use."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("8ffada29-58a9-4ff4-bbe9-4de47470a987");
            Guid meleeComponentId = Guid.Parse("cc20ce24-cb01-4d80-b546-0384667ce288");
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("63fcbed8-1054-4a62-b681-9d46bb6fba1b"),
                Name = "Black Powder Knucle Dusters",
                Price = 800,
                Hands = "1",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 30,
                    Reload = 1,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("9f3faccb-e9b3-4f89-a297-1d58b93a334e"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("73a1b09e-9704-4afb-a97a-08608a7e4606"), Traits.Instances.Fatal.ID, "d8")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Brawling.ID,
                    DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("23063ec2-1aee-4dce-a41e-ab3cfd9489f9"), Traits.Instances.Agile.ID)
                        .Add(Guid.Parse("51c1d1fd-bc1a-43d4-a4a2-0510ea9b6c34"), Traits.Instances.CriticalFusion.ID)
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ca71c19-a950-43e8-bdb0-228a4128a445"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
