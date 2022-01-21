using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class ClimbingLimbs : Template
    {
        public static readonly Guid ID = Guid.Parse("6c8309dd-fb0c-4159-897a-67df3090531d");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Climbing Limbs",
                Description = "With appendages that can claw or create suction, your construct becomes a capable climber. Your innovation gains a climb Speed equal to half its land Speed.",
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
                Id = Guid.Parse("9143a5d4-2239-4af3-9b50-46fed65bf622"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}
