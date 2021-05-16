using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DuplicateFoe : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Duplicate Foe",
                Level = 7,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You try to create a temporary duplicate of an enemy to fight on your behalf. The target can attempt a Fortitude save to disrupt the spell. The duplicate appears in an unoccupied space adjacent to the target and has the target’s attack modifier, AC, saving throw modifiers, Perception, and skill modifiers, but it has only 70 Hit Points and lacks the target’s special abilities, including immunities, resistances, and weaknesses. It has no magic items except weapon potency runes." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The duplicate gains the minion trait, and it can only Stride and Strike. Its Strikes deal the target’s normal damage but don’t apply added effects, since it doesn’t have special abilities. The spell automatically ends if the duplicate’s Hit Points drop to 0." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The duplicate attacks your enemies to the best of its abilities. You can also try to give it additional instructions; when you Sustain the Spell, you can also Command a Minion as part of your action, but the GM determines whether the duplicate follows your command." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The duplicate is unstable, so each turn after it takes its actions, it loses 4d6 Hit Points. It’s not a living creature, and it can never regain its lost Hit Points in any way." };
        }

        public override IEnumerable<SpellTrigger> GetTriggers()
        {
            yield return new SpellTrigger
            {
                Id = Guid.Parse(""),
                Text = "1 enemy of level 15 or lower.",
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The level of creature you can target increases by 2. The duplicate has 10 more HP." }
                }
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "You fail to create a duplicate.",
                Success = "The duplicate deals half damage with its Strikes and the duration is reduced to a maximum of 2 rounds.",
                Failure = "The duplicate works as described."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 334
            };
        }
    }
}
