using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Earthquake : Template
    {
        public static readonly Guid ID = Guid.Parse("92b36046-a4b4-40ab-97c4-9df1bd3f4281");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Earthquake",
                Level = 8,
                Range = "500 feet.",
                Area = "60-foot burst.",
                Duration = "1 round.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41f2dc44-e9dc-422f-9130-53c9587e9b6f"), Type = TextBlockType.Text, Text = "You shake the ground, topple creatures into fissures, and collapse structures." };
            yield return new TextBlock { Id = Guid.Parse("35ed4648-9551-4fab-a20e-f61f308efc1a"), Type = TextBlockType.Text, Text = "The GM might add additional effects in certain areas. Cliffs might collapse, causing creatures to fall, or a lake might drain as fissures open up below its surface, leaving a morass of quicksand." };
            yield return new TextBlock { Id = Guid.Parse("2db2817f-1538-4da6-a3b8-07f79e1101ab"), Type = TextBlockType.Enumeration, Text = "Shaking Ground - The ground is difficult terrain, and creatures on it take a –2 circumstance penalty to attack rolls, AC, and skill checks." };
            yield return new TextBlock { Id = Guid.Parse("b184719b-3e04-4c16-ac93-9ff98c46fac0"), Type = TextBlockType.Enumeration, Text = "Fissures - Each creature on the ground must attempt a Reflex save at the start of its turn to keep its footing and avoid falling into 40-foot-deep fissures that open beneath it. The fissures are permanent, and their sides require successful DC 15 Athletics checks to Climb." };
            yield return new TextBlock { Id = Guid.Parse("3d56ff19-9b3d-4f02-8c64-f30d2cf8cbd1"), Type = TextBlockType.Enumeration, Text = "Collapse - Structures and ceilings might collapse. The GM rolls a flat check for each (DC 16 for a sturdy structure, DC 14 for an average structure and most natural formations, DC 9 for a shoddy structure, all adjusted higher or lower as the GM sees fit). A collapse deals 11d6 bludgeoning damage; each creature caught in a collapse must attempt a Reflex save to avoid it." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("97f65b99-9ad8-46c7-8d63-95543d8bca07"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b3e0c243-0694-47f3-88ad-e6340f0af0db"), Type = TextBlockType.Text, Text = "You create a massive earthquake that can devastate a settlement. The range increases to half a mile and the area to a quarter-mile burst." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ff7f9657-5fc6-4465-b51e-a012d2bb57f6"),
                CriticalSuccess = "The creature takes half the collapse damage.",
                Success = "The creature takes half the collapse damage and falls prone.",
                Failure = "The creature takes the full collapse damage and falls prone.",
                CriticalFailure = "The creature takes the full collapse damage and falls into a fissure."
            };
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
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f75feae-572e-4888-9d72-76b620be63f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 334
            };
        }
    }
}
