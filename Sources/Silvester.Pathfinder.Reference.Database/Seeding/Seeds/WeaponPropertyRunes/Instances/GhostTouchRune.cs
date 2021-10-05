using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class GhostTouchRune : Template
    {
        public static readonly Guid ID = Guid.Parse("1080858f-20b5-4b69-a1d0-138f7230aba8");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Ghost Touch",
                Usage = "Etched onto a melee weapon.",
            };
        }
        
        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("f7b83dda-01b3-4baf-b4df-ec8e2ea0bdc0"),
                Price = 7500,
                ItemLevel = 4,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("d34d732c-49ed-4cbb-be44-d340acfb9302"), Type = TextBlockType.Text, Text = "The weapon can harm creatures without physical form. A ghost touch weapon is particularly effective against incorporeal creatures, which almost always have a specific vulnerability to ghost touch weapons. Incorporeal creatures can touch, hold, and wield ghost touch weapons (unlike most physical objects)."},
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("415b4896-96d5-4f3a-930c-5951809fa3ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
