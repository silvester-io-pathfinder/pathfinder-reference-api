using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PolarRay : Template
    {
        public static readonly Guid ID = Guid.Parse("d38967b5-1db4-4d11-b804-196bf9dcc574");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Polar Ray",
                Level = 8,
                Range = "120 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20efbc1e-0d19-46ab-929f-546f2985bc77"), Type = TextBlockType.Text, Text = "You fire a blue-white ray of freezing air and sleet that deals 10d8 cold damage. Make a spell attack roll against the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("742ffe55-d82f-4de0-a580-f31766ad96ac"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ba6b85c9-f153-4209-b274-9234dc5fb102"), Type = TextBlockType.Text, Text = "The damage increases by 2d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e4d0b50f-ef5c-4f0c-9447-aead23e6bd42"),
                CriticalSuccess = "The target takes double damage and is drained 2.",
                Success = "The target takes full damage and is drained 2.",
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
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60d95821-fc71-421a-96a7-80529ab75711"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 358
            };
        }
    }
}
