using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PrismaticWall : Template
    {
        public static readonly Guid ID = Guid.Parse("18adb9ed-5e8b-4823-931b-170ae462ce05");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Prismatic Wall",
                Level = 8,
                Range = "120 feet.",
                IsDismissable = true,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7c2cd66-a2f0-4333-9a9c-2ae2992d0fc8"), Type = TextBlockType.Text, Text = "You create an opaque wall of shimmering, multicolored light. The wall is straight and vertical, stretching 60 feet long and 30 feet high. You must form the wall in an unbroken open space so its edges don’t pass through any creatures or objects, or the spell is lost. You can pass through the wall and ignore its effects. The wall sheds bright light out to 20 feet on each side (and dim light to the next 20 feet). Creatures other than you that come into the wall’s light must attempt a Will save; they’re dazzled for 1 round on a success, blinded for 1 round on a failure, and blinded for 1 minute on a critical failure. They are then temporarily immune to the blinding effect for 1 hour." };
            yield return new TextBlock { Id = Guid.Parse("d9fe499e-54bc-4b86-890e-eeb7784280c1"), Type = TextBlockType.Text, Text = "A prismatic wall has seven different layers, each a different color. Red, orange, yellow, and green have the effect of a 5th-level chromatic wall (page 323) spell of that color, and the others have the effect of a 7th-level chromatic wall spell of that color. A creature that tries to pass through the wall must attempt a saving throw against each component wall. The effects take place simultaneously, so a creature turned to stone by the blue wall is still treated as a creature for the indigo and violet walls." };
            yield return new TextBlock { Id = Guid.Parse("746c666e-1596-4a84-b309-7fbaefccd507"), Type = TextBlockType.Text, Text = "The wall as a whole is immune to counteracting effects of the wall’s level or lower; each color must be counteracted by its specific spell, as described in chromatic wall. This must be done in order (red, orange, yellow, green, blue, indigo, then violet). A given color can’t be affected until the previous color is counteracted. Counteracting a color wall removes that color’s effect from the wall, and counteracting them all ends prismatic wall. You can Dismiss the spell." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de1f6563-0dd8-4607-9b46-81c0a657f1c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 360
            };
        }
    }
}
