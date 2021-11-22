using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonFiend : Template
    {
        public static readonly Guid ID = Guid.Parse("e478263d-50fe-4e76-b926-417ce2e9395c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Fiend",
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
            yield return new TextBlock { Id = Guid.Parse("7890ba15-a712-4518-961c-f241c14adc47"), Type = TextBlockType.Text, Text = "You conjure a fiend to fight for you. You summon a common creature that has the fiend trait and whose level is 5 or lower, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon. You can't summon a creature unless its alignment is one of your deity's preferred alignments (or, if you don't have a deity, is within one step of your alignment). At the GM's discretion, some deities might restrict specific types of fiends, even if their alignments match." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("58fad594-05fe-43d9-8a59-2168463957c3"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("84c573b6-0fc0-4247-86e6-05382d9cad44"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a9364f8a-84d4-4a02-b7c6-c4e475c06911"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4355857b-93b4-4a53-8671-190a1004212e"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("0c602b01-0aa0-4fc7-84a7-a0914da31a4c"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b1c400d7-4b87-4472-ada7-14d2c0b6f009"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("3fb68fb3-cb5e-46f5-b248-3c64ff1c3002"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0aeeae82-5b19-46ad-b595-debc2279baa8"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("683fe91d-9f3b-4809-9e15-cf4e600c2250"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7ce88339-e753-4194-9e97-779c8932e37d"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("e3f62da9-7799-4b62-bb1d-d957137a1106"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b0f103f3-16dc-4fcc-b912-0aa12ef0478c"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("ebac9c75-0c9f-4414-97db-e0e2e120b5be"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("799ac35f-fc6f-44de-b551-817df03a3cfe"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("124b8abf-b520-4c96-8858-43fcfb9e7544"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b5255258-e433-474d-b0e1-c4c640a0bdbb"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("afdadbbd-7b63-40f6-b028-6eca89e361eb"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("42e7a4b8-4a12-46a0-8626-4f13b93cafdc"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4be75634-256c-4435-963c-6da5fe69c964"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
