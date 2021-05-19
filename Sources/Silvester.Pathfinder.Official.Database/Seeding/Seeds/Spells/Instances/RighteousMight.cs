using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RighteousMight : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Righteous Might",
                Level = 6,
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<SpellRequirement> GetRequirements()
        {
            yield return new SpellRequirement
            {
                Id = Guid.Parse(""),
                Text = "You have a deity."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You focus all your divine energy and transform yourself into a Medium battle form, similar to your normal form but armed with powerful divine armaments granted by your deity. While in this form, you gain the statistics and abilities listed below. You have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "AC = 20 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "10 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Speed 40 feet." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Resistance 3 against physical damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "A special attack with a righteous armament version of your favored weapon, which is the only attack you can use. Your attack modifier with the special weapon is +21, and your damage bonus is +8 (or +6 for a ranged attack). If your attack modifier with your deity’s favored weapon is higher, you can use it instead. You deal three of your weapon’s normal damage dice, or three damage dice of one size larger if your weapon is a simple weapon with a d4 or d6 damage die. The weapon has one of the following properties that matches your deity’s alignment: anarchic, axiomatic, holy, unholy. If your deity is true neutral, you instead deal an extra 1d6 precision damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +23, unless your own modifier is higher." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your battle form is Large, and your attacks have 10-foot reach, or 15-foot reach if your deity’s favored weapon has reach. You must have enough space to expand into or the spell is lost. You instead gain AC = 21 + your level, 15 temporary HP, resistance 4 against physical damage, attack modifier +28, damage bonus +15 (+12 for a ranged attack), and Athletics +29." }
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
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 366
            };
        }
    }
}
