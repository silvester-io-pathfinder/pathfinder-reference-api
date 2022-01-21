using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class IncredibleResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("a1f976bf-943e-4ea5-8004-a3b29697fdc3");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Incredible Resistance",
                Description = "You've improved upon your breakthrough modification's ability to resist damage. Choose one of the following breakthrough modifications your innovation has: dense plating, layered mesh, or tensile absorption. Increase the resistance you gain from that modification to be equal to your level, instead of half your level.",
                InnovationId = Innovations.Instances.Armor.ID,
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
                Id = Guid.Parse("ca09628e-ba63-4567-a202-a111ef2befec"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}
