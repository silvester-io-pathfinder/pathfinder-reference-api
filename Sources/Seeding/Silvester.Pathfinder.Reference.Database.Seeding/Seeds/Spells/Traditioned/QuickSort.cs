using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class QuickSort : Template
    {
        public static readonly Guid ID = Guid.Parse("3fff591f-f87d-48d7-9ddf-1f1d295d41fe");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Quick Sort",
                Level = 1,
                Range = "10 feet.",
                Duration = "Up to 1 minute.",
                Targets = "Up to 200 unattended objects in range, each of light bulk or less.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4695f683-1d99-4f5e-aba5-7b3bcee98aea"), Type = TextBlockType.Text, Text = "You magically sort a group of objects into neat stacks or piles. You can sort the objects in two different ways. The first option is to separate them into different piles depending on an easily observed factor, such as color or shape. Alternatively, you can sort the objects into ordered stacks depending on a clearly indicated notation, such as a page number, title, or date. The objects sort themselves throughout the duration, though it takes less time per object to sort a smaller number of objects, down to a single round for 30 or fewer objects." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("eaf6fea0-d96f-4fd3-b9cf-cc1f425bac2e"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8993cd9e-3865-49d1-a5e0-a4d878728134"), Type = TextBlockType.Text, Text = "The spell can sort up to 400 objects in a minute, or 60 objects in a round." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4bcbf7ca-08cf-4a14-bd6e-0e8b20e90179"),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("6c9ec2b6-6b7e-4292-9a07-be2f56058d4e"), Type = TextBlockType.Text, Text = "The spell can sort up to 800 objects in a minute, or 120 objects in a round." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67b33595-b082-4706-9fde-561a2dc11593"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 124
            };
        }
    }
}
