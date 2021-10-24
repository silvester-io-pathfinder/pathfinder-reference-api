using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FundamentalArmorRunes.Instances
{
    public class ResillientRune : Template
    {
        public static readonly Guid ID = Guid.Parse("412582f8-84db-4344-a9cf-5d8e1208f72e");

        protected override FundamentalArmorRune GetRune()
        {
            return new FundamentalArmorRune
            {
                Id = ID,
                Name = "Armor Resillient Rune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1aa8fb59-3d43-49d3-b5e0-e85a02b66419"), Type = TextBlockType.Text, Text = "Resilient runes imbue armor with additional protective magic." };
            yield return new TextBlock { Id = Guid.Parse("81c79bd9-a634-4de6-98e8-5e7c621becb2"), Type = TextBlockType.Text, Text = "You can upgrade the resilient rune already etched on a suit of armor to a stronger version, increasing the values of the existing rune to those of the new rune. You must have the formula of the stronger rune to do so, and the Price of the upgrade is the difference between the two runes’ Prices." };
        }

        protected override IEnumerable<FundamentalArmorRuneVariant> GetLevels()
        {
            yield return new FundamentalArmorRuneVariant
            {
                Id = Guid.Parse("6683a69a-90e0-4cfc-915f-a1e044a8c3e1"),
                Name = "Standard",
                Benefits = "The armor grants a +1 item bonus to saving throws.",
                ItemLevel = 8,
                Price = 34000
            };

            yield return new FundamentalArmorRuneVariant
            {
                Id = Guid.Parse("44794e5c-af23-47d9-90fe-25384c7b8bf9"),
                Name = "Greater",
                Benefits = "The armor grants a +2 item bonus to saving throws.",
                ItemLevel = 14,
                Price = 344000
            };

            yield return new FundamentalArmorRuneVariant
            {
                Id = Guid.Parse("13e71b88-5fa6-4da7-bf26-90c0d9044983"),
                Name = "Major",
                Benefits = "The armor grants a +3 item bonus to saving throws.",
                ItemLevel = 20,
                Price = 4944000
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
                Id = Guid.Parse("03bc38ca-cc39-4179-b938-cd39502e445b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 581
            };
        }
    }
}
