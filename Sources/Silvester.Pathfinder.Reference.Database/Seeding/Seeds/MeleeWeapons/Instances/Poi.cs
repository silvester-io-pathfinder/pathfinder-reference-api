using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class Poi : Template
    {
        public static readonly Guid ID = Guid.Parse("c4fd14aa-156a-4efe-9807-90cf492ed32e");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Poi",
                Description = "Poi are light weights tethered to ropes or chains. Performers swing the weights, usually one in each hand, in rhythmic patterns.",
                Price = 20,
                Damage = "1d4",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e034be48-76a2-4af9-ba68-e06d3520a264"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
