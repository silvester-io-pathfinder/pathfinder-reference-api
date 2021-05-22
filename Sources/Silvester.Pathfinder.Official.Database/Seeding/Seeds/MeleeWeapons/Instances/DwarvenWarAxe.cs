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
    public class DwarvenWarAxe : Template
    {
        public static readonly Guid ID = Guid.Parse("d0b1390b-25b4-4302-91e0-4c80963125ce");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Dwarven War Axe",
                Description = "This favored weapon of the dwarves has a large, ornate head mounted on a thick handle. This powerful axe can be wielded with one hand or two.",
                Price = 300,
                Damage = "1d8",
                Hands = "1",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Axe.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Dwarf.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.TwoHand.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23fd9739-93e5-4241-aaaa-4160682f213a"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
