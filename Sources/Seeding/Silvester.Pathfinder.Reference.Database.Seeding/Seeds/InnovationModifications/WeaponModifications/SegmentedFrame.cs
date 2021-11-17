using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class SegmentedFrame : Template
    {
        public static readonly Guid ID = Guid.Parse("7592bff3-b78b-4927-9d22-5cd2c390e0e1");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Segmented Frame",
                Description = "Hinges, clamps, and telescoping parts make your innovation collapsible and adjustable. It gains the modular trait for bludgeoning, piercing, and slashing. You can Interact to collapse the item down to light Bulk or to return it to your normal form. When it's collapsed to light Bulk, it has the concealable trait, which grants you a +2 circumstance bonus to Stealth checks and DCs to hide or conceal the weapon.",
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
                Id = Guid.Parse("36142b4e-029e-4bb1-ac9b-60f9e27d9c2e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 19
            };
        }
    }
}
