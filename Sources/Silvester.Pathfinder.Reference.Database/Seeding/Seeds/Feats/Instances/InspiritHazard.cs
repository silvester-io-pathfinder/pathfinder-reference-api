using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspiritHazard : Template
    {
        public static readonly Guid ID = Guid.Parse("889527df-12f8-4d96-87fd-4e1b175f8cc1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspirit Hazard",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You Disable a hazard.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e12fe5f5-459c-4395-a7b2-22bce96b4b2a"), Type = TextBlockType.Text, Text = "You awaken a spirit of creation within the hazard. You learn the hazard’s effects. Once in the next 10 minutes, when you observe a creature take an action that would trigger one of the hazard’s reactions or free actions if you hadn’t (action: Disabled | Disable a Device) it, you can use a reaction to rearm the hazard, causing the observed creature to trigger it immediately." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2558e4dd-fbc0-4475-936b-a9372ca1bad4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
