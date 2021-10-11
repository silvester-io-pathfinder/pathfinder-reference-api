using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class AquaticAmbush : Template
    {
        public static readonly Guid ID = Guid.Parse("9709b988-d835-40a6-89ad-7962e270ebb2");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Aquatic Ambush",
                Requirements = "The monster is hiding in water and a creature that hasn�t detected it is within the listed number of feet.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("96f5ac6b-72c5-4d33-9a53-6176ba19346e"), Text = "he monster moves up to its swim Speed + 10 feet toward the triggering creature, traveling on water and on land. Once the creature is in reach, the monster makes a Strike against it. The creature is flat-footed against this Strike." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17f0cfbf-ecd0-4b25-aea9-0705510b3d1e"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
