using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonPlantOrFungus : Template
    {
        public static readonly Guid ID = Guid.Parse("a170f0db-8755-4bdb-a119-34d2cc09457b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Plant or Fungus",
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
            yield return new TextBlock { Id = Guid.Parse("3da28ebe-7867-4576-bc29-ea331ba187b0"), Type = TextBlockType.Text, Text = "You conjure an plant or fungus to fight for you. You summon a common creature that has the plant or fungus trait and whose level is –1, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e039865e-4470-46ed-b68e-abafff1df5be"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("47d1ede9-ebd5-4ce6-8b06-a6a54f7d8686"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("feeba8b7-539c-47cd-a60b-9ba1b5ec900a"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ea51f560-a1ee-4ed3-91f7-a99a0440c2f3"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f260d1ac-e047-4292-ad49-606fefba2ab4"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("184cc323-e40d-4d52-a0e4-22fbbcd448ec"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("085d989e-c0c5-4e15-87fa-dd79b480c49a"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2a73f434-9cf9-47de-917b-f39690e3f944"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("683cbfbd-5ce1-4b41-abc1-6ab730f3d282"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d9690950-7787-4255-a59a-252848491f4c"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("d176ea73-f518-4122-bf91-fc1382072b1e"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fa5d6d9e-a631-4f6c-8592-303f5dccbae1"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f4fa664e-f0f4-49ac-8d10-e3797a7da336"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6bfe7215-0665-4eb5-b840-6293bdedd194"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9a55219f-302f-4a24-aaef-34d6aa0cc6f0"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("91338dee-57d4-49a5-a38b-faa8d1d928a2"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("084b4903-7135-42c5-a2ad-6a640e2c6c80"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0e15ddb3-3af4-4fc5-adcf-5ce8f7109b71"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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
                Id = Guid.Parse("04c89bd2-2fa2-4818-b083-566f0ec0390c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
