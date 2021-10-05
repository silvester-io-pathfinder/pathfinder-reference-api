using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class ThunderingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("796898b3-9662-411f-ac5e-7a40a8008976");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Thundering",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("f5847e4b-aea8-4e00-911f-f010b728daed"),
                ItemLevel = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("5d42cd08-c0ce-4e2d-9853-af20869429f2"), Type = TextBlockType.Text, Text = "This weapon lets out a peal of thunder when it hits, dealing an extra 1d6 sonic damage on a successful Strike. On a critical hit, the target has to succeed at a DC 24 Fortitude save or be deafened for 1 minute (or 1 hour on a critical failure)."},
                },
            };

            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("72606c00-caaf-4ac6-9fed-e8cc51c39593"),
                ItemLevel = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("43a36fa8-f7a4-4c49-8cf7-0bd08378d2f9"), Type = TextBlockType.Text, Text = "The save DC is 34, and the deafness is permanent. Sonic damage dealt by this weapon ignores the target’s sonic resistance."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd84a129-2cd1-4780-b420-e9d7b9bcab0d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
