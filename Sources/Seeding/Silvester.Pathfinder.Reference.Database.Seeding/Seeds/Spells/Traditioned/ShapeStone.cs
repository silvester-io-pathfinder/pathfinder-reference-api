using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShapeStone : Template
    {
        public static readonly Guid ID = Guid.Parse("49d1911d-7153-4a01-9e0e-cb89bb62d0ab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shape Stone",
                Level = 4,
                Range = "Touch.",
                Targets = "Cube of stone 10 feet across or smaller.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a701f81e-40bf-4db0-85c2-ffe6858045bb"), Type = TextBlockType.Text, Text = "You shape the stone into a rough shape of your choice. The shaping process is too crude to produce intricate parts, fine details, moving pieces, or the like. Any creatures standing atop the stone when you reshape it must each attempt a Reflex save or Acrobatics check. Success The creature is unaffected." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("dfb6b0ce-f6fb-4113-aaf8-6d04e3c0dd14"),
                Success = "The creature is unaffected.",
                Failure = "The creature falls prone atop the stone.",
                CriticalFailure = "The creature falls off the stone (if applicable) and lands prone."
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
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f788045-e72e-4858-87c4-58bcec29ce8c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
