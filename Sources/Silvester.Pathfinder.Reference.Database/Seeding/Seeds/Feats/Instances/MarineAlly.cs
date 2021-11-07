using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MarineAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("0ff8abf1-ae55-472e-957b-6ede841fc620");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Marine Ally",
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
            yield return new TextBlock { Id = Guid.Parse("58c1edc5-35d7-493b-a92d-f347fb6c8c69"), Type = TextBlockType.Text, Text = "You’ve befriended a sea creature, which becomes magically bonded to you. You gain a familiar. The type of creature is up to you, but one of its abilities must always be a swim Speed or the amphibious familiar ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2da64b3e-2f9e-49b8-bf8d-b8f238344002"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
