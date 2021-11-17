using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class EnergyBarrier : Template
    {
        public static readonly Guid ID = Guid.Parse("b716a8db-21e8-4904-ba5d-cae3bfd2993e");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Energy Barrier",
                Description = "Your armor's defenses ablate any kind of energy coming your way. While wearing your armor, you gain resistance to all energy damage (acid, cold, electricity, fire, force, negative, positive, and sonic damage) equal to 2 + half your level. You must have the harmonic oscillator, metallic reactance, or phlogistonic regulator modification to select this modification.",
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
                Id = Guid.Parse("b3a6612f-2b50-4f3d-9129-8dc53b196113"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}
