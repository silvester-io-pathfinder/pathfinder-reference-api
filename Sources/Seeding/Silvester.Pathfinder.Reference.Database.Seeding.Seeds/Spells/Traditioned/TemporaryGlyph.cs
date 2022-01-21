using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TemporaryGlyph : Template
    {
        public static readonly Guid ID = Guid.Parse("dba46ba0-e885-4226-8c07-4b77722df9fb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Temporary Glyph",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 minute.",
                Area = "5-foot sqaure.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5670ebe-a924-4a66-847c-2c359737c8dd"), Type = TextBlockType.Text, Text = "You temporarily bind a hostile spell into a symbol. While Casting this Spell, you also Cast a Spell of a lower spell level to store in the glyph. The stored spell must take 2 actions or fewer to Cast, have a hostile effect, and target one creature or have an area. Any creature that enters temporary glyph�s area activates the glyph, releasing the harmful spell within. You can set a password for the glyph. Speaking it when entering the spell�s area prevents the glyph from triggering. You can also set a more specific trigger to limit which types of creatures set off the glyph (Core Rulebook 305)." };
            yield return new TextBlock { Id = Guid.Parse("ae09659e-b0c7-439f-8228-00215ebc0e1b"), Type = TextBlockType.Text, Text = "Once a spell is stored in the glyph, the glyph gains all the traits of that spell. If the stored spell can target one or more creatures, it targets the creature that set off the glyph. If it has an area, that area is centered on the creature that set off the glyph. Temporary glyph�s duration ends when the glyph is triggered. The glyph is a magical trap, using your spell DC for both the Perception check to notice it and the Thievery check to disable it; both checks require the creature attempting them to be trained in order to succeed." };
            yield return new TextBlock { Id = Guid.Parse("6bd80a59-95de-4647-9f4d-fa76d1a067e3"), Type = TextBlockType.Text, Text = "You can Dismiss temporary glyph." };
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
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("25ad8f7b-1111-429f-b4dc-55ce4fdf3f13"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a09edf6b-a12a-4f85-bf77-d3eaaa50ef2a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 136
            };
        }
    }
}
