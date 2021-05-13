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
    public class TenguGaleBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("14ab5e55-3b4a-445c-b2e0-9f938b9a4895");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Tengu Gale Blade",
                Description = "This fan-shaped sword, designed by members of the tengu ancestry, has five broad blades that join at its hilt. Tengu sailors also use gale blades as makeshift weather vanes, as the sword spins to show the wind's direction when loosely held aloft.",
                Price = 400,
                Damage = "1d6",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Tengu.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b47a76b0-18f2-42da-af53-9200251c89b1"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
