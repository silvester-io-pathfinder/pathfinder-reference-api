using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class WonderGears : Template
    {
        public static readonly Guid ID = Guid.Parse("12db7b9c-2dc1-41b0-9fce-32619dbf065f");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Wonder Gears",
                Description = "You map specialized skills into your construct's crude intelligence. Your innovation becomes trained in Intimidation, Stealth, and Survival.",
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
                Id = Guid.Parse("c9826334-5e8d-49a2-b7e7-c0afc56ade9e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 18
            };
        }
    }
}
