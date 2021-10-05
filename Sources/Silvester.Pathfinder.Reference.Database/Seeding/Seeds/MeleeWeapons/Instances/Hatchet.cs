using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class Hatchet : Template
    {
        public static readonly Guid ID = Guid.Parse("28896820-702d-47fa-8aa8-f3e6e5d9bf67");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Hatchet",
                Description = "This small axe can be used in close combat or thrown.",
                Price = 40,
                Damage = "1d6",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Axe.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.Thrown.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15df22c2-3d04-4e90-b348-13d104f28ec0"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
