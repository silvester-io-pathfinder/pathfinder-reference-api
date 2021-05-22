using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RayOfFrost : Template
    {
        public static readonly Guid ID = Guid.Parse("c5479bd0-14c5-4df7-bca5-017566cfd5b5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ray of Frost",
                Level = 1,
                Range = "120 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("941fed5e-7238-4f90-917e-0a57426b5b36"), Type = TextBlockType.Text, Text = "You blast an icy ray. Make a spell attack roll. The ray deals cold damage equal to 1d4 + your spellcasting ability modifier." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2115ea4d-7f20-4a3f-80fa-ac750a175d12"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7f7c61e0-a53d-457d-9201-74fdc3fc34b6"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("cd83db63-1ac8-4760-aba4-11267e981565"),
                CriticalSuccess = "The target takes double damage and takes a –10-foot status penalty to its Speeds for 1 round.",
                Success = "The target takes normal damage.",
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
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8bb0974-8314-4e3a-a6bb-73e1f86427eb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 362
            };
        }
    }
}
