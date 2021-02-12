using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class UntrainedImprovisationFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("9648e97f-800c-492f-9277-93a17174bab1"),
                Name = "Untrained Improvisation",
                Level = 3
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("eb92aacb-50c4-49d2-8ed0-71860ad8582e"), Text = "You’ve learned how to handle situations when you’re out of your depth. Your proficiency bonus to untrained skill checks is equal to half your level instead of +0. If you’re 7th level or higher, the bonus increases to your full level instead. This doesn’t allow you to use the skill’s trained actions." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
