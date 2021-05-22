using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Thunderburst : Template
    {
        public static readonly Guid ID = Guid.Parse("d9b56679-1f96-415d-aa40-a833baf1cfea");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Thunderburst",
                Level = 3,
                Range = "100 feet.",
                Area = "20-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
                MysteryId = Mysteries.Instances.Tempest.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5d57eaf-c157-4ed4-97d5-0e5fd6010dc1"), Type = TextBlockType.Text, Text = "You create a powerful blast of air and a loud peal of thunder, dealing 2d6 bludgeoning damage and 2d6 sonic damage. Each creature in the area must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b304c989-0738-404d-a597-b3e74d0681ee"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7c8f31bf-5ae0-4464-b681-1e62377d8e6d"), Type = TextBlockType.Text, Text = "Increase each type of damage by 2d6 and the area by 5 feet." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("312a93b8-0a85-4dc6-b0df-3c5c453aa656"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is deafened for 1 minute.",
                CriticalFailure = "The creature takes double damage and is deafened for 1 hour."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Oracle.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c905ca56-2c45-45f1-9552-47436caffc0c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
