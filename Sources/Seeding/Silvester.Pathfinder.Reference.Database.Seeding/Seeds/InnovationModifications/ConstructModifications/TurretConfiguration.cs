using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class TurretConfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("75b2e350-0193-45ec-9d2f-c57d6ca3bd84");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Turret Configuration",
                Description = "Your innovation can transform from a mobile construct to a stationary turret. Your construct companion can transform as a single action, which has the manipulate trait, turning into a turret in its space (or transforming back from a turret into its normal configuration). While it's a turret, your innovation is immobilized, but the damage die from its projectile launcher increases to 1d6 and the range increment increases to 60 feet. You must have the projectile launcher modification to select this modification.",
                InnovationId = Innovations.Instances.Construct.ID,
                TypeId = InnovationModificationTypes.Instances.Breakthrough.ID
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fd8fa04-ec69-413d-824c-50fa0e897187"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}