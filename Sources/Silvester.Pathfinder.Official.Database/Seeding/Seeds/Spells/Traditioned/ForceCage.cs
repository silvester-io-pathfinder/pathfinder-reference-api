using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ForceCage : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Force Cage",
                Level = 7,
                Range = "30 feet.",
                Area = "1 cube 20 feet on each side.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You create an immobile, invisible prison of sheer force. The cage is a 20-foot cube made of bands of force, each a half inch thick and a half inch apart, that extend to the Ethereal Plane. Each creature in the area where you create the cage must attempt a Reflex save. If such a creature fails, it becomes trapped inside the cage. If it succeeds, it’s pushed outside the cage into a space of its choice. If a creature in the area is too big to fit inside the prison, the spell automatically fails." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The cage has AC 10, Hardness 20, and 40 Hit Points, and it’s immune to critical hits and precision damage. A creature capable of passing through the space between the bars (typically a Tiny creature) can leave; all others are confined within. Attacks with a weapon too large to fit between the bars can’t pass through the cage, and the bars provide standard cover even against attacks that can pass through the gaps. Spells and breath weapons can pass through the cage uninhibited." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Force cage is immune to counteracting effects of its level or lower, but it is automatically destroyed by a disintegrate spell of any level, or by contact with a rod of cancellation (page 262) or sphere of annihilation (Gamemastery Guide 113)." };
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 219
            };
        }
    }
}
