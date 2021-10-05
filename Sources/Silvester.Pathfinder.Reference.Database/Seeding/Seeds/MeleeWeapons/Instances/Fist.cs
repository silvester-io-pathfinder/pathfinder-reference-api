using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class Fist : Template
    {
        public static readonly Guid ID = Guid.Parse("ade86474-5118-4236-81c2-a69905ff4d25");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Fist",
                Description = "No description was provided for this weapon.",
                Damage = "1d4",
                Hands = "1",
                WeaponCategoryId = WeaponCategories.Instances.Unarmed.ID,
                WeaponGroupId = Brawling.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Nonlethal.ID;
            yield return Traits.Instances.Unarmed.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12830f77-7c87-420a-9a31-d439c3f6f7d1"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
