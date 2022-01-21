using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("761f2b0a-adb8-4648-8b89-05160d314c85");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Dragon",
                Level = 5,
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
            yield return new TextBlock { Id = Guid.Parse("f67e85b9-d939-4b23-967e-ba5e775245ba"), Type = TextBlockType.Text, Text = "You conjure a dragon to fight for you. You summon a common creature that has the dragon trait and whose level is 5 or lower, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f0387a08-3222-4f1e-bade-a9685bdfa844"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9d3d2dac-a2d6-4789-8e44-a276cb75152c"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("5eef3362-a7b3-4782-b02a-89b9975ad31e"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e9a6b507-908a-4cbb-86e5-985fce03a121"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("1163ae98-3248-48fc-af7c-2da6b2285d0d"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b9ed7701-342a-49de-af8c-eab4cb0114ec"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a612a64e-c74b-4664-9597-29218e52103f"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("dcacf9c5-82e1-426e-aee1-f2eea630d6c5"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("946297d7-394c-4786-8232-3a2b78817066"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("192bb671-b61b-44c3-bfc6-8d16f615addd"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("67cdac86-d5b9-4cff-a9c6-d013c71aeed2"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a882d656-ddd1-40e6-b9cb-42cc5b938347"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9c0d0bed-db54-4b0f-9f56-35ed1e4a38b5"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4eae2700-fa39-4aaa-9a7f-fd8af6826019"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("b33230ee-73a9-472c-8e12-322d9833b411"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b0676d96-8179-48ec-bf85-946d4ae92deb"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4ae27603-c4fd-4250-8d55-92fbba62d133"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7c50926e-6e34-4a34-acbe-f88d764d75df"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("eb36ce78-ba2e-475c-a49d-d112b52dca2a"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6fca768-dfd5-4472-a214-7cb8fef701cd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
