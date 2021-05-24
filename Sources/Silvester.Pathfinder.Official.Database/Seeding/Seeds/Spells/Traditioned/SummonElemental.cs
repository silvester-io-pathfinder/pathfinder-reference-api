using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonElemental : Template
    {
        public static readonly Guid ID = Guid.Parse("acdb05b9-cd32-4ffd-8b7e-d13a8ade61b1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Elemental",
                Level = 2,
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
            yield return new TextBlock { Id = Guid.Parse("5dbae9c5-5c9c-408c-92cf-b52631191467"), Type = TextBlockType.Text, Text = "You conjure an elemental to fight for you. You summon a common creature that has the elemental trait and whose level is –1, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {

            yield return new SpellHeightening
            {
                Id = Guid.Parse("b3f41378-75c8-40e5-b41e-857757234fb1"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("63fcebb8-575f-411a-b9ff-61944537db50"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("0404c317-d872-4b1b-99d9-d9411eee4f3b"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8298e422-0c88-4eb8-9ffe-db89d69a2a76"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("3936b8b5-7618-4611-bc39-febb80f7ba47"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("42de4222-62d5-4849-8ae4-91aa27f2b5dd"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("346b8c18-22f8-49ec-b852-c4ad8a1d3f34"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7cea6daa-e22b-4e43-a516-c19bb42b943f"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("512d3db7-59b6-4ebd-b892-9f1fb4cd59f4"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("dce61a22-f5e4-497e-81cf-7d111b4e91ee"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4d2606db-68cd-4cda-9da6-a86ab1f64eb7"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7c49b2d2-f744-4ffe-8313-649970960894"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("e68edb29-810e-4f38-b3f5-ba55ef9e38d4"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e2da1a87-7aac-4b06-bda7-bfdfb01b9098"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("b0f6e636-946d-4f15-8938-98c45d17a97f"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9b2ee960-1a64-4647-98cc-0b480be37644"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("20476cdd-5b00-4fe4-8023-b3ff9ab464ff"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0ace57e8-1191-4187-a253-0fbc38ac6d6f"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e61688a3-ff1f-4b7a-af04-e9b47eb14039"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
