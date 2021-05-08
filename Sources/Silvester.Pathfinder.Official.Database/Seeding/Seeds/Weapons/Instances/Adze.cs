using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Weapons.Instances
{
    public class Adze : AbstractWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Weapon GetWeapon()
        {
            return new Weapon
            {
                Id = ID,
                Name = "Adze",
                Description = "A common cutting tool, an adze resembles an axe—but the cutting edge is horizontal, rather than vertical. The adze's shape makes it popular among wood workers, and grippli builders often use them to construct their treetop homes. The tool also serves as an effective weapon, due in part to the immense strength required to swing it.",
                Price = 100,
                Damage = "1d10",
                Hands = 2,
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Axe.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Forceful.ID;
            yield return Traits.Instances.Grippli.ID;
            yield return Traits.Instances.Sweep.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
