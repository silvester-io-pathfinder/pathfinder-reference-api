using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class PerfectFortification : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Perfect Fortification",
                Description = "You've outfitted your armor with such heavy fortifications that deadly attacks often lose their edge. Each time you're critically hit while wearing the armor, attempt a DC 13 flat check. On a success, it becomes a normal hit. This isn't cumulative with fortification runes or other abilities that reduce critical hits with a flat check. Additionally, you gain resistance 2 + half your level against precision damage.",
                InnovationId = Innovations.Instances.ArmorInnovation.ID,
                TypeId = InnovationModificationTypes.Instances.Revolutionary.ID
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
                Page = 23
            };
        }
    }
}
