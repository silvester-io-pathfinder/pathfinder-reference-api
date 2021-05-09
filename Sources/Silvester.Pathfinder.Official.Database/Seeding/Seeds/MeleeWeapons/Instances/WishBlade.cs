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
    public class WishBlade : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("d9ea2c6f-772e-455e-8cf3-dd6c5961ed06");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Wish Blade",
                Description = "Specialized grooves lined with unique, alchemically treated metals capable of retaining energy score the length of this sword. The first wish blades originated from genie smiths, and the knowledge of these weapons has been passed on to generations of geniekin, earning them the name wish blades.",
                Price = 500,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Geniekin.ID;
            yield return Traits.Instances.Resonant.ID;
            yield return Traits.Instances.TwoHand.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64f89b92-6a27-440a-9715-521682b5b35e"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
