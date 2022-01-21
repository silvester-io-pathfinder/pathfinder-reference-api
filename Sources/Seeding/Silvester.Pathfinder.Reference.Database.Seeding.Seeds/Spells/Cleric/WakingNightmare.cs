using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WakingNightmare : Template
    {
        public static readonly Guid ID = Guid.Parse("5563c71a-59ae-42d3-8d5a-a6d70106135b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Waking Nightmare",
                Level = 1,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Nightmares.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be99c269-5795-40aa-b766-d1c271946226"), Type = TextBlockType.Text, Text = "You fill the creature's mind with a terrifying vision out of its nightmares. The target must attempt a Will save." };
            yield return new TextBlock { Id = Guid.Parse("5d0a6d19-7b6f-4623-aaea-cccccbcffb4a"), Type = TextBlockType.Text, Text = "If the target is unconscious when you Cast this Spell on it, it immediately wakes up before attempting its save, and if it fails its save, it gains the fleeing condition for 1 round in addition to the effects noted above." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("7fe9d37a-eb08-4599-b1b4-c8170c0d0f5a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is frightened 1.",
                Failure = "The target is frightened 2.",
                CriticalFailure = "The target is frightened 3."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("40be78f2-9aca-42c8-8b33-fb1d45070023"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("2e9c2fdf-bdc8-495d-a3f5-e39476091bee"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("09b2f359-e23f-4fd8-a8e8-ed732b98ae6a"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("dc38236f-d3c6-4270-90a8-0ffaa626c21e"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("69f2ff04-78f3-4141-9890-6f98adbc83f8"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("2003a4ef-b834-4791-9096-2a3551d93799"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2be648df-83ba-4d85-8bbe-97dc7e95fdc4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
