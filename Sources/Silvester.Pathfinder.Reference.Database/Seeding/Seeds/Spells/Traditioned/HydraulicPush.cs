using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HydraulicPush : Template
    {
        public static readonly Guid ID = Guid.Parse("39319090-baf5-4ecf-89e9-151a26522d3d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hydraulic Push",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature or unattended object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("036694bd-3506-4731-b174-163d514a3044"), Type = TextBlockType.Text, Text = "You call forth a powerful blast of pressurized water that bludgeons the target and knocks it back. Make a ranged spell attack roll." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b15f5c5b-fe78-45e4-a5ed-a2b780376218"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0e17b926-9d50-4132-a1da-f2fc7ad4eea4"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8a8af738-6de8-475e-b0eb-f18bf5191629"),
                CriticalSuccess = "The target takes 6d6 bludgeoning damage and is knocked back 10 feet.",
                Success = "The target takes 3d6 bludgeoning damage and is knocked back 5 feet.",
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3438ffd5-bd89-4128-8ff4-9015f6899ac6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
