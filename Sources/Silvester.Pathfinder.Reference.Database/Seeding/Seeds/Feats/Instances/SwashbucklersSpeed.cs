using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwashbucklersSpeed : Template
    {
        public static readonly Guid ID = Guid.Parse("93b8d13f-7d02-499c-84c4-fbc7d54aeba9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swashbuckler's Speed",
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
            yield return new TextBlock { Id = Guid.Parse("d45ec1b5-649b-4abc-8d3b-b0161a50fb43"), Type = TextBlockType.Text, Text = "You move faster, with or without panache. Increase the status bonus to your Speeds when you have panache to a +10-foot status bonus; you also gain a +5-foot status bonus to your Speeds when you don’t have panache." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d4b15256-e06d-41d4-83a9-2bc1168b3031"), Feats.Instances.SwashbucklerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9193ef39-0cd2-4733-97a6-d563303ae68f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
