using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Shock : Template
    {
        public static readonly Guid ID = Guid.Parse("6d938515-a83b-4723-8d18-8ea81102e987");

        public static readonly Guid STANDARD_ID = Guid.Parse("581d1b62-a5c2-4063-9780-28b6e357a7d7");
        public static readonly Guid GREATER_ID = Guid.Parse("bd875c19-2d25-4ba7-9ec4-45511a22aa17");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Shock",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Shock",
                Usage = "Etched onto a weapon.",
                Level = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c68ada15-1087-430e-86e6-3e1f681d5323"), "Electric arcs crisscross this weapon, dealing an extra 1d6 electricity damage on a hit. On a critical hit, electricity arcs out to deal an equal amount of electricity damage to up to two other creatures of your choice within 10 feet of the target.")
                    .Build()
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Shock (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1d296e50-3de8-49d9-9338-172e371c75bb"), "Electricity damage dealt by this weapon ignores the target's electricity resistance (and the other creatures' on a critical hit).")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("bb5a4613-4fe9-4d87-a592-6cc97cbebc5e"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("5fd0dd1e-2073-489c-9a0a-54c39f6b316a"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("f7202cd1-31ac-4ce5-892d-40c0f3974cea"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e389d823-6701-403e-9022-d1da6883b266"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
