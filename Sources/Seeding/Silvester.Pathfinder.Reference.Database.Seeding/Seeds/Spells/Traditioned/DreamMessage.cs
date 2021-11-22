using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DreamMessage : Template
    {
        public static readonly Guid ID = Guid.Parse("7d2dc84f-87d0-4a13-96c4-26833523439a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dream Message",
                Level = 3,
                CastTime = "10 minutes",
                Range = "Planetary.",
                Duration = "1 day.",
                Targets = "1 creature you know by name and have met in person.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14679c7d-85dc-480a-9f9f-c2287ea952e9"), Type = TextBlockType.Text, Text = "You send a message to your target's dream. The message is one-way, up to 1 minute of speech (roughly 150 words). If the target is asleep, they receive the message instantly. If not, they receive it the next time they sleep. As soon as they receive it, the spell ends, and you know the message was sent." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a84d5575-451c-4e9f-9be5-1696022abebe"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("af308c75-804d-41b6-80dd-6d84b9df767f"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures you know by name and have met in person. You must send the same message to all of them; the spell ends for each creature individually." }
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
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f683f542-4469-45ef-b299-14ffdb3b1f04"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 333
            };
        }
    }
}
