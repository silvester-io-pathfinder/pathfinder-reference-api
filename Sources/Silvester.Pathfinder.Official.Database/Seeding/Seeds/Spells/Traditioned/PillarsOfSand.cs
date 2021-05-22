using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PillarsOfSand : Template
    {
        public static readonly Guid ID = Guid.Parse("dbaf20d0-6fad-43a7-8379-62c32c7049ac");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pillars of Sand",
                Level = 5,
                Range = "120 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("300c2b4b-df87-445c-8e8d-9b802ff98616"), Type = TextBlockType.Text, Text = "You raise one or more pillars of solid sand from the earth. The total height of the pillars is 30 feet, which must be used in 10-foot increments (for example, you could create three 10-foot-tall pillars, one 20-foot-tall pillar and one 10-foot-tall pillar, or one 30-foot-tall pillar). Each pillar is 5 feet by 5 feet in length and width. The pillars must be conjured on a relatively flat area of natural earthen terrain such as sand, dirt, stone, or clay. Regardless of the terrain, the pillars are always made of tightly compacted sand particles that together become as hard and solid as stone (DC 15 Athletics to Climb)." };
            yield return new TextBlock { Id = Guid.Parse("ca6c4874-383f-42c0-957e-3309fa2078eb"), Type = TextBlockType.Text, Text = "If a creature occupies the space where you cast this spell, it is carried upward atop the pillar. The creature can attempt a Reflex save (DC equal to the caster's spell DC); on a success, the creature can either attempt to Grab an Edge or move into an adjacent unoccupied square. If the pillar would rise higher than the ceiling, it firmly abuts the ceiling but does not rise any higher. A creature caught between a pillar and a ceiling takes no damage (subject to GM discretion, such as is in the case of stalactites or other hazards) but becomes immobilized. The creature can attempt an Escape check to free itself, but it must thereafter Grab an Edge, Climb down, or fall from the top of the pillar. The Grab an Edge and Escape DCs are the same as the Reflex save." };
            yield return new TextBlock { Id = Guid.Parse("d2829321-35fc-46bf-a376-35f026ac41f3"), Type = TextBlockType.Text, Text = "As part of your action to Sustain the Spell, you can choose to either destroy one of your pillars, causing it to immediately crumble into nothing, or create a new pillar, as long as doing so wouldn't exceed the total number of feet of pillar you can create. You can Sustain the Spell two or more times on a single turn to destroy or create a pillar." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f6a87913-3760-4d6c-8f32-099acdef3c39"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("a85689aa-d04a-4f31-bcfb-488a3a5a66e7"), Type = TextBlockType.Text, Text = " The total height of the pillars increases by 10 feet, but must still be used in 10-foot increments (this also increases the total number of pillars that can be created by one)." }
                }
            };
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Earth.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21d2e373-1685-4bc5-901d-3c846b433cec"),
                SourceId = Sources.Instances.Pathfinder155.ID,
                Page = 74
            };
        }
    }
}
