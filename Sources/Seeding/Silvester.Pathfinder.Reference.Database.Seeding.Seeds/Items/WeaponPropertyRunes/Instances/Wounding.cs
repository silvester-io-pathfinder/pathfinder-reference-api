using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Wounding : Template
    {
        public static readonly Guid ID = Guid.Parse("819a6e90-6506-4cc3-8938-f0ffbffc01b2");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Wounding",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("f4de6228-1e02-4a73-a6ed-a7f328a26eac"),
                Name = "Wounding",
                Usage = "Etched onto a piercing or slashing melee weapon.",
                Level = 7,
                Price = 34000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("8b173bbe-1116-4a16-a533-5d3a6b6ad049"), "Weapons with wounding runes are said to thirst for blood. When you hit a creature with a wounding weapon, you deal an extra 1d6 persistent bleed damage. On a critical hit, it instead deals 1d12 persistent bleed damage.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6cadc44f-3c00-4c67-b728-5266c240aa68"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("924c07cb-5c34-48f7-857c-b70e537d3f00"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35747fc8-b2c2-48f4-92b0-9ed7d31417e8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
