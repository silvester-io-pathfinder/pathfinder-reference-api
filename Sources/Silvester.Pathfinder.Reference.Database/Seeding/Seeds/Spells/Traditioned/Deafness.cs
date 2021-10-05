using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Deafness : Template
    {
        public static readonly Guid ID = Guid.Parse("509c9a55-433c-4f99-8a7a-609d38f23ed1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Deafness",
                Level = 2,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4957d652-3659-4c6f-b259-ea076a4a861b"), Type = Utilities.Text.TextBlockType.Text, Text = "The target loses hearing; it must attempt a Fortitude save. The target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect 
            {
                Id = Guid.Parse("fa67be43-2108-4e4d-ab58-18edad117031"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is deafened for 1 round.",
                Failure = "The target is deafened for 10 minutes.",
                CriticalFailure = "The target is deafened permanently."
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
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3630ac0-1b79-4db8-b963-9a1e2ef0494b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 327
            };
        }
    }
}
