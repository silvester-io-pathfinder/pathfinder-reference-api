using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class ImpossibleAlloy : Template
    {
        public static readonly Guid ID = Guid.Parse("cb04d971-81f2-4dfe-88d7-3875b9bb3466");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Impossible Alloy",
                Description = "Other inventors claim it's not even technically possible, but you've managed to create several metal alloys that seem to work for only you. These alloys can damage opponents vulnerable to any one of the seven skymetals. Your innovation is treated as all seven skymetals (abysium, adamantine, djezet, inubrix, noqual, orichalcum, and siccatite). This means you deal more damage to a variety of creatures, though you don't apply any of the other special effects for weapons made of those skymetals.",
                InnovationId = Innovations.Instances.Weapon.ID,
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
                Id = Guid.Parse("d96418e2-b925-4a01-b9da-08a4819f6aa9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 24
            };
        }
    }
}
