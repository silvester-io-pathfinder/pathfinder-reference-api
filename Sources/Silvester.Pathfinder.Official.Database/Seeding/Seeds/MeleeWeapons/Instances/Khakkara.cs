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
    public class Khakkara : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("50de7f64-76a6-4bf0-9d0e-0b57aea3ba85");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Khakkara",
                Description = "This staff is topped by a pointed metal circle from which hang several smaller rings that jingle and clang noisily as the staff is moved, allowing you to announce your presence and scare off wild animals as you walk.",
                Price = 200,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Shove.ID;
            yield return Traits.Instances.TwoHand.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Versatile.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b0e10a8-cc3f-4639-b945-72c60f05bf5c"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
