using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class KiBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("534d8987-816c-49a1-a46f-08887f855b83");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ki Blast",
                Level = 3,
                Area = "15-foot cone or more.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("649e5e60-fb4d-464d-a514-21b313f628b6"), Type = TextBlockType.Text, Text = "You unleash your ki as a powerful blast of force that deals 2d6 force damage. If you use 2 actions to cast ki blast, increase the size of the cone to 30 feet and the damage to 3d6. If you use 3 actions to cast ki blast, increase the size of the cone to 60 feet and the damage to 4d6. Each creature in the area must attempt a Fortitude saving throw." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3d7b2050-b3bf-44cf-8cfd-fb0d60384585"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4eb5ed89-5f4b-4937-a560-e9ae5fc43027"), Type = TextBlockType.Text, Text = "The damage increases by 1d6, or by 2d6 if you use 2 or 3 actions." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d73baad1-0303-486e-a14d-60401dc5e779"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is pushed 5 feet.",
                CriticalFailure = "The creature takes double damage and is pushed 10 feet."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("db8a1890-63b7-4b20-aa47-0d7cdc37b6af"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("2546fc15-cf0f-49fc-a575-9ae616106b74"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("151aefcb-9cc7-4361-a0b9-bd2c72069f6b"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("fb4bf558-486c-4625-abbe-e21c1ca62932"), Traits.Instances.Monk.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf99d20f-54a7-49f3-b2b8-dde6a63f954d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 401
            };
        }
    }
}
