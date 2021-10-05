using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
{
    public class GnomeFlickmace : Template
    {
        public static readonly Guid ID = Guid.Parse("a954ad09-22bd-4f8b-945a-05dddea08cdc");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Gnome Flickmace",
                Description = "More a flail than a mace, this weapon has a short handle attached to a length of chain with a ball at the end. The ball is propelled to its reach with the flick of the wrist, the momentum of which brings the ball back to the wielder after the strike.",
                Price = 300,
                Damage = "1d8",
                Hands = "1",
                BulkId = TwoBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = WeaponGroups.Instances.Flail.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Gnome.ID;
            yield return Traits.Instances.Reach.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("477ef8a4-079c-4527-bbea-ab4a0cb22e7d"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
