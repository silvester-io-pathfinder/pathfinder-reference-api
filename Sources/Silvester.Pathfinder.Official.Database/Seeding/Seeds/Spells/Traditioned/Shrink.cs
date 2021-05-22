using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Shrink : Template
    {
        public static readonly Guid ID = Guid.Parse("b50bbfc8-6c9a-4398-ab83-eb5d525a90e8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shrink",
                Level = 2,
                Range = "30 feet.",
                Duration = "5 minutes.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54b56fa0-5746-4448-bdce-2851d8b351c2"), Type = TextBlockType.Text, Text = "You warp space to make a creature smaller. The target shrinks to become Tiny in size. Its equipment shrinks with it but returns to its original size if removed. The creature’s reach changes to 0 feet. This spell has no effect on a Tiny creature." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("911d220f-e11c-4f8d-895f-9be3bac2f5a5"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("de0b0249-a3ce-441f-9c4e-d85e1322903f"), Type = TextBlockType.Text, Text = "The spell can target up to 10 creatures." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
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
                Id = Guid.Parse("0b6eaf21-6f1a-4cde-9304-e9d7d27e055b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 369
            };
        }
    }
}
