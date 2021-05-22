using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Shapechange : Template
    {
        public static readonly Guid ID = Guid.Parse("c0720771-9eed-4062-9465-abcb312cb589");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shapechange",
                Level = 9,
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b28ed13-3ec9-4a63-a850-027636a2af06"), Type = TextBlockType.Text, Text = "Harnessing your mastery of transformative magic, you take on a mutable form. You transform yourself into any form you could choose with a polymorph spell in your spell repertoire or that you could prepare of 8th level or lower (including any 8th-level or lower heightened versions of spells you know). You choose the type of creature as you Cast the Spell rather than when you prepare it. You can change your form to any other form you could choose with this spell by using a single action, which has the concentrate trait. You can Dismiss this spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1406906e-0237-45df-b5e1-97eacd66d081"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
