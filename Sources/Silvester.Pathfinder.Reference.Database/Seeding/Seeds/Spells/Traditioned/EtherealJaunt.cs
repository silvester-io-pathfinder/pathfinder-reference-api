using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EtherealJaunt : Template
    {
        public static readonly Guid ID = Guid.Parse("f91f37ef-2139-4dc1-9827-512f7f7b4907");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ethereal Jaunt",
                Level = 7,
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b527f78c-c4c7-4626-9262-1b360dfbfc39"), Type = TextBlockType.Text, Text = "You travel to the Ethereal Plane, which overlaps the Material Plane. Material Plane creatures can’t see you, and you can move through things on the Material Plane. You move at half your normal Speeds, but can move in any direction (including up and down). You can see onto the Material Plane within a radius of 60 feet; it is gray, hazy, and concealed from you. You can’t affect the Material Plane, and you can’t be affected by the Material Plane except by force effects and abjurations originating there." };
            yield return new TextBlock { Id = Guid.Parse("2ecd12cd-65a0-4450-91b3-e1af6da7308b"), Type = TextBlockType.Text, Text = "When the spell ends, you return to the Material Plane. If you’re in the air, you fall (unless you can fly), and if you’re inside an object, you’re pushed into the nearest open space and take 1d6 damage per 5 feet you were pushed." };
            yield return new TextBlock { Id = Guid.Parse("579747e9-a052-4a85-b39a-52146ccc554f"), Type = TextBlockType.Text, Text = "If you cast this spell when not on the Material Plane, it is lost." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("98879b58-5c45-47bb-a0e9-eb1f0684488a"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a6c03317-43aa-45c1-9c46-fcb9ef84ddad"), Type = TextBlockType.Text, Text = "You can target up to five additional willing creatures within 30 feet. The duration is up to 10 minutes." }
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
                Id = Guid.Parse("15c69c93-6e98-4a44-a5b2-a7c07a35b8c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 336
            };
        }
    }
}
