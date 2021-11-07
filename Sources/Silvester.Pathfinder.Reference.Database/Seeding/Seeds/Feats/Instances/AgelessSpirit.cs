using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgelessSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("b9b562c7-8b9c-4ee8-a99b-b210da69df53");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ageless Spirit",
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
            yield return new TextBlock { Id = Guid.Parse("ff821026-ea03-454c-b8a9-e288082fb4a4"), Type = TextBlockType.Text, Text = "You remember more about your previous incarnations than most leshys. During your daily preparations, you can meditate upon fragmentary memories of your past lives to gain the trained proficiency rank in one skill of your choice. This proficiency lasts until you prepare again. Since this proficiency is temporary, you can’t use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59704df5-b77a-4244-b143-23fafc3881d4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
