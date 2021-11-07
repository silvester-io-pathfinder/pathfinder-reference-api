using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class FightingFan : Template
    {
        public static readonly Guid ID = Guid.Parse("3b7c5c1b-8be2-4152-bae1-475f9853919c");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Fighting Fan",
                Description = "This fan is useful for elegant dances as well as for slicing unsuspecting foes with the blades along its outer edge. If used in performances, it might be disguised as a frilly accessory, or it might be an obvious, though elegant, weapon.",
                Price = 100,
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
            yield return Traits.Instances.Backstabber.ID;
            yield return Traits.Instances.Deadly.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Monk.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8013ef6-44c3-4d26-9818-3723d71e995d"),
                SourceId = LostOmensGodsAndMagic.ID,
                Page = 120
            };
        }
    }
}
