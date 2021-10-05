using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class Falchion : Template
    {
        public static readonly Guid ID = Guid.Parse("ea69a9bc-a39b-4a43-90fc-c27ee0f776fd");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Falchion",
                Description = "This weapon is a heavier, two-handed version of the curved-bladed scimitar. It is weighted toward the blade’s end, making it a powerful slashing weapon.",
                Price = 300,
                Damage = "1d10",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Forceful.ID;
            yield return Traits.Instances.Sweep.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("232b9f8d-2696-4cb3-b52a-91973e6f4096"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
