using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class WallConfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Wall Configuration",
                Description = "Your innovation can transform from a mobile construct to a stationary battlefield emplacement. It can unfold as a 2-action activity that has the manipulate trait, changing from its usual form into a thin, straight wall of metal and gears up to 10 feet tall and 30 feet long. The wall must extend through your innovation's original space. While your construct is a wall, it can't take any actions except to use the same activity to transform back, and it can't defend itself easily, making it flat-footed and giving it an additional –2 status penalty to its AC. The wall blocks line of sight and effect unless your innovation has half its maximum HP or fewer, at which point holes in the wall allow creatures to see through and attack with cover, and Tiny creatures to slip through.",
                InnovationId = Innovations.Instances.Construct.ID,
                TypeId = InnovationModificationTypes.Instances.Revolutionary.ID
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}
