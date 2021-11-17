using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class Nightstick : Template
    {
        public static readonly Guid ID = Guid.Parse("8dde67f3-49e5-4231-aa23-7e1d4abd63cc");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Nightstick",
                Description = "This collapsible baton consists of several nested, telescoping metal shafts that can be extended as a free action by flicking the wrist. Once extended to its full length (usually around 2 feet), the baton locks into shape until the wielder uses an Interact action to collapse it—a collapsed nightstick is 8 inches long, making it easily concealed. Lighter and more maneuverable than an ordinary club or truncheon, nightsticks are designed to subdue foes without causing permanent injury. A nightstick is an uncommon simple melee weapon.",
                Price = 100,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Nonlethal.ID;
            yield return Traits.Instances.Parry.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fc416c1-9963-4fc1-ba94-dab2a33c37ea"),
                SourceId = Pathfinder157.ID,
                Page = 78
            };
        }
    }
}
