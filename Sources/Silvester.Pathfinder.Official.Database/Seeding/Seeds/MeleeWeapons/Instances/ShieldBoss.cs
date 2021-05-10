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
    public class ShieldBoss : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("144ba3e5-2778-4c37-ab98-7bd61556f902");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Shield Boss",
                Description = "Typically a round, convex, or conical piece of thick metal attached to the center of a shield, a shield boss increases the bludgeoning damage of a shield bash.",
                Price = 50,
                Damage = "1d6",
                Hands = "1",
                BulkId = NegligibleBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Shield.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attached.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ece86339-9bf6-4c12-8b41-3c6ab6ff6f13"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
