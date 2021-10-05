using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TelekineticHaul : Template
    {
        public static readonly Guid ID = Guid.Parse("3940186e-7fc4-4ee4-b88b-950aa185ce64");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Telekinetic Haul",
                Level = 5,
                Range = "120 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                Targets = "1 unattended object of up to 80 Bulk with no dimension longer than 20 feet.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("866afc06-8e16-48f8-9aa7-f4aef885b5e5"), Type = TextBlockType.Text, Text = "You move the target up to 20 feet, potentially suspending it in midair. When you Sustain the Spell, you can do so again, or you can choose a different eligible target to move." };
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
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e528698e-7bfa-495a-b66c-65285c5d0ad1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
