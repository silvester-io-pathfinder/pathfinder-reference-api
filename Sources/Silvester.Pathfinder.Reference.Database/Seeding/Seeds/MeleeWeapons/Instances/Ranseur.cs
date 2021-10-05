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
    public class Ranseur : Template
    {
        public static readonly Guid ID = Guid.Parse("ba3999d5-d8fa-4263-b1f7-8d5913a080c0");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Ranseur",
                Description = "This polearm is a long trident with a central prong that’s longer than the other two.",
                Price = 200,
                Damage = "1d10",
                Hands = "2",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Polearm.ID,
                DamageTypeId = Piercing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disarm.ID;
            yield return Traits.Instances.Reach.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7a1dd57-3093-44ef-97de-085239426d5d"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
