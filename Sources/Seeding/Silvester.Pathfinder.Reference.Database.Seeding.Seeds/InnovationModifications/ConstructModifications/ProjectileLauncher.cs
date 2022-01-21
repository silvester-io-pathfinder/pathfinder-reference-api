using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class ProjectileLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("3032644e-6efd-48c1-b681-94489e47b794");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Projectile Launcher",
                Description = "Your construct has a mounted dart launcher, embedded cannon, or similar armament. Your innovation gains a ranged unarmed attack that deals 1d4 bludgeoning or piercing damage (you choose when you pick this modification). The attack has the propulsive trait and a range increment of 30 feet.",
                InnovationId = Innovations.Instances.Construct.ID,
                TypeId = InnovationModificationTypes.Instances.Initial.ID
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
                Id = Guid.Parse("e52a9428-7b85-4ac2-93ef-7e6238ff08ff"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 18
            };
        }
    }
}
