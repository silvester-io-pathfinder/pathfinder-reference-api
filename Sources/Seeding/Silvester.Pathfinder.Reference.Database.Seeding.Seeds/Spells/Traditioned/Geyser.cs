using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Geyser : Template
    {
        public static readonly Guid ID = Guid.Parse("ccae2ea2-47e1-49d6-a76e-2ea69f3c1d2b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Geyser",
                Level = 5,
                Range = "500 feet.",
                Duration = "1 round.",
                Area = "10-feet radius, 50-foot-tall cylinder.",
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb89fa15-62c3-437d-ab8f-cf1033fdd334"), Type = TextBlockType.Text, Text = "A powerful geyser blasts up from the ground, potentially pushing creatures on top of it into the air. The bottom of this spell�s area must be on solid ground. Each creature in the area takes 3d6 bludgeoning damage and 4d6 fire damage, with a Reflex save. A creature pushed into the air by the geyser can�t be pushed beyond the top of the geyser. After being pushed into the air, a creature falls unless it�s flying or has some other means of staying aloft, taking falling damage (normally equal to half the distance it fell). After the geyser erupts, its area is filled with a cloud of steam for 1 round. All creatures in the steam are concealed, and all creatures outside the steam are concealed to creatures within it." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2a4913e6-d049-41b2-b89c-042fac65bc34"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("4421570a-63a4-4362-8bcc-9efdb40e683a"), Type = TextBlockType.Text, Text = "The damage increases by 1d6 bludgeoning and 1d6 fire." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("5bd232d4-ebeb-426d-8503-416f57539fc3"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and isn�t pushed into the air.",
                Failure = "The creature takes full damage and is pushed 20 feet into the air.",
                CriticalFailure = "The creature takes double damage and is pushed 40 feet into the air."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2b7f085e-983d-41bc-9000-760d22368005"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("5ab5ed10-e74e-4b49-94da-1d659bab55c3"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("be6de27e-0629-41d9-a25f-eb128f97213a"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("208f5793-ee65-4101-9c57-5684d739883d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 108
            };
        }
    }
}
