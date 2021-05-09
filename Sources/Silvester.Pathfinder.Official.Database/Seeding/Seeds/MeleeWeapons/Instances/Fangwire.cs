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
    public class Fangwire : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("0776b01d-d10c-41fa-8832-a7c718b7ff8e");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Fangwire",
                Description = "This kobold wire is thin and hard to see, making it perfect for an ambush. The wielder wraps the wire around a vulnerable spot, such as the neck, and twists it to inflict potentially fatal lacerations. The name derives from the use of a similar wire in traps, or slow fangs, with the word “slow” removed, as a fangwire gets quick results.",
                Price = 400,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Brawling.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Backstabber.ID;
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Grapple.ID;
            yield return Traits.Instances.Kobold.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae96e147-fe45-4bb1-821b-504c3658cd4a"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
