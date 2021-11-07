using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class HeftyComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Hefty Composition",
                Description = "Blunt surfaces and sturdy construction make your weapon hefty and mace-like. Your innovation gains the shove and versatile B traits.",
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 19
            };
        }
    }
}
