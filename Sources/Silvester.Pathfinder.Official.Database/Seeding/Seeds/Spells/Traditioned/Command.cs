using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Command : Template
    {
        public static readonly Guid ID = Guid.Parse("4d709d69-ddde-487c-94a3-c876b4e79969");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Command",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "Until the end of the target’s next turn.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eecbd562-747c-437b-8fb7-ede447f95cb2"), Type = Utilities.Text.TextBlockType.Text, Text = "You shout a command that’s hard to ignore. You can command the target to approach you, run away (as if it had the fleeing condition), release what it’s holding, drop prone, or stand in place. It can’t Delay or take any reactions until it has obeyed your command. The effects depend on the target’s Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect 
            { 
                Id = Guid.Parse("45c9b2e8-2604-494e-a500-7f16a680eb4c"),
                Success = "The creature is unaffected.",
                Failure = "For the first action on its next turn, the creature must use a single action to do as you command.",
                CriticalFailure = "The target must use all its actions on its next turn to obey your command."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("dae11cb9-b62c-4073-827c-635821ed5e74"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("baf914d7-0d96-40cb-aac0-fe72bbb3fb37"), Type = Utilities.Text.TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d158bb99-ad4a-4ca3-b25e-e176232c458d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 325
            };
        }
    }
}
