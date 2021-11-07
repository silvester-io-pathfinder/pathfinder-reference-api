using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CollapseConstruct : Template
    {
        public static readonly Guid ID = Guid.Parse("c6d10439-7c3c-410c-a2c1-cb0fd5a48aef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Collapse Construct",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc1d4d29-b000-436a-b5b2-92f695f7bc2e"), Type = TextBlockType.Text, Text = "You’ve modified your construct companion and built it out of light materials, enabling you to collapse it into a carrying case or other compact and innocuous form. Either your construct or you (if you’re adjacent to it) can Collapse your Construct to turn it into its compact form or back into its normal form." };
            yield return new TextBlock { Id = Guid.Parse("e415dd9a-506c-4a3c-a4c6-9012d47c50e7"), Type = TextBlockType.Text, Text = "In compact form, your construct can’t act but is easily carried, with a Bulk of 2 if it’s Small, 4 if it’s Medium, or 8 if it’s Large. The compact form has wheels, so you can easily drag it behind you at half your Speed (rather than the usual slower Speed for dragging)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("d077a53b-9bd4-4cec-b361-0b004b153eb2"), Innovations.Instances.Construct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f03c351-78d7-4963-b435-7d18bff5d531"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
