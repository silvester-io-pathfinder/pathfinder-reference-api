using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallToAxis : Template
    {
        public static readonly Guid ID = Guid.Parse("cffb336e-e312-4d50-957f-e6bf417edcae");

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
            yield return new TextBlock { Id = Guid.Parse("ff5eefee-b2c6-4ecb-927d-c2b8b057057a"), Type = TextBlockType.Text, Text = $"You call upon the knowledge of Axis to ensure the accuracy of your information. You roll a second time and use the higher result. If you roll a critical failure, you get a failure instead. If you roll a success, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec88f703-5b3d-4901-8644-b251316c41ef"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
