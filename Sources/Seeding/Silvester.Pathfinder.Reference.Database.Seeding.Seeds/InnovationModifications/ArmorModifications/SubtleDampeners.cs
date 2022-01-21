using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class SubtleDampeners : Template
    {
        public static readonly Guid ID = Guid.Parse("b7656e36-4a80-47ae-a961-9e6d9d13684f");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Subtle Dampeners",
                Description = "You've designed your armor to help you blend in and dampen noise slightly. When you send your armor into overdrive, the dampeners increase their effect, improving your Stealth. When under the effects of Overdrive, you gain a +1 circumstance bonus to Stealth checks. If you're a master in Crafting, this increases to a +2 circumstance bonus.",
                InnovationId = Innovations.Instances.Armor.ID,
                TypeId = InnovationModificationTypes.Instances.Initial.ID
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects (with restriction on Subterfuge Suit somehow..).

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("492e53c9-4055-4177-b4ce-7db8f4dcc404"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 17
            };
        }
    }
}
