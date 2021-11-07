using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GracefulGuidance : Template
    {
        public static readonly Guid ID = Guid.Parse("ad61474e-f548-422d-b51a-7a025c661461");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Graceful Guidance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88254659-abdc-4f44-a12e-8293e3173437"), Type = TextBlockType.Text, Text = "You can demonstrate how to quickly twist out of the way of dangerous effects. You can use the (action: Aid) reaction to grant a bonus to an ally’s Reflex save. As usual for (action: Aid), you need to prepare by using an action on your turn to encourage the ally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c21f3690-5a41-43f2-a6e2-573a6cad852a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
