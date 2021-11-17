using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatchyTune : Template
    {
        public static readonly Guid ID = Guid.Parse("04ef3232-40c1-49d2-9900-da4c2f674150");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catchy Tune",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2891dbdf-b53a-4385-90df-cef617bbd0ad"), Type = TextBlockType.Text, Text = "You create a tune so catchy, your foes can’t help but dance along. Attempt a Performance check against the Will DCs of all enemies in a 30-foot emanation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("43e77e1a-7e54-4b1e-9d6e-65165b9decd0"),
                CriticalSuccess = "The target takes a -10-foot status penalty to its Speed and is flat-footed, both for 1 round.",
                Success = "The target takes a –5-foot status penalty to its Speed for 1 round.",
                
                CriticalFailure = "The target is temporarily immune for 1 hour.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ff52421-7f4a-4c49-9a06-1da113b0cf5f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
