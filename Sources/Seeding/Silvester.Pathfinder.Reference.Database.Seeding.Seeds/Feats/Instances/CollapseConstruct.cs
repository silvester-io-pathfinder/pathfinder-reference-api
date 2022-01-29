using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CollapseConstruct : Template
    {
        public static readonly Guid ID = Guid.Parse("f97f49a7-50b1-4d66-ab2a-38e4ff09d2fb");

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
            yield return new TextBlock { Id = Guid.Parse("ae2b0fe0-cdc1-4c42-b2e5-0e43b38cbed7"), Type = TextBlockType.Text, Text = $"You've modified your construct companion and built it out of light materials, enabling you to collapse it into a carrying case or other compact and innocuous form. Either your construct or you (if you're adjacent to it) can Collapse your Construct to turn it into its compact form or back into its normal form." };
            yield return new TextBlock { Id = Guid.Parse("db2daffd-0d88-4cfc-8433-bbdf40e21562"), Type = TextBlockType.Text, Text = $"In compact form, your construct can't act but is easily carried, with a Bulk of 2 if it's Small, 4 if it's Medium, or 8 if it's Large. The compact form has wheels, so you can easily drag it behind you at half your Speed (rather than the usual slower Speed for dragging)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("cd5d35ab-c86c-4e7a-a1be-135c9574ee8a"), Innovations.Instances.Construct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbb8a693-a0b1-4dcc-89f9-8dfc6977484d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
