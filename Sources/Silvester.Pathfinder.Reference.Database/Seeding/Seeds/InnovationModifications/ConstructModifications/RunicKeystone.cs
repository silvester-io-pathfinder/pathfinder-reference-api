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
    public class RunicKeystone : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Runic Keystone",
                Description = "You've incorporated a device similar to a runestone into your innovation, allowing it to hold a property rune, even though it isn't a weapon or suit of armor. An armor property rune affects your innovation itself if it would affect the wearer of the armor. A weapon property rune grants whatever properties it would normally grant to a weapon to your innovation's unarmed attacks, following all the requirements as normal (for instance, a vorpal rune would only apply to slashing melee unarmed attacks); if the rune affects only ranged attacks, it has no effect unless your innovation has a built-in ranged attack (from the projectile launcher initial modification, for example). If the rune would affect the physical shape or appearance of the weapon or armor itself, like glamered, the rune has no effect when etched into your construct.",
                InnovationId = Innovations.Instances.ConstructInnovation.ID,
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
