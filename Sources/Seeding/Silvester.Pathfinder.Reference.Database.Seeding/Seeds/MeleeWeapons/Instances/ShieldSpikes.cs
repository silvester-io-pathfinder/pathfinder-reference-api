using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class ShieldSpikes : Template
    {
        public static readonly Guid ID = Guid.Parse("9a1f8c50-b677-423b-aada-c0e7f7b6d2ad");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Shield Spikes",
                Description = "These metal spikes are strategically placed on the defensive side of the shield to deal piercing damage with a shield bash.",
                Price = 50,
                Damage = "1d6",
                Hands = "1",
                BulkId = NegligibleBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Shield.ID,
                DamageTypeId = Piercing.ID
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
                Id = Guid.Parse("3e8a720e-68c7-41f9-9e34-3fae2ca39c3d"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
