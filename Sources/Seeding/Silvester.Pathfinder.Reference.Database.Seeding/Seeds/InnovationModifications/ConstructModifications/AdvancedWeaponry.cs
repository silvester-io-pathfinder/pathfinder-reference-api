using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class AdvancedWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("fc7c6281-e4bb-477a-92a6-02141faa477f");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Advanced Weaponry",
                Description = "You've powered up your construct's weaponry. Choose one of your construct's unarmed attacks to gain your choice of one initial weapon modification, chosen any initial weapon modifications to which you have access. The unarmed attack must meet any requirements for the chosen traits (such as being a melee attack for entangling form), and since it's an unarmed attack, it can never meet certain requirements, such as being a simple weapon for complex simplicity.",
                InnovationId = Innovations.Instances.Construct.ID,
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
                Id = Guid.Parse("d4cd5c14-bfd9-437f-8d51-316b1b39ceec"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}
