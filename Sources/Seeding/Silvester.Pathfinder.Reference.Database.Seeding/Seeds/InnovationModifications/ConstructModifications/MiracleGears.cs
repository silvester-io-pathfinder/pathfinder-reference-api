using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class MiracleGears : Template
    {
        public static readonly Guid ID = Guid.Parse("f6ebca68-ebc9-4c96-8306-cdda131d2659");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Miracle Gears",
                Description = "As you perfect your innovation's cortex, it becomes much more intelligent. Its Intelligence modifier increases by 2, and it learns a language of your choice from among the languages you know. Your construct gains the ability to use actions that require greater Intelligence, like Coerce and Decipher Writing. Finally, your construct becomes legendary in two Intelligence- or Charisma-based skills of your choice. You must have the marvelous gears modification to select this modification.",
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
                Id = Guid.Parse("3ac47174-7877-44b8-be4b-f1f70412339a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}