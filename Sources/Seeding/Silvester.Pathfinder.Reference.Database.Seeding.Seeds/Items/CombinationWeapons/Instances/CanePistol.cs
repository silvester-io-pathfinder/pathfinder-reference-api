using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.CombinationWeapons.Instances
{
    public class CanePistol : Template
    {
        public static readonly Guid ID = Guid.Parse("8e1aeb6f-10a1-4e0e-b9ee-d9c0be38ad8a");

        protected override CombinationWeapon GetCombinationWeapon()
        {
            return new CombinationWeapon
            {
                Id = ID,
                Name = "Cane Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("25800703-48e5-4848-abb7-fe05132543b0"), "This fashionable cane�s handle hides a dueling pistol fired through the thin, painted cap at the bottom of the cane."); ;
        }

        protected override IEnumerable<CombinationWeaponVariant> GetCombinationWeaponVariants()
        {
            Guid rangedComponentId = Guid.Parse("6bb5e57d-00e3-40f8-a196-7d8189d59dd7");
            Guid meleeComponentId = Guid.Parse("bf2f923b-a53c-439d-bc0f-b138a744d6f5");

            yield return new CombinationWeaponVariant
            {
                Id = Guid.Parse("6d8c14c4-28c0-49ad-b692-7c7dc377fc79"),
                Name = "Cane Pistol",
                Price = 800,
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
                        .Add(Guid.Parse("3a346ef6-e145-4311-98c5-0ded3da87d96"), Traits.Instances.Concussive.ID)
                        .Add(Guid.Parse("0c7ae1aa-09b5-4c28-b790-c0a0e75f36ac"), Traits.Instances.Fatal.ID, "d8")
                        .Build()
                },
                MeleeComponent = new CombinationWeaponMeleeComponent
                {
                    Id = meleeComponentId,
                    Damage = "1d4",
                    WeaponGroupId = WeaponGroups.Instances.Club.ID,
                    DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                    TraitBindings = new TraitBindingBuilder<CombinationWeaponComponentTraitBinding, CombinationWeaponComponent>(meleeComponentId)
                        .Add(Guid.Parse("06eb14e3-df1c-402a-b886-03e2fc072be6"), Traits.Instances.CriticalFusion.ID)
                        .Add(Guid.Parse("2999422f-9b08-45a1-ad58-385810dee662"), Traits.Instances.Thrown.ID, "10 ft.")
                        .Build()

                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fac2217e-36f4-4916-b614-29d6ca469888"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 158
            };
        }
    }
}
