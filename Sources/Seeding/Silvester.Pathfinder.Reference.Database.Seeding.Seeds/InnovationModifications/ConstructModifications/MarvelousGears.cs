using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ConstructModifications
{
    public class MarvelousGears : Template
    {
        public static readonly Guid ID = Guid.Parse("f8257a7e-6d86-4b1f-a0a1-2a3dcb35f9af");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Marvelous Gears",
                Description = "Your innovation gains expert proficiency in Intimidation, Stealth, and Survival. For any of these skills in which it was already an expert (because of being an advanced construct companion, for example), it gains master proficiency instead. If you have the revolutionary innovation class feature, these proficiencies improve to master, or legendary if your construct innovation was already an expert. You must have the wonder gears modification to select this modification.",
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
                Id = Guid.Parse("82a44c1d-2247-4dc3-b547-7bc7ef0abacf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}
