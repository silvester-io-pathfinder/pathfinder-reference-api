using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FundamentalWeaponRunes.Instances
{
    public class PotencyRune : Template
    {
        public static readonly Guid ID = Guid.Parse("907264a7-e146-493c-a8ae-33c406a25b33");

        protected override FundamentalWeaponRune GetRune()
        {
            return new FundamentalWeaponRune
            {
                Id = ID,
                Name = "Weapon Potency Rune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("02e64508-1a08-461d-b94b-4ecb7a4ddbac"), Type = TextBlockType.Text, Text = "Magical enhancements make this weapon strike true." };
            yield return new TextBlock { Id = Guid.Parse("4940b654-9d55-4d56-86b5-fca5c9f1b9ef"), Type = TextBlockType.Text, Text = "You can upgrade the weapon potency rune already etched on a weapon to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes’ Prices." };
        }

        protected override IEnumerable<FundamentalWeaponRuneVariant> GetLevels()
        {
            yield return new FundamentalWeaponRuneVariant
            {
                Id = Guid.Parse("0e4a6126-fd04-4e86-93b4-997032016396"),
                Benefits = "Attack rolls with this weapon gain a +1 item bonus, and the weapon can be etched with one property rune.",
                Name = "+1",
                ItemLevel = 2,
                Price = 3500
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = Guid.Parse("2e93ab6a-46e0-479e-a8b9-4b3a8d9e5bbf"),
                Benefits = "The item bonus to attack rolls is +2, and the weapon can be etched with two property runes.",
                Name = "+2",
                ItemLevel = 10,
                Price = 93500
            };

            yield return new FundamentalWeaponRuneVariant
            {
                Id = Guid.Parse("16a06450-88dd-4537-abb2-d216d13e288b"),
                Benefits = "The item bonus to attack rolls is +3, and the weapon can be etched with three property runes.",
                Name = "+3",
                ItemLevel = 16,
                Price = 893500
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d22db014-7b95-449a-b459-ac8db99a9ba5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 581
            };
        }
    }
}
