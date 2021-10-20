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
    public class DynamicWeighting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Dynamic Weighting",
                Description = "Your weapon's modified weight distribution can increase power in exchange for taking more hands to wield. Your innovation gains the two-hand trait, with a damage die one size higher than the weapon's normal weapon damage die size (for instance, a longsword would gain the two-hand d10 trait). Your innovation also gains the versatile B trait.",
                InnovationId = Innovations.Instances.WeaponInnovation.ID,
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
                Page = 18
            };
        }
    }
}
