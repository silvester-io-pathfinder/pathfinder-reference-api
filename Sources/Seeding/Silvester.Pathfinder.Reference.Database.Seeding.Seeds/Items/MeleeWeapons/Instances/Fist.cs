using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class Fist : Template
    {
        public static readonly Guid ID = Guid.Parse("ade86474-5118-4236-81c2-a69905ff4d25");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Fist",
                WeaponCategoryId = WeaponCategories.Instances.Unarmed.ID,
                WeaponGroupId = Brawling.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {

        }

        protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
        {
            yield return new MeleeWeaponVariant
            {
                Id = Guid.Parse("535bdc7c-7e5b-4713-a04e-390daac3a393"),
                Name = "Fist",
                Damage = "1d4",
                Hands = "1",
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                DamageTypeId = DamageTypes.Instances.Bludgeoning.ID
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d40d4e32-4b2a-4c2c-99a5-8ee5beb975d0"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("1d1adf21-51c8-494d-90c3-23fd4a368d76"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("e9fb6003-0953-4d03-8174-d74660f35b49"), Traits.Instances.Nonlethal.ID);
            builder.Add(Guid.Parse("98f67598-1cad-4499-9b77-e7f59c4e52c4"), Traits.Instances.Unarmed.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12830f77-7c87-420a-9a31-d439c3f6f7d1"),
                SourceId = CoreRulebook.ID,
                Page = 280
            };
        }
    }
}
