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
    public class Staff : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("cda161dd-7e4a-4188-811d-41393677c421");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Staff",
                Description = "This long piece of wood can aid in walking and deliver a mighty blow.",
                Price = 0,
                Damage = "1d4",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.TwoHand.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5a6f273-9672-4fdf-9202-727e5f9a3b01"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
