using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranscribeMoment : Template
    {
        public static readonly Guid ID = Guid.Parse("2c12dfe5-50d4-44f5-8477-8d3de206c10f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Transcribe Moment",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("900be9d7-2bdb-4db9-b728-68a25246ed97"), Type = TextBlockType.Text, Text = "You gain the (spell: transcribe moment) focus spell. If you don&#39;t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by spending 10 minutes to study a text or record notes on your recent experiences." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2847a649-80b9-439e-b2d7-b5eb8688f7e9"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11bcdbf4-c6d1-473a-8433-774c9c7f20e1"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
