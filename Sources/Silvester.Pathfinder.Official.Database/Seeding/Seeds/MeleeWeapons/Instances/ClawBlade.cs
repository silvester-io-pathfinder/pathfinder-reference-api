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
    public class ClawBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("f5a772c0-8d78-4073-9b73-4b4c9fc8fbe3");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Claw Blade",
                Description = "The three parallel blades of this handheld weapon extend between the fingers to resemble the natural claws of the amurruns who created them, providing a way for those catfolk without suitable natural claws to share the fighting customs of their kin.",
                Price = 200,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Knife.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Catfolk.ID;
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Versatile.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e11bd8a-0f5e-4de1-82b3-896568dbc2d1"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
