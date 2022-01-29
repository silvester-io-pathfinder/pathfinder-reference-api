using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class GnomeAmalgamMusket : Template
    {
        public static readonly Guid ID = Guid.Parse("9b853de6-964c-4b6b-b7ab-345524672214");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Gnome Amalgam Musket",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0cb2880b-803c-4c63-8e67-d9908c147c56"), "Rumored to be the result of a gnomish dare to make a variant of a hooked hammer that's even more intricate and complex, this weapon adds a musket to the mix of an already overcomplicated device."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("2f9fa3d6-40be-4e48-bbd0-ebc755fcaf0e");
            Guid meleeComponentId = Guid.Parse("2c50ec24-5d05-454f-b929-dddba181a9a9");
            
            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("90f762bd-cc62-483e-9be3-95343764d99e"),
                Name = "Gnome Amalgam Musket",
                Price = 1000,
                Hands = "2",
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RangedComponent = new CombinationWeaponRangedComponent
                {
                    Id = rangedComponentId,
                    Range = 40,
                    Reload = 2,
                    Damage = "1d6",
                    WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
                    DamageTypeId = DamageTypes.Instances.Piercing.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(rangedComponentId)
                        .Add(Guid.Parse("9d0a619b-c366-43ff-b062-659083cf65da"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("968a5ab0-8511-4441-bd86-051b61b1a928"), Traits.Instances.Fatal.ID)
                        .Add(Guid.Parse("54c2769f-c4af-4fc4-bf37-9447a67bf8a4"), Traits.Instances.Gnome.ID, "d10")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d8",
                    WeaponGroupId = WeaponGroups.Instances.Hammer.ID,
                    DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("7da7bd27-3b03-43ca-b7a9-d2c3e34267f4"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("c134e767-51fe-4174-949d-0f5e3f54f0a3"), Traits.Instances.Gnome.ID)
                        .Add(Guid.Parse("77577365-e695-48e7-a124-5667aa129f07"), Traits.Instances.Trip.ID)
                        .Add(Guid.Parse("eb2620a2-6a5d-456a-9da5-b7275272003e"), Traits.Instances.Versatile.ID, "P")
                        .Build()
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d335113e-3cc1-4d72-a9a1-c21e135c422f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
