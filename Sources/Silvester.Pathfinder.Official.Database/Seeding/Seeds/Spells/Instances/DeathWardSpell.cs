using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DeathWardSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("3c902d87-38ff-4aad-acb3-266811986252"),
                Name = "Death Ward",
                Level = 5,
                Range = 0,
                Targets = "1 living creature touched.",
                Duration = "10 minutes."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f42c2728-6212-4aea-a67f-0c87c746330a"), Type = Utilities.Text.TextBlockType.Text, Text = "You shield a creature from the ravages of negative energy. It receives a +4 status bonus to saves against death and negative effects, gains negative resistance 10, and suppresses the effects of the doomed condition." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Occult";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Abjuration";
        }
    }
}
