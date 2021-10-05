using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class LightMace : Template
    {
        public static readonly Guid ID = Guid.Parse("b40cb041-7b1c-49fc-8c54-8b66afce34ae");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Light Mace",
                Description = "A light mace has a short wooden or metal shaft ending with a dense metal head. Used much like a club, it delivers heavy bludgeoning blows, but with extra power derived from the head’s metal ridges or spikes.",
                Price = 40,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Club.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Shove.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42c099df-55ea-40f8-81c5-6dfca855bbf2"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
