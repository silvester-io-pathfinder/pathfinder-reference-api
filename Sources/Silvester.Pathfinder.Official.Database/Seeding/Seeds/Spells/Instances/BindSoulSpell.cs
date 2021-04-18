using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BindSoulSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("a0dc825d-78c6-4464-a62e-17d7001c258e"),
                Name = "Bind Soul",
                Level = 2,
                Range = 30,
                Targets = "1 creature that died within the last minute."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc567753-dd14-46d2-969e-2fb187ae0fbb"), Type = Utilities.Text.TextBlockType.Text, Text = "You wrench the target’s soul away before it can pass on to the afterlife and imprison it in a black sapphire." };
            yield return new TextBlock { Id = Guid.Parse("53346ab9-5ab3-45e8-8692-1d8f9b1249e0"), Type = Utilities.Text.TextBlockType.Text, Text = "While the soul is in the gem, the target can’t be returned to life through any means, even powerful magic such as wish. If the gem is destroyed or bind soul is counteracted on the gem, the soul is freed. The gem has AC 16 and Hardness 10. A gem can’t hold more than one soul, and any attempt wastes the spell." };
        }

        public override IEnumerable<SpellRequirement> GetRequirements()
        {
            yield return new SpellRequirement { Id = Guid.Parse("5ece9a7b-d3b6-4cd5-bbf9-c5657ec5cd7f"), Text = "Black Sapphire with a gp value of at least the target's level x100." };
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
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "Evil";
            yield return "Necromancy";
        }
    }
}
