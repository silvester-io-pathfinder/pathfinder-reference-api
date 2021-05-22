using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SafeguardSecret : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Safeguard Secret",
                Level = 4,
                Range = "10 feet.",
                Duration = "1 hour.",
                CastTime = "1 minute.",
                Targets = "You and any number of willing allies.",
                DomainId = Domains.Instances.Secrecy.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You ensure a secret remains safe from prying spies. Choose one piece of information that at least some of the targets know; you can target a creature only if it remains within range for the full minute during which you Cast the Spell. The spell grants those who know the piece of knowledge you have chosen a +4 status bonus to skill checks (typically Deception checks) to conceal this knowledge and to saving throws against spells that specifically attempt to obtain this knowledge from them and effects that would force them to reveal it." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you Cast this Spell again, any previous safeguard secret you had cast ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
