using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AcuteScent : Template
    {
        public static readonly Guid ID = Guid.Parse("7444643b-8b70-4455-b2cc-3c7026efec1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acute Scent",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3dbe5a74-f418-44c6-bbcf-4d02da391929"), Type = TextBlockType.Text, Text = "When you (Action: Rage), your sense of smell improves. You gain imprecise scent with a range of 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("4c2e218f-9336-4a53-8d3d-85c5b3fd0e9c"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("ebb6e231-4b23-4a7d-805a-384c63c63cee"), Feats.Instances.AcuteVision.ID);
                or.HaveSpecificSense(Guid.Parse("3d2a3a10-d157-4b0e-b990-4d3186cf5501"), Senses.Instances.Darkvision.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a06a8346-fd81-4cec-b027-39c95404962a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
