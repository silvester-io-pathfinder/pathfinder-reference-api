using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("ca290cb0-c098-416f-b5dd-186fae2d6e18");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Divine Wrath",
                Level = 4,
                Range = "120 feet.",
                Area = "20-foot burst.",
                IsSavingThrowBasic = false,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
             yield return new TextBlock { Id = Guid.Parse("226067e2-ba86-46de-a932-e1f1087b94fa"), Type = TextBlockType.Text, Text = "You can channel the fury of your deity against foes of opposed alignment. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or your deity is true neutral. This spell gains the trait of the alignment you chose. You deal 4d10 damage of the alignment you chose; each creature in the area must attempt a Fortitude save. Creatures that match the alignment you chose are unaffected. Those that neither match nor oppose it treat the result of their saving throw as one degree better." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9eef3d6d-1975-407d-b65d-8a5f825f5b69"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2f97af17-6ca8-44cb-b341-b7a57d0c5fae"), Type = TextBlockType.Text, Text = "The damage increases by 1d10." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ceca903c-5829-4492-986c-aa6c1cfbd56a"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is sickened 1.",
                CriticalFailure = "The creature takes full damage and is sickened 2; while it is sickened, it is also slowed 1."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24af6b28-f2e8-44a0-9dd8-d55b59b075e9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 332
            };
        }
    }
}
