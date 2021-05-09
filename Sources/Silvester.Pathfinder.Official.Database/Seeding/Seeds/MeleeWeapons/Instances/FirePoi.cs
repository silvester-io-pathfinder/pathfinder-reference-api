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
    public class FirePoi : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("af5dff58-65ad-402e-b78c-4cc9eee8e126");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Fire Poi",
                Description = "These special poi are made from a rare, light metal or from fire-retardant fibers and can be ignited before being wielded. Igniting a pair of fire poi is an Interact action and requires 1 pint of oil for every 10 minutes the poi remain ignited. While lit, fire poi cast dim light in a 10-foot radius; in combat, they deal 1d4 bludgeoning plus 1d4 fire damage. On a critical hit with a lit fire poi, the target takes 1 persistent fire damage. The fire can be extinguished using the Interact action. When unlit, the poi deal only the listed bludgeoning damage. Regardless of whether it is lit, the poi’s 1d4 bludgeoning damage is the weapon damage dice, so striking runes and other effects don’t affect the fire damage.",
                Price = 500,
                Damage = "1d4 B + 1d4 F",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Flail.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Backswing.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Twin.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6339002f-07a7-4021-a557-3d7bc6c3a120"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
