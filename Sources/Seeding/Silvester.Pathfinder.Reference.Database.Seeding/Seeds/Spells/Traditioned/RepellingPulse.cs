using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RepellingPulse : Template
    {
        public static readonly Guid ID = Guid.Parse("1856221f-1dbc-45f2-9abf-dfeb5ada64d9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Repelling Pulse",
                Level = 5,
                Area = "30-foot emanation.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c88dedd6-3e69-46c1-b1eb-651513343a96"), Type = TextBlockType.Text, Text = "You unleash a powerful pulse of telekinetic power, and the pulse violently hurls creatures away from you. Each creature in the area takes 7d10 force damage depending on its Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c341c8e9-9357-4471-ad4a-eae380af9d9b"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("65fc7694-5981-4d89-9c76-7adcf6c8facf"), Type = TextBlockType.Text, Text = "The force damage increases by 2d10, and the distance the target is moved on a failure and critical failure increases by 5 feet." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f2d278d7-a3fb-427e-a1a6-6d29b49f2cd3"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is pushed 10 feet away from you.",
                CriticalFailure = "The creature takes double damage. The creature is pushed 20 feet away from you and is then knocked prone."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d565b87c-d69f-4d35-9150-1cba17c2b16a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 125
            };
        }
    }
}
