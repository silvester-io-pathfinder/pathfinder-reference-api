using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class ManifoldAlloy : Template
    {
        public static readonly Guid ID = Guid.Parse("12fd3a1a-b6c4-4684-8637-cddb2f8056bd");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Manifold Alloy",
                Description = "You've devised several alloys that contain useful properties of various metals, and you replace a number of parts of your weapon or its ammunition with pieces from these alloys. Your weapon innovation is cold iron and silver. This means you deal more damage to a variety of supernatural creatures, such as demons, devils, and fey.",
                InnovationId = Innovations.Instances.Weapon.ID,
                TypeId = InnovationModificationTypes.Instances.Breakthrough.ID
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
                Id = Guid.Parse("7df547d1-fd87-4443-b7f2-a078ade6c8b8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}
