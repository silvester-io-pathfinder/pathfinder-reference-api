using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GraspingGrave : Template
    {
        public static readonly Guid ID = Guid.Parse("1fc9723e-f16c-408e-bbc6-bb3f2640d92f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Grasping Grave",
                Level = 5,
                Range = "60 feet.",
                Area = "20-foot radius on the ground.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("051437af-4edb-4781-ac61-3723d2669ab5"), Type = TextBlockType.Text, Text = "Hundreds of skeletal arms erupt from the ground in the area, clawing at creatures within and attempting to hold them in place. The skeletal arms deal 6d6 slashing damage. Each creature in the area must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("289648c8-3d6a-4520-8294-d29674a03188"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7245d43f-34d3-48ec-94ed-3d0e03925486"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("92a9d6a3-3159-40c4-bbba-cb82adc5fb7b"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and a –10-foot circumstance penalty to its Speeds for 1 round.",
                CriticalFailure = "The creature takes double damage and is immobilized for 1 round or until it Escapes."
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
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce7198dc-979d-45db-aa34-31ecb08eabdf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
