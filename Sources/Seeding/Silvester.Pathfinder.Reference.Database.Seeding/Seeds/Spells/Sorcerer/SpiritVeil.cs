using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritVeil : Template
    {
        public static readonly Guid ID = Guid.Parse("ea651e8d-ff1d-4b4b-93c1-8b0b429a5157");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spirit Veil",
                Level = 3,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef9423d2-c839-4814-b506-116eb6459bfe"), Type = TextBlockType.Text, Text = "You draw an occluding veil of spirits around yourself, blocking yourself especially well from undead eyes. You become concealed to all creatures, and you are hidden from undead creatures regardless of what precise senses they have; this grants the effects of invisibility, but against all the undead creature’s precise senses. If you physically interact with an undead creature or use a hostile action, the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bd4ae0af-7327-456a-950b-d63300430429"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8357214a-830d-4a88-9e7a-35c04020054a"), Type = TextBlockType.Text, Text = "You can target one additional willing creature within 30 feet. The spell ends if any target physically interacts with an undead creature or uses a hostile action." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1042ea32-c08d-49da-8c71-24fcf7fb8750"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
