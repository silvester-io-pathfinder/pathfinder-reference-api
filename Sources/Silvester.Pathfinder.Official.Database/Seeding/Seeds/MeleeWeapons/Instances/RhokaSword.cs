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
    public class RhokaSword : Template
    {
        public static readonly Guid ID = Guid.Parse("c4d0ca3f-2c38-4603-ba33-205882d743a4");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Rhoka Sword",
                Description = "These dual-bladed swords are commonly used by urdefhan warriors.",
                Price = 400,
                Damage = "1d8",
                Hands = "1",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.TwoHand.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("709fb88f-087b-4029-b388-d02ed75031b1"),
                SourceId = Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
