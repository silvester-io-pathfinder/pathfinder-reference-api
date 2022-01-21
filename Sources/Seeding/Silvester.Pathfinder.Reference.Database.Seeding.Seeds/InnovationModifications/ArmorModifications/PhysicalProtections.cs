using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class PhysicalProtections : Template
    {
        public static readonly Guid ID = Guid.Parse("3b835b23-4411-4dce-ba30-e5ce1a5f1ff4");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Physical Protections",
                Description = "Your armor has so many adjustments and precautions that it can guard against all physical damage. While wearing your armor, you gain resistance to all physical damage (bludgeoning, piercing, and slashing damage, as well as persistent bleed damage) equal to half your level. You must have the dense plating, layered mesh, or tensile absorption breakthrough modification to select this modification.",
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
                Id = Guid.Parse("bbce6614-3dc4-4743-9ce0-6b0770ec083e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}
