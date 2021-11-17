using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpikeStones : Template
    {
        public static readonly Guid ID = Guid.Parse("64a51156-d351-467a-b4ea-64b6474f40e8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spike Stones",
                Level = 4,
                Range = "60 feet.",
                Area = "20-foot burst.",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bacd66e0-4624-4fdf-a5f4-4ef7c5639f37"), Type = TextBlockType.Text, Text = "Long, sharp spikes of solid rock thrust up from the ground in the area. The area becomes difficult terrain and hazardous terrain. A creature that moves on the ground through the area takes 3 piercing damage for every square of that area it moves into." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e57e0a53-bc3f-4714-aa46-665a3feea8d1"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("506195f4-0b46-4d1d-a6a5-83d22b6bcef7"), Type = TextBlockType.Text, Text = "Increase the damage by 1." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Earth.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bad75e7-9729-4211-9362-0555aa2801b6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 225
            };
        }
    }
}
