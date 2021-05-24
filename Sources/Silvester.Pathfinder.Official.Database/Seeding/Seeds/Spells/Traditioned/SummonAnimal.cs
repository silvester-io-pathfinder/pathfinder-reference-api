using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonAnimal : Template
    {
        public static readonly Guid ID = Guid.Parse("b010e111-5fcd-40c1-9271-3443906af0f5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Animal",
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
            yield return new TextBlock { Id = Guid.Parse("696556a2-d986-42a0-bb8d-8c530c52e0fc"), Type = TextBlockType.Text, Text = "You conjure an animal to fight for you. You summon a common creature that has the animal trait and whose level is –1, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9e0a3baf-2554-4e12-ad58-8d86eefdcef9"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5a713fac-49da-4516-b3a0-08a75f78c1b6"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a6016d02-df18-4bae-a552-6b0e95602bda"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("63cba8b4-22a3-448e-b4f5-ee200fa7a448"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a05947e9-d275-4c04-99b2-54b05e81b81c"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("09339ba8-c560-42e4-84bc-603d174d23eb"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("fdd8ad7d-eb75-4f4b-8590-24c983b95be4"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6a40d2f3-1f1b-4d87-8df4-c37094b1415b"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("c2239e78-befd-40e3-964b-c1cedde463b9"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("faf62a0f-559c-43e9-a437-797f66303072"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("fc87d472-a3ee-40bf-969e-785cb3a02538"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7a234207-1a8c-4bdb-9eca-c23693cbb056"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("98fe03ab-0297-4ee4-ab59-1739e3cca454"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("62e59916-3015-4d49-8a79-2a465a51d842"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("813b8b1b-6b3a-48d3-bc5d-08590c7ebf92"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8f3a7ba2-1a85-48a8-816d-feda6e768967"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("1a09be37-c5c1-44b7-9c0f-eab40ed7d5a4"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7cf098e2-bc7f-4542-815c-426ca63956da"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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
                Id = Guid.Parse("d8eba569-417e-4b94-a723-323d32bd69ac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
