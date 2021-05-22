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
    public class Polytool : Template
    {
        public static readonly Guid ID = Guid.Parse("24f3accf-0ba9-491d-94fc-4e8abe71ff23");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Polytool",
                Description = "The polytool is a small metal rod with a number of simple tools folded inside. The user can extend a long ceramic blade, as well as an awl, a chisel, a file, flint and steel, a hook, an inkpen, a magnifying glass, pliers, scissors, and a small saw. The flint and steel can be used up to 10 times before needing to be replaced. Though inspired by advanced Numerian technology, the polytool is a simple enough feat of metalworking that any blacksmith could produce it— perfect for the goddess Casandalee to spread innovation farther than actual Numerian tech could reach.",
                Level = 1,
                Price = 1000,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Modular.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Modular.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f68749e-73f2-4fd7-81ad-440d303de9e5"),
                SourceId = GodsAndMagic.ID,
                Page = 121
            };
        }
    }
}
