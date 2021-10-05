using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Glitterdust : Template
    {
        public static readonly Guid ID = Guid.Parse("58aae6ec-5f9a-4e70-bc80-c1e40d093d62");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Glitterdust",
                Level = 2,
                Range = "120 feet.",
                Area = "10-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa8d4562-e838-4b9a-b604-86757bbb7f58"), Type = TextBlockType.Text, Text = "Creatures in the area are outlined by glittering dust. Each creature must attempt a Reflex save. If a creature has its invisibility negated by this spell, it is concealed instead of invisible. This applies both if the creature was already invisible and if it benefits from new invisibility effects before the end of the invisibility negation effect from this spell." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("77be37d5-c650-4476-a511-d3bacf4798c5"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target’s invisibility is negated for 2 rounds.",
                Failure = "The target is dazzled for 1 minute and its invisibility is negated for 1 minute.",
                CriticalFailure = "The target is blinded for 1 round and dazzled for 10 minutes.Its invisibility is negated for 10 minutes."
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
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b2de86d-be54-4a22-a358-8f577cf595ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 341
            };
        }
    }
}
