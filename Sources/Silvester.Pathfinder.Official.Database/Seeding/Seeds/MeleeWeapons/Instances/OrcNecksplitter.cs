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
    public class OrcNecksplitter : AbstractMeleeWeaponTemplate
    {
        public static readonly Guid ID = Guid.Parse("bb3d9d98-06cc-4e04-aedc-bcff42e9389b");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Orc Necksplitter",
                Description = "This single-bladed bearded axe has a jagged blade that’s perfect for separating bone from tendon and cartilage.",
                Price = 200,
                Damage = "1d8",
                Hands = "1",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Axe.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Forceful.ID;
            yield return Traits.Instances.Orc.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("217fa626-b44b-4373-a436-41b4c4730380"),
                SourceId = CoreRulebook.ID,
                Page =  281
            };
        }
    }
}
