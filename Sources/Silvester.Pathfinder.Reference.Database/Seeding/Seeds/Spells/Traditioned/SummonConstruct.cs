using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonConstruct : Template
    {
        public static readonly Guid ID = Guid.Parse("0cf744a4-ce77-44f4-8dab-48679fa1ebea");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Construct",
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
            yield return new TextBlock { Id = Guid.Parse("304ef339-78c1-4448-8e98-f6a082763331"), Type = TextBlockType.Text, Text = "You conjure an construct to fight for you. You summon a common creature that has the construct trait and whose level is –1, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {

            yield return new SpellHeightening
            {
                Id = Guid.Parse("2384d1b3-1009-47b3-b849-17a1a4c6317f"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b53e62c8-28a0-4e6e-bfe5-87a098bb0daa"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("39a2bdef-b4fb-4a4a-a214-2bbea54853b5"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8b399daf-d12e-48a4-a0a7-f3690755d0bc"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("1e97babe-aa83-4ecd-b534-0b7cccba2cf7"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("60987031-fe88-4c10-9912-f56038073bc8"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("543d00e9-549c-4aac-9abf-10cb9a25148e"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3f72f3b5-6aa5-46c5-b44a-6d69a4d61a14"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("b9fe99a6-5174-4016-8d07-a6188a721369"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b89c0543-97da-4972-8a78-55582223922b"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("fdf1551c-5ba4-4a9a-84e1-8df4b6a0f52f"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("02b34bfe-1bca-450d-a9a7-02c00134080e"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("5eecbb9c-026c-4380-a72e-a84cc02cba48"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("29ff28c1-591b-4a9e-a8e5-48d8939a5c84"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("691c7ae0-466e-4ddb-b1ef-84c1d468fb18"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5c2653fe-cf8b-426b-b939-184042332b62"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("af1c0c62-80d5-422d-994a-19848c46412e"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("92e95bd3-8372-4ba4-81fa-612bd3e44911"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa0ebef6-10f7-4038-a64d-ddb1c58d9dbb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
