using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GlyphOfWarding : Template
    {
        public static readonly Guid ID = Guid.Parse("dd917eeb-693d-4b5c-95b8-15d653318eb5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Glyph of Warding",
                Level = 3,
                CastTime = "10 minutes.",
                Range = "Touch.",
                IsDismissable = true,
                Duration = "Unlimitied.",
                Targets = "1 container or a 10-foot-by-10-foot area.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8da739e3-7e84-4501-8678-fc6ce384da1b"), Type = TextBlockType.Text, Text = "You craft a trap by binding a hostile spell into a symbol. While Casting this Spell, you also Cast a Spell of a lower spell level to store in the glyph. The stored spell must take 3 actions or fewer to cast, have a hostile effect, and target one creature or have an area. You can set a password, a trigger, or both for the glyph. Any creature that moves, opens, or touches the target container or enters the target area that doesn’t speak the password or that matches the trigger activates the glyph, releasing the harmful spell within." };
            yield return new TextBlock { Id = Guid.Parse("8d18abf7-e3eb-4827-aac3-695a98063233"), Type = TextBlockType.Text, Text = "Once a spell is stored in the glyph, the glyph gains all thetraits of that spell. If the stored spell targets one or more creatures, it targets the creature that set off the glyph. If it has an area, that area is centered on the creature that set off the glyph. Glyph of warding’s duration ends when the glyph is triggered. The glyph counts as a magical trap, using your spell DC for both the Perception check to notice it and the Thievery check to disable it; both checks require the creature attempting them to be trained in order to succeed." };
            yield return new TextBlock { Id = Guid.Parse("6fae1a53-67c2-4ce0-b994-4103e9766305"), Type = TextBlockType.Text, Text = "You can Dismiss glyph of warding. The maximum number of glyphs of warding you can have active at a time is equal to your spellcasting ability modifier." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95a6e964-45be-4788-bf1b-3e75b203329d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 341
            };
        }
    }
}
