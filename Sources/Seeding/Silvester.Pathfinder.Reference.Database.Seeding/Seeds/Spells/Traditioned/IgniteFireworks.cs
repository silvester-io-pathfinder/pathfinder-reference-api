using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class IgniteFireworks : Template
    {
        public static readonly Guid ID = Guid.Parse("892d7c66-ed5c-4781-a5e5-3ed07cf33967");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ignite Fireworks",
                Level = 2,
                Range = "60 feet.",
                Area = "10-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3e931e5-4795-4c63-ae16-b6ef4e25396c"), Type = TextBlockType.Text, Text = "A brilliant and clamorous display of sparks and colorful fireworks explode around your enemies, dealing 1d8 fire damage and 1d8 sonic damage to creatures within a 10-foot burst. All creatures in the area must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("443e2aec-cc3a-4045-a44c-bf43888e5f4c"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("54918b57-fe50-4637-a053-b609af682ba8"), Type = TextBlockType.Text, Text = "The initial fire damage increases by 1d8, the sonic damage increases by 1d8, and the persistent fire damage a creature takes on a critical failure increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2c42978d-0fb9-4e3f-a25b-b0b552721169"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and is dazzled for 1 round.",
                Failure = "The creature takes full damage and is dazzled for 3 rounds.",
                CriticalFailure = "The creature takes double damage, takes 1d4 persistent fire damage, and is dazzled for 1 minute."
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6385ae94-b3d5-44d9-9e4f-0610161a2505"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 110
            };
        }
    }
}
