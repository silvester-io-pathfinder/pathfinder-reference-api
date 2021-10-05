using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StinkingCloud : Template
    {
        public static readonly Guid ID = Guid.Parse("f460a7f0-7171-4fcd-973f-1a96b47d00ef");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stinking Cloud",
                Level = 3,
                Range = "120 feet.",
                Area = "20-foot burst.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4d51a2e-2242-4461-9521-16ace2bd7885"), Type = TextBlockType.Text, Text = "You create a cloud of putrid mist in the area. The cloud functions as obscuring mist (page 355) except it sickens creatures that end their turns within the cloud. (The concealed condition is not a poison effect.)" };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("7c2163bf-b443-460f-a0ee-9fbdd2c1e08e"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is sickened 1.",
                Failure = "The creature is sickened 1 and slowed 1 while in the cloud.",
                CriticalFailure = "The creature is sickened 2 and slowed 1 until it leaves the cloud."
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
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d73adf4e-1c6b-4724-9085-1693fddd82c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 373
            };
        }
    }
}
