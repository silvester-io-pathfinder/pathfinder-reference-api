using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Earthbind : Template
    {
        public static readonly Guid ID = Guid.Parse("e5258901-d960-4efd-ba40-638b73841ccb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Earthbind",
                Level = 3,
                Range = "120 feet.",
                Duration = "Varies.",
                Targets = "1 flying creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97fee1b6-f6d5-46f7-bc67-d44b4556468c"), Type = TextBlockType.Text, Text = "Using the weight of earth, you hamper a target’s flight, with effects based on its Fortitude save. If the creature reaches the ground safely, it doesn’t take falling damage." };
        }



        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("651afaa5-1173-4e8f-94a3-aec89cbfcada"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target falls safely up to 120 feet.",
                Failure = "The target falls safely up to 120 feet. If it hits the ground, it can’t Fly, levitate, or otherwise leave the ground for 1 round.",
                CriticalFailure = "The target falls safely up to 120 feet. If it hits the ground, it can’t Fly, levitate, or otherwise leave the ground for 1 minute."
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
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40b565a7-4c20-4c73-8631-648e0b700f37"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 334
            };
        }
    }
}
