using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class EtherealJaunt : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ethereal Jaunt",
                Level = 7,
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You travel to the Ethereal Plane, which overlaps the Material Plane. Material Plane creatures can’t see you, and you can move through things on the Material Plane. You move at half your normal Speeds, but can move in any direction (including up and down). You can see onto the Material Plane within a radius of 60 feet; it is gray, hazy, and concealed from you. You can’t affect the Material Plane, and you can’t be affected by the Material Plane except by force effects and abjurations originating there." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When the spell ends, you return to the Material Plane. If you’re in the air, you fall (unless you can fly), and if you’re inside an object, you’re pushed into the nearest open space and take 1d6 damage per 5 feet you were pushed." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you cast this spell when not on the Material Plane, it is lost." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can target up to five additional willing creatures within 30 feet. The duration is up to 10 minutes." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 336
            };
        }
    }
}
