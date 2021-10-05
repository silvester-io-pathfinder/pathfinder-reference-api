using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PummelingRubble : Template
    {
        public static readonly Guid ID = Guid.Parse("a3135b79-cbae-4247-9498-c673d0ef1f19");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pummeling Rubble",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba0921b7-c2c8-413b-8696-6f3c121a7ed5"), Type = TextBlockType.Text, Text = "A spray of heavy rocks flies through the air in front of you. The rubble deals 2d4 bludgeoning damage to each creature in the area. Each creature must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e4ef90f4-4c0d-4b0e-8832-7ede5daa0700"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("de2e7df7-4274-48ba-b231-e3adb9f9fb63"), Type = TextBlockType.Text, Text = "Increase the damage by 2d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("205a4736-540f-4fd2-9f14-7dcffbe73565"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is pushed 5 feet away from you.",
                CriticalFailure = "The creature takes double damage and is pushed 10 feet away from you."
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
                Id = Guid.Parse("eef21fed-bab3-444f-9b07-dc88ec62f84d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 223
            };
        }
    }
}
