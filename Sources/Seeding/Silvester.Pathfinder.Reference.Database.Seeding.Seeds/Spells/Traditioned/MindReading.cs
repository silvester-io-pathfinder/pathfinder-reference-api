using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MindReading : Template
    {
        public static readonly Guid ID = Guid.Parse("92db312e-0dc1-4fa8-badb-8e5ab99951f4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mind Reading",
                Level = 3,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "1 round or sustained up to 1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11d3185c-3f56-4d66-b6dc-22a8b35ac810"), Type = TextBlockType.Text, Text = "With a cursory mental touch, you attempt to read the target's mind. It must attempt a Will save. The target then becomes temporarily immune to your mind reading for 1 hour." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("9747a77f-9379-49ef-b1ca-6f88ef931879"),
                CriticalSuccess = "The target perceives vague surface thoughts from you when you Cast the Spell.",
                Success = "You find out whether the target's Intelligence modifier is higher than, equal to, or lower than yours.",
                Failure = "You perceive vague surface thoughts from the target when you Cast the Spell, and you find out whether its Intelligence modifier is higher than, equal to, or lower than yours.",
                CriticalFailure = "As failure, and for the duration of the spell, you can Sustain the Spell to detect the target's surface thoughts again. The target doesn't receive any additional saves."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("5165af0d-2b9a-488d-9e3b-65e176317c14"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("41500e8a-ace5-447c-9615-317e5a55a584"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("aea86906-344b-4da3-87dc-3acdbdb479b7"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("d5cc59de-36e4-4e3c-b7d2-cd1d7a177c34"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03e1ea45-e2c7-4070-9417-5e7066022c62"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 351
            };
        }
    }
}
