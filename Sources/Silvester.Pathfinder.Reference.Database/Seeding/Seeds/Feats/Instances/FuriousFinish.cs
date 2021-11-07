using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuriousFinish : Template
    {
        public static readonly Guid ID = Guid.Parse("e2e470b1-1d82-474c-88b7-74bcf829a534");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Finish",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2029a160-97e9-4ec1-b1f7-31e8310317b6"), Type = TextBlockType.Text, Text = "Desperate to finish the fight, you pour all your rage into one final blow. Make a (Action: Strike). If it hits, you gain a circumstance bonus to damage equal to the number of rounds remaining in your (Action: Rage) (maximum 10). After this (Action: Strike), your (Action: Rage) immediately ends, and you are fatigued until you rest for at least 10 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5a9ea72-4737-4f5f-9fc2-3f695926eafe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
