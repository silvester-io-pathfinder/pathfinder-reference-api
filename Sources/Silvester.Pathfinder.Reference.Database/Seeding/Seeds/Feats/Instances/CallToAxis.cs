using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallToAxis : Template
    {
        public static readonly Guid ID = Guid.Parse("dd6bb2f6-91ba-455e-84f7-ac3ea8377f49");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call to Axis",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to attempt a check to Recall Knowledge.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef58fb5e-33b5-47fc-bfde-89a322851e5a"), Type = TextBlockType.Text, Text = "You call upon the knowledge of Axis to ensure the accuracy of your information. You roll a second time and use the higher result. If you roll a critical failure, you get a failure instead. If you roll a success, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adafdf37-e6a1-4f22-b06a-36e977d3da8d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
