using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AriseYeWorthy : Template
    {
        public static readonly Guid ID = Guid.Parse("e0caad1e-1182-451d-bbb4-fff6ba78e406");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arise, Ye Worthy!",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d68d66f-d33b-4ff3-86d1-8261a0959e58"), Type = TextBlockType.Text, Text = "You are descended from the valkyries who protect worthy souls, and can hold back death’s grasp. You can cast (spell: breath of life) as a divine innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9c9eabd-1697-4efc-adc0-c5e2edf185f3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
