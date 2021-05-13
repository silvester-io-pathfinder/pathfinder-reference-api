using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RangedWeapons.Instances
{
    public class AlchemicalCrossbow : Template
    {
        public static readonly Guid ID = Guid.Parse("fc7b92de-da67-4924-8ee2-b07bfbec720d");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Alchemical Crossbow",
                Description = "This crossbow can deliver alchemically infused bolts. The strange weapon has a metal bracket mounted on the side of the stock near the lath. As an action, you can load a single lesser alchemical bomb into the bracket; this bomb must be one that deals energy damage (such as an acid flask, alchemist’s fire, bottled lightning, frost vial, or thunderstone). The next three attacks made with the crossbow deal 1d6 damage of the bomb’s damage type in addition to the crossbow’s normal damage. If the second and third attacks are not all made within 1 minute of the first attack, the bomb’s energy is wasted. These attacks never deal splash damage or other special effects of the bomb and are not modified by any abilities that add to or modify a bomb’s effect. The addition of the bracket serves to unbalance the weapon, reducing its range to 30 feet. It otherwise functions as a crossbow (when determining damage, reload, and so on). Creatures use their crossbow proficiency when using the alchemical crossbow. The alchemical crossbow costs 25 gp.",
                Range = 30,
                Reload = 1,
                Price = 2500,
                Damage = "1d8",
                Hands = "2",
                AmmunitionId = Bolts.ID,
                BulkId = OneBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Bow.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("538738b0-b51d-4e95-9468-2954f72fedba"),
                SourceId = TheFallOfPlaguestone.ID,
                Page = 56
            };
        }
    }
}
