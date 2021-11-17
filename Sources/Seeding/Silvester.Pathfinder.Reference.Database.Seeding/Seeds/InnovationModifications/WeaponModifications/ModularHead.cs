using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class ModularHead : Template
    {
        public static readonly Guid ID = Guid.Parse("14835d1d-b4f2-4da9-9b12-c07c1d078e16");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Modular Head",
                Description = "You've constructed a multi-purpose, adjustable striking surface for your weapon, or you've made special ammunition you can swiftly alter. Your innovation gains the modular trait for bludgeoning, piercing, and slashing. When you Interact to use the modular trait, you can also choose to give the weapon the nonlethal trait if it doesn't currently have it, or to remove that trait if it's currently nonlethal.",
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
                Id = Guid.Parse("1a45ad49-796c-4027-b9ad-537e95d739b5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 19
            };
        }
    }
}