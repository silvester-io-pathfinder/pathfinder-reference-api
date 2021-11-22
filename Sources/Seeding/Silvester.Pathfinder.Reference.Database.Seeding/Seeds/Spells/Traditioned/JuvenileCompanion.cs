using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class JuvenileCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("3325b77a-ebe0-4912-89d3-edbe49505194");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Juvenile Companion",
                Level = 1,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "Your companion.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81cd19cb-53e3-4d08-a444-d4e34dd5ec8b"), Type = TextBlockType.Text, Text = "You transform your companion into its juvenile form, such as a cub, foal, kitten, puppy, or piglet, making the target appear harmless. It becomes Tiny (if it was larger), and its reach is reduced to 0 feet. All of its Speeds are halved (to a minimum Speed of 5 feet), and it gains weakness 5 to physical damage. In all other ways, its abilities and statistics are unchanged." };
            yield return new TextBlock { Id = Guid.Parse("ce004153-6001-4493-969f-246144328f71"), Type = TextBlockType.Text, Text = "If your companion uses a hostile action, juvenile companion ends. This spell has no effect on a companion that doesn�t have a juvenile form." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fe94b356-1118-45d0-aeb4-40c590df2660"),
                Level = "2nd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b423c395-1a0c-44a7-b5d8-53bda857c08a"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47cf2e56-ddef-438f-8ac7-a8b2f02082e1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 113
            };
        }
    }
}
