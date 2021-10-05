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
    public class SawtoothSaber : Template
    {
        public static readonly Guid ID = Guid.Parse("cc1b83d3-b2b8-4268-b434-e0d84b418d1b");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Sawtooth Saber",
                Description = "The signature weapon of the Red Mantis assassins, this curved blade is serrated like a saw, hence the name.",
                Price = 500,
                Damage = "1d6",
                Hands = "1",
                BulkId = LightBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Sword.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Agile.ID;
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Twin.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9fe72e6-dd0d-4721-9550-cdb6a86ec81f"),
                SourceId = CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
