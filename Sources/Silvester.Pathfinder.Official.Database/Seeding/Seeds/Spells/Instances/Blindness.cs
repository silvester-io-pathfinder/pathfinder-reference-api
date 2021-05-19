using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Blindness : Template
    {
        public static readonly Guid ID = Guid.Parse("3a320d74-73e9-40ab-a972-eb6b571f21fd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blindness",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd9e4d1c-d272-4b15-9eac-77518d6af7ab"), Type = Utilities.Text.TextBlockType.Text, Text = "You blind the target. The effect is determined by the target’s Fortitude save. The target then becomes temporarily immune for 1 minute." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            { 
                Id = Guid.Parse("2130dd1b-4239-4b15-9565-f962a6bf3cee"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is blinded until its next turn begins.",
                Failure = "The target is blinded for 1 minute.",
                CriticalFailure = "The target is blinded permanently."
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 321
            };
        }
    }
}
