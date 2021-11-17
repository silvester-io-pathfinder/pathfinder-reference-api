using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShiftBlame : Template
    {
        public static readonly Guid ID = Guid.Parse("2d2783b9-f9a3-45a2-bc73-346caac5b325");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shift Blame",
                Level = 3,
                Range = "30 feet.",
                Targets = "The target of the triggering attack or skill check",
                Trigger = "You or another creature attacks a creature or fails at a Deception, Diplomacy, or Intimidation check.",
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ab82e72-c6b9-4a9c-b486-ba15d4947a84"), Type = TextBlockType.Text, Text = "You alter the target's memories of the triggering event as they form. You choose another creature (which can be you) with the capacity to make the triggering attack or skill check, and you alter the target's memories to recall the creature you chose as responsible for the triggering attack or skill check. The target must attempt a Will save and is then temporarily immune for 24 hours." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f56aee2f-61d6-45ce-97f4-a319eccf4e8a"),
                CriticalSuccess = "The target knows you attempted to alter its memories.",
                Success = "The target doesn't realize you attempted to alter its memories, though it knows you cast a spell.",
                Failure = "You successfully alter the target's memory. It isn't forced to react to the new memories in a particular way, and it's likely to question them if they contradict other information it knows or are implausible for the situation."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33f0d8e4-200b-4b2c-a9cd-eef0f13a1b33"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 129
            };
        }
    }
}
