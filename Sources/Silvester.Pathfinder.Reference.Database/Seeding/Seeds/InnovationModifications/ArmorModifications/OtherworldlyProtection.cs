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
    public class OtherworldlyProtection : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Otherworldly Protection",
                Description = "Just because you use science doesn't mean you can't build your armor with carefully chosen materials and gizmos designed to protect against otherworldly attacks. You gain resistance equal to 3 + half your level to negative damage, or to positive damage if you have negative healing (such as if you're a dhampir). You gain the same amount of resistance to any types of alignment damage—good, evil, chaotic, lawful—that can damage you (note that creatures don't take a given type of alignment damage unless they are of the opposing alignment; for instance, you can take evil damage only if you are good in alignment).",
                InnovationId = Innovations.Instances.ArmorInnovation.ID,
                TypeId = InnovationModificationTypes.Instances.Initial.ID
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
                Page = 17
            };
        }
    }
}
