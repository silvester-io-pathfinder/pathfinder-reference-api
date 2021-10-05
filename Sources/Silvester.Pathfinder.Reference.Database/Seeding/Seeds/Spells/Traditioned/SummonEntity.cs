using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonEntity : Template
    {
        public static readonly Guid ID = Guid.Parse("e6d92b4b-b0ca-4d41-addc-8a8a3f3326b7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Entity",
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
            yield return new TextBlock { Id = Guid.Parse("89a48eb0-970b-43d8-8564-29fb00e2a89e"), Type = TextBlockType.Text, Text = "You conjure an aberration to fight for you. You summon a common creature that has the aberration trait and whose level is 5 or lower, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("939491d7-00d1-4f60-9b19-0d5f04068c68"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7c5a59d0-bf66-494d-bcc2-3401fefc3269"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("dbbd2ef9-c0f6-4803-ae13-5b3badaabe3e"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f1127050-0406-4a67-9eca-bd75af220c32"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("39ba8433-c5dd-4f74-81ec-d6113bb7f783"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f8ae94d4-c14c-4148-a310-e3cf63106692"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("e2d61116-f24e-4eca-a55e-d9bde4a20dcf"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a3b06e74-49ed-4a2a-a6f9-c6ac6279454a"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("46288aea-c319-4f70-955e-0afe101905d0"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cabbcd04-d127-4ad6-850a-3dffa1aed5a4"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("ace84c40-7059-4870-9f4f-c7003a42cfdc"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bb1eeea4-6471-408e-8b58-a9d47738a684"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("6ccea681-e84d-49c7-9674-1a6b8ed84473"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f2cb584b-2927-41bc-842c-26477a60e0ed"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("88bddd6a-f5f4-46cc-9a17-77fade4824ef"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("74ad72bc-a33d-4c14-8571-71830ffae86b"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("36d52e95-47ef-4547-917e-0142bdbb8e81"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0f646590-d40e-4d02-aa44-6f009cc46893"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4a1fbea-e653-4848-9239-28a4a46816f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
