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
    public class WhipClaw : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("a3dfa737-402e-48c5-8010-bf305d77ca60");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Whip Claw",
                Description = "The whip claw is a long tether affixed to clawlike daggers, allowing the wielder to fling and retract them with deadly precision. Catfolk developed this weapon to provide extended reach when hunting dangerous animals and wield them with unmatched expertise.",
                Price = 500,
                Damage = "1d6",
                Hands = "2",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Catfolk.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Hampering.ID;
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fcd29f0-25f5-4dd6-b4a4-f8828a27dfe6"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
