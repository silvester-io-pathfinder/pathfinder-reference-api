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
    public class Greataxe : Template
    {
        public static readonly Guid ID = Guid.Parse("0b7a0bce-0829-4304-be0d-8fa7cd8c7232");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Greataxe",
                Description = "This large battle axe is too heavy to wield with only one hand. Many greataxes incorporate two blades, and they are often 'bearded', having a hook at the bottom to increase the strength of their chopping power.",
                Price = 200,
                Damage = "1d12",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Axe.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Sweep.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68c1c395-1656-48cd-82f4-7e26a9354b47"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
