using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class AxiomaticRune : Template
    {
        public static readonly Guid ID = Guid.Parse("6e45f674-8263-4aad-9d32-75f663ef8453");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Axiomatic",
                Usage = "Etched onto a weapon without an anarchic rune.",
                CraftingRequirements ="You are lawful."
            };
        }


        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("fd86cf2b-0c9f-4e6d-bb9b-16df35fad858"),
                ItemLevel = 11,
                Price = 140000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("1527ad18-d41f-4eda-b9df-293ddfe5b247"), Type = TextBlockType.Text, Text = "Complex and symmetrical, an axiomatic rune imbues a weapon with lawful energy. A weapon with this rune deals an additional 1d6 lawful damage against chaotic targets. If you are chaotic, you are enfeebled 2 while carrying or wielding this weapon."},
                    new TextBlock {Id = Guid.Parse("89f4c857-4818-4bd6-a2dd-7c98a3a9bb42"), Type = TextBlockType.Text, Text = "When you critically succeed at an attack roll with this weapon against a chaotic creature, instead of rolling, count each weapon damage die as average damage rounded up (3 for d4, 4 for d6, 5 for d8, 6 for d10, 7 for d12)."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Lawful.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8faf47e4-fe13-4b28-9717-1fb83543e2db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
