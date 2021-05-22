using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpikeStones : Template
    {
        public static readonly Guid ID = Guid.Parse("97c974ff-c493-4103-841a-0a6b65c4de7c");

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
            yield return new TextBlock { Id = Guid.Parse("97c974ff-c493-4103-841a-0a6b65c4de7c"), Type = TextBlockType.Text, Text = "Long, sharp spikes of solid rock thrust up from the ground in the area. The area becomes difficult terrain and hazardous terrain. A creature that moves on the ground through the area takes 3 piercing damage for every square of that area it moves into." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("97c974ff-c493-4103-841a-0a6b65c4de7c"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("97c974ff-c493-4103-841a-0a6b65c4de7c"), Type = TextBlockType.Text, Text = "Increase the damage by 1." }
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
                Id = Guid.Parse("97c974ff-c493-4103-841a-0a6b65c4de7c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 225
            };
        }
    }
}
