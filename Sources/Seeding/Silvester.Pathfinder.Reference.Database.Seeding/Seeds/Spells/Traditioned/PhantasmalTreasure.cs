using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PhantasmalTreasure : Template
    {
        public static readonly Guid ID = Guid.Parse("e3c259f7-11a8-4b23-a512-29afd7cffe68");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phantasmal Treasure",
                Level = 2,
                Range = "60 feet.",
                Duration = "Varies.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1544f4b4-4eaa-47a6-a9df-6da4d945ab1b"), Type = TextBlockType.Text, Text = "A phantasmal image of the most precious thing imaginable to the target appears in a location of your choice within the spell's range. Only the spell's target can see the treasure, though you can see the vague shape of the treasure—be it a pile of items, a deific avatar, or a cherished loved one or hero. The target's response to the treasure is based on the outcome of the target's Will save." };
        }


        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("89882a94-d0eb-419a-911a-a1d1be27abdf"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target becomes fascinated with the treasure, and the duration is until the end of its turn. The target can also try to disbelieve the illusion if it touches the treasure, Seeks to examine it, or speaks to it if the illusion appears to be a person or the like. If the target disbelieves the illusion, the spell ends.",
                Failure = "As success, but the duration is 1 minute.",
                CriticalFailure = "As success, but the duration is 1 minute. The target finds the treasure so appealing that until the spell ends, it must spend each action focused on it. This can include moving toward the treasure if the target isn't next to it, and Interacting with the treasure if the target is next to it. (If the illusion appears to be a person or the like, the target can also Interact to converse with it.)"
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7d1e34d-8b48-42dc-ad94-0f8c229ae033"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 223
            };
        }
    }
}
