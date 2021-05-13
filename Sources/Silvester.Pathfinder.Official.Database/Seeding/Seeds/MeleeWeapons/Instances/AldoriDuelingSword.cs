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
    public class AldoriDuelingSword : Template
    {
        public static readonly Guid ID = Guid.Parse("412f2018-c2f7-493f-b213-8fe8ca14b7ff");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Aldori Dueling Sword",
                Description = "An Aldori dueling sword is a slim, single-bladed dueling sword with a slight curve and a sharp, reinforced point.",
                Level = 1,
                Price = 2000,
                Damage = "1d8",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Versatile.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a533ae3-a77e-4c69-8d1f-f65ca2ef0042"),
                SourceId = WorldGuide.ID,
                Page = 28
            };
        }
    }
}
