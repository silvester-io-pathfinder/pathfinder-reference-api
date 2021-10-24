using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SafeguardSecret : Template
    {
        public static readonly Guid ID = Guid.Parse("95ee850b-bf3d-47ec-8228-94467052a6df");

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
            yield return new TextBlock { Id = Guid.Parse("f6d5f3a6-ce11-40dd-8e1c-c3f59aadf640"), Type = TextBlockType.Text, Text = "You ensure a secret remains safe from prying spies. Choose one piece of information that at least some of the targets know; you can target a creature only if it remains within range for the full minute during which you Cast the Spell. The spell grants those who know the piece of knowledge you have chosen a +4 status bonus to skill checks (typically Deception checks) to conceal this knowledge and to saving throws against spells that specifically attempt to obtain this knowledge from them and effects that would force them to reveal it." };
            yield return new TextBlock { Id = Guid.Parse("bf1d8655-86f5-40ab-a083-9c5ee2f10210"), Type = TextBlockType.Text, Text = "If you Cast this Spell again, any previous safeguard secret you had cast ends." };
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
                Id = Guid.Parse("0e022650-a3f7-49f1-b1d3-0216bbbe5d5c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
