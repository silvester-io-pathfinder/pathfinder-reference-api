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
    public class ShauthBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("e3996bab-ff49-45d2-a295-c46fe7347717");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Shauth Blade",
                Description = "These strange curved blades are jagged and deadly weapons made from the alchemically strengthened teeth of dead urdefhans. Each weapon is typically named for the urdefhan whose teeth were forged into the weapon, which are often carried (and revered) by that urdefhan's descendants. Magical shauth blades allow an urdefhan wielder to channel their Wicked Bite ability through shauth blade Strikes.",
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
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Versatile.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82483b0d-8bf1-4be2-a629-7d51914ce120"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
