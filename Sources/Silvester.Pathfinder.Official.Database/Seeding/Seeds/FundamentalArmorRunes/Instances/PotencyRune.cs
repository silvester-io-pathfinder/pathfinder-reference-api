using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FundamentalArmorRunes.Instances
{
    public class PotencyRune : Template
    {
        public static readonly Guid ID = Guid.Parse("aa56af92-069d-4cfd-81e6-ab2af589f662");

        protected override FundamentalArmorRune GetRune()
        {
            return new FundamentalArmorRune
            {
                Id = ID,
                Name = "Armor Potency Rune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a7f4f82a-f5e4-485c-a38c-c115f33df11f"), Type = TextBlockType.Text, Text = "Magic wards deflect attacks." };
            yield return new TextBlock { Id = Guid.Parse("3aa7b1ef-a9fe-4fe4-9943-ee40d8cbc528"), Type = TextBlockType.Text, Text = "You can upgrade the armor potency rune already etched on a suit of armor to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes’ Prices." };
        }

        protected override IEnumerable<FundamentalArmorRuneVariant> GetLevels()
        {
            yield return new FundamentalArmorRuneVariant
            {
                Id = Guid.Parse("47f5b617-be1e-47f8-b165-bf6b5cc705cd"),
                Benefits = "Increase the armor’s item bonus to AC by 1. The armor can be etched with one property rune.",
                Name = "+1",
                ItemLevel = 5,
                Price = 16000
            };

            yield return new FundamentalArmorRuneVariant
            {
                Id = Guid.Parse("238aa717-ede1-4cae-87c2-fe17a69860bd"),
                Benefits = "Increase the armor’s item bonus to AC by 2, and the armor can be etched with two property runes.",
                Name = "+2",
                ItemLevel = 11,
                Price = 106000
            };

            yield return new FundamentalArmorRuneVariant
            {
                Id = Guid.Parse("b5330c4e-a43b-4367-a69a-cfb63fe01d06"),
                Benefits = "Increase the armor’s item bonus to AC by 3, and the armor can be etched with three property runes.",
                Name = "+3",
                ItemLevel = 18,
                Price = 2056000
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9b00728-bb97-4e1a-9346-b85b2d4ebf5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 581
            };
        }
    }
}
