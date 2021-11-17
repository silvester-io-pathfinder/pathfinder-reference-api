using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Soothe : Template
    {
        public static readonly Guid ID = Guid.Parse("9a8d198a-8bd7-49bf-93f0-452564f9540a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Soothe",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 willing living creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af924638-0cce-4fbd-b764-eb4e4de6a0aa"), Type = TextBlockType.Text, Text = "You grace the target’s mind, boosting its mental defenses and healing its wounds. The target regains 1d10+4 Hit Points when you Cast the Spell and gains a +2 status bonus to saves against mental effects for the duration." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("38450531-0874-4fc7-a48a-912ce97f399a"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b387136d-55f5-4e9f-940b-67ec0a1e94b2"), Type = TextBlockType.Text, Text = "The amount of healing increases by 1d10+4." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f3ffc6b-d22d-4bce-b100-8d17316bd4dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
