using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonFey : Template
    {
        public static readonly Guid ID = Guid.Parse("4b567885-82ec-4c86-bbe3-4c04f343198f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Fey",
                Level = 1,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2959bdd1-bef6-42ae-8a6f-a683757057e7"), Type = TextBlockType.Text, Text = "You conjure an fey to fight for you. You summon a common creature that has the fey trait and whose level is –1, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("58c0c1d1-e172-4c52-97c3-9c3aad1eab39"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7720e21d-3c99-4e9e-8dfa-0bb1aaead097"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f505e113-1e13-4b69-a35b-5023a7c57400"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("85006a62-86e5-4312-a314-7d86b119d8ed"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("87c1ac59-f734-4fb8-adfe-0b8a0dccb2c2"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("12bd495a-71b8-4ba3-87aa-d2b867397c41"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("bc271aee-303e-4a52-8712-7357c0725d37"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("56ea1a97-0971-4621-aa78-d8f88331d028"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("cd549118-dc55-4164-80b0-dbd7a119a0a4"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("54ed2588-0e56-4843-902c-a245649a534c"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("b6604390-6f03-4d6d-86bc-de9b48b75447"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fc566234-b78e-472d-9d67-5c4b6c8b8a48"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("ab5eb5f3-2b00-48bf-a4c9-a56acf638d14"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("79cbeba2-732d-4926-a83e-3db5d99f4506"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9bdff995-b4cc-4c3d-9169-9e02e7435328"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("94b5afac-4c57-4c97-b3af-0b3c59b454cc"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f600fba9-9c3c-408d-9ea8-372af7a278b6"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("89512e14-1fe3-442b-a66b-cd664162c0a5"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
                }
            };

        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c8b4a965-0992-47b8-a494-c7d3e2f6ecb1"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a54fdd3e-7a0a-4da9-8c18-bc5fe562b819"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
