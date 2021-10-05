using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HypnoticPattern : Template
    {
        public static readonly Guid ID = Guid.Parse("b8e5314c-6a86-4dba-88ec-26ca65b8edb3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hypnotic Pattern",
                Level = 3,
                Range = "120 feet.",
                Area = "10-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07339e45-5280-4aad-b960-d15d5d01ac75"), Type = TextBlockType.Text, Text = "You create a pattern of shifting colors that hovers in the air in a geometric cloud. Creatures are dazzled while inside the pattern. In addition, a creature must attempt a Will saving throw if it is inside the pattern when you cast it, when it enters the pattern, when it ends its turn within the pattern, or if it uses a Seek or Interact action on the pattern. A creature currently fascinated by the pattern doesn’t attempt new saves." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2890e308-e217-42f9-8bdc-f4d51602e67a"),
                Success = "The target is unaffected.",
                Failure = "The target is fascinated by the pattern.",
                CriticalFailure = "The target is fascinated by the pattern. While it remains fascinated, it can’t use reactions."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abaee6ea-b7e7-4c14-9dba-feda78ba7a52"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
