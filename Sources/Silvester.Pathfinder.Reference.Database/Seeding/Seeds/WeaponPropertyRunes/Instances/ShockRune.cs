using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class ShockRune : Template
    {
        public static readonly Guid ID = Guid.Parse("6d938515-a83b-4723-8d18-8ea81102e987");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Shock",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("581d1b62-a5c2-4063-9780-28b6e357a7d7"),
                ItemLevel = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("c68ada15-1087-430e-86e6-3e1f681d5323"), Type = TextBlockType.Text, Text = "Electric arcs crisscross this weapon, dealing an extra 1d6 electricity damage on a hit. On a critical hit, electricity arcs out to deal an equal amount of electricity damage to up to two other creatures of your choice within 10 feet of the target."},
                },
            };

            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("bd875c19-2d25-4ba7-9ec4-45511a22aa17"),
                ItemLevel = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("1d296e50-3de8-49d9-9338-172e371c75bb"), Type = TextBlockType.Text, Text = "Electricity damage dealt by this weapon ignores the target’s electricity resistance (and the other creatures’ on a critical hit)."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
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
