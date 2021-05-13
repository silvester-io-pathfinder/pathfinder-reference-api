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
    public class Buugeng : Template
    {
        public static readonly Guid ID = Guid.Parse("09595caf-7209-4ffa-b4cc-524a9c9807c0");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Buugeng",
                Description = "A blade of conrasu design, a buugeng has a unique, curved shape that allows it to rotate smoothly in the hand of a trained warrior. This spinning motion makes it easier to attack multiple foes at once with the weapon.",
                Price = 400,
                Damage = "1d4",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Conrasu.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.Twin.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0df0f9b4-f422-4334-949b-0c62d75e5454"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
