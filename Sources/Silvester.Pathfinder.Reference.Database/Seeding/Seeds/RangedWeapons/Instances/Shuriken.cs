using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class Shuriken : Template
    {
        public static readonly Guid ID = Guid.Parse("1139c9c1-84b6-4e03-85bd-a7d779716297");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Shuriken",
                Description = "This “throwing star” is a small piece of flat metal with sharp edges, designed to be flung with a flick of the wrist.",
                Range = 20,
                Reload = 0,
                Price = 1,
                Damage = "1d4",
                Hands = "1",
                BulkId = NegligibleBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Thrown.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ee225e2-9330-431e-809b-6239b917be67"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
