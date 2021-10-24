using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagicMouth : Template
    {
        public static readonly Guid ID = Guid.Parse("6b8f348c-88e8-41bc-8336-9098fa0854c6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magic Mouth",
                Level = 2,
                Range = "Touch.",
                IsDismissable = true,
                Duration = "Unlimited.",
                Targets = "1 creature or object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87047c4a-edbe-4dec-9a3c-c73a68337680"), Type = TextBlockType.Text, Text = "You specify a trigger (described on page 305) and a message up to 25 words long. When the specified trigger occurs within 30 feet of the target, an illusory mouth appears on the target and speaks the message, and the magic mouth spell ends." };
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
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5792ca4a-1880-457f-8aad-5d083634a071"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 349
            };
        }
    }
}
