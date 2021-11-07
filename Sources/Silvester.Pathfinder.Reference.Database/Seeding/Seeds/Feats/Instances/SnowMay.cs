using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnowMay : Template
    {
        public static readonly Guid ID = Guid.Parse("87f70949-eb01-4869-a5bb-4f02bf5291a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snow May",
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
            yield return new TextBlock { Id = Guid.Parse("86b8e143-66db-4e53-b822-932a989c9433"), Type = TextBlockType.Text, Text = "You’re the child of a winter hag, with one blue-white eye and an affinity for rime and snow. When moving over ice or snow in arctic terrain, you always gain the benefits of the (action: Cover Tracks) action without needing to use the activity or having to move half your Speed. You don’t treat icy terrain as uneven ground (though it’s still difficult terrain for you), and you ignore difficult terrain caused by snow. Cold precipitation and environmental cold effects don’t alter the time it takes for you to become fatigued." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ab2ac30-9232-4d2c-bcba-b0e6cfe48289"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
