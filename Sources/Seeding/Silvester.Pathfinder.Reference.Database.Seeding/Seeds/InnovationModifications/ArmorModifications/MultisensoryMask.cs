using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class MultisensoryMask : Template
    {
        public static readonly Guid ID = Guid.Parse("b18a39f7-f232-43f8-af6d-da270f951859");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Multisensory Mask",
                Description = "You've built a multisensory mask over your armor that protects you by distorting your figure from all senses, leaving behind only a hazy image, muffled sounds, and so forth. While wearing the armor, you gain concealment against all creatures, even if they are using a nonvisual precise sense, such as a bat's echolocation. As normal for effects that leave your location obvious, you can't use this concealment to Hide or Sneak. If you use a hostile action, the concealment ends until you restore the mask as a single action, which has the manipulate trait.",
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
                Id = Guid.Parse("bb591074-ae1e-4bb9-a8bc-b40be41c079b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}
