using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Veil : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Veil",
                Level = 4,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "1 hour.",
                Targets = "Up to 10 creatures.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You disguise the targets as other creatures of the same body shape and roughly similar height (within 6 inches) and weight (within 50 pounds). The disguise can hide the targets’ identities or let them appear to be of another ancestry, but it’s not precise enough to impersonate specific individuals. The spell doesn’t change voice, scent, or mannerisms. You choose the disguise for each target; for example, you could make one target appear to be a dwarf and another an elf." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Casting veil counts as setting up a disguise for the purpose of the Impersonate action. It allows the target to ignore any circumstance penalties they might take for being disguised as dissimilar creatures, and it gives the targets a +4 status bonus to Deception checks to prevent others from seeing through their disguises, and add their level even if untrained. You can Dismiss any or all of these disguises." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The spell also disguises the targets’ voices and scents; it gains the auditory and olfactory traits." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The targets can appear as any creature of the same size, even specific individuals. You must have seen an individual to reproduce their appearance. The spell also disguises the targets’ voices and scents; it gains the auditory and olfactory traits." }
                }
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "",
                Success = "",
                Failure = "",
                CriticalFailure = ""
            };
        }

        protected override IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            yield return new StaggeredEffect
            {
                Id = Guid.Parse(""),
                DifficultyCheck = ,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "",
                Onset = "",
                Level = 9,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse(""), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Drained.ID, Severity = 1}
                        }
                    }
                }
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "",
                ActionTypeId = ActionTypes.Instances..ID,
                Trigger = "",
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse (""), Type = TextBlockType.Text, Text = ""},
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Transmutation.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
