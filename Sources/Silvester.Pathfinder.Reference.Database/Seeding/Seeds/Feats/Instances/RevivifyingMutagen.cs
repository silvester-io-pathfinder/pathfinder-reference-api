using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RevivifyingMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("6c31107d-b72a-4d3d-ba8f-e8650200c376");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Revivifying Mutagen",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1753e7d-a138-4b25-99d9-a31be4dc9929"), Type = TextBlockType.Text, Text = "While under the effect of a mutagen, you can metabolize that mutagen’s power to heal yourself. This uses a single action, which has the (trait: concentrate) and (trait: manipulate) traits. Once the action is complete, you regain 1d6 Hit Points for every 2 item levels of the mutagen (minimum 1d6), but the mutagen’s duration immediately ends, even if you are under the effect of (feat: Persistent Mutagen)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("228cd3db-1adb-40df-a039-ed5c4c91cb02"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
