using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class AdvancedWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Advanced Weaponry",
                Description = "You've powered up your construct's weaponry. Choose one of your construct's unarmed attacks to gain your choice of one initial weapon modification, chosen any initial weapon modifications to which you have access. The unarmed attack must meet any requirements for the chosen traits (such as being a melee attack for entangling form), and since it's an unarmed attack, it can never meet certain requirements, such as being a simple weapon for complex simplicity.",
                InnovationId = Innovations.Instances.ConstructInnovation.ID,
                TypeId = InnovationModificationTypes.Instances.Breakthrough.ID
            };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add effects.
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}
