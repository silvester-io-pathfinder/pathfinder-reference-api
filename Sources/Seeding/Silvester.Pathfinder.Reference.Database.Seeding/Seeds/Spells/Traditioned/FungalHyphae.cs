using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FungalHyphae : Template
    {
        public static readonly Guid ID = Guid.Parse("59b13a12-657a-4098-bac2-2afcafa298d7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fungal Hyphae",
                Level = 2,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b5aed6c-a551-41cb-a92c-94c4f46c0123"), Type = TextBlockType.Text, Text = "Thin hyphae grow from your feet and plunge into the earth, creating a symbiotic fungal network that attaches to plants within 30 feet and connects you to their root systems. You gain an imprecise tremorsense allowing you to sense anything directly touching plants within that distance. If you move, the hyphae snap and the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("50fd23fe-786d-45c1-a6ef-3694dc6915a3"),
                Level = "4th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("70945cb5-09cd-46ed-931c-2eb90520f1ae"), Type = TextBlockType.Text, Text = "You can control plants in the area to a small degree, allowing you to make Strikes with tree branches, exposed roots, or similarly solid plants. To do so, you use a Strike action, but you can Strike any creature you can detect with your tremorsense. These are melee spell attacks that deal 2d8 bludgeoning damage plus your spellcasting ability modifier. Unusual plants, such as thorny vines, might deal a different type of damage at the GM�s discretion. You can�t make any other attacks through these plants, or take any other actions through them, other than these Strikes." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("06140dbb-78fa-4adb-a21a-813f544e5d4c"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("9a7acf47-fd7f-46c2-900a-295bb6a94aae"), Type = TextBlockType.Text, Text = "As 4th level, but you can use other simple manipulate actions through the plants, including having a branch pick an object up or open a door, though more complex actions, such as picking a lock or disabling a trap, remain impossible." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Fungus.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff23b9a9-ea88-4ea3-9865-a3de48042afb"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 108
            };
        }
    }
}
