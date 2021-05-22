using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class ElvenCurveBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("07b728c8-b6a9-4d6c-97ec-acda2ef83daa");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Elven Curve Blade",
                Description = "Essentially a longer version of the scimitar, this traditional elven weapon has a thinner blade than its cousin.",
                Price = 400,
                Damage = "1d8",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Elf.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Forceful.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d40f8d4-0dfc-4bb0-9998-288dd43fcfea"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
