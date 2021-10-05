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
    public class Sickle : Template
    {
        public static readonly Guid ID = Guid.Parse("468f4c04-e696-47d6-a3e6-1f4e5f938ac9");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Sickle",
                Description = "Originally a farming tool used for reaping grain, this one-handed weapon has a short wooden handle ending in a curved blade, sometimes sharpened on both sides.",
                Price = 20,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = Knife.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Trip.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c1aa5df-53ee-428b-9aa6-d7d41b9a8dd0"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
