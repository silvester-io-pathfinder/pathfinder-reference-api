using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CannyAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("82a3a6e9-8d85-4d4c-aecf-1f5384ca3931");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Canny Acumen",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52ca46b4-3ab1-46a0-8de4-476099c4887d"), Type = TextBlockType.Text, Text = "Your avoidance or observation is beyond the ken of most in your profession. Choose Fortitude saves, Reflex saves, Will saves, or Perception. You become an expert in your choice. At 17th level, you become a master in your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65d0114f-e8a4-4ec6-9e5a-e140dd9a9cc7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
