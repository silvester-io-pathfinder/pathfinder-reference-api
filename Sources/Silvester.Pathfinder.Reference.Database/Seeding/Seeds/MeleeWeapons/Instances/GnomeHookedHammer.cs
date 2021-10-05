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
    public class GnomeHookedHammer : Template
    {
        public static readonly Guid ID = Guid.Parse("f828cf37-ae7a-4534-a5f3-d12558d731eb");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Gnome Hooked Hammer",
                Description = "This gnome tool and weapon features a hammer at one end and a curved pick on the other. It’s such a strange and awkward weapon that others think the gnomes are slightly erratic for using it.",
                Price = 200,
                Damage = "1d6",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Hammer.ID,
                DamageTypeId = Bludgeoning.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Gnome.ID;
            yield return Traits.Instances.Trip.ID;
            yield return Traits.Instances.TwoHand.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Versatile.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbbc98d4-cb52-4c9a-8d48-973996f7585b"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
