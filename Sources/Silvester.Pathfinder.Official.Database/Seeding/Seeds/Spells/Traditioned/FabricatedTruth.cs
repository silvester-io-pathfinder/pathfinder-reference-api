using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FabricatedTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fabricated Truth",
                Level = 10,
                Range = "100 feet.",
                Duration = "Varies.",
                Targets = "Up to 5 creatures.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose a single statement you want the targets to believe. The fact could be narrow, such as “a dragon is circling overhead and wants to kill me”; wide-reaching, such as “all humanoids are disguised abominations”; or conceptual, such as “if I don’t live a kinder life, I’ll be punished in the afterlife.” The targets’ experiences color how they react to this “truth” and how their behavior changes. If the statement changes what they perceive, they treat the change as a sudden revelation." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The effect of the spell depends on the targets’ Will saves. If a target is already subject to fabricated truth, your spell tries to counteract it. If the counteract check fails, the outcome of the target’s saving throw can’t be worse than a success." };
        }

      
        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The target doesn’t believe the statement, and it knows you tried to trick it.",
                Success = "The target doesn’t believe the statement or realize you tried to trick it.",
                Failure = "The target believes the statement for a duration of 1 week.",
                CriticalFailure = "The target believes the statement with unlimited duration."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 336
            };
        }
    }
}
