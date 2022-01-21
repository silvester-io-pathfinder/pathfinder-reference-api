using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class BluntShot : Template
    {
        public static readonly Guid ID = Guid.Parse("ed69d4db-6947-4ac6-b509-faa37a47c7d3");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Blunt Shot",
                Description = "Your weapon innovation can file the edges off your ammunition and adjust the blunt force of the shot to deliver a bludgeoning attack when necessary, as well as to avoid striking a lethal blow with an otherwise deadly shot. Your innovation gains the nonlethal and versatile B traits. You can choose whether to apply the nonlethal trait on each attack with your innovation.",
                InnovationId = Innovations.Instances.Weapon.ID,
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
                Id = Guid.Parse("cbf25fca-425b-4a36-8845-646da6b70aa9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 18
            };
        }
    }
}
