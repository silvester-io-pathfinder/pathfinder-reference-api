using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecondAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("e348f60a-47a7-47e5-b17f-2e9a2aff3edc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Second Ally",
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
            yield return new TextBlock { Id = Guid.Parse("17324a8e-20f1-4275-8910-4fd006d9ee40"), Type = TextBlockType.Text, Text = "Your inner grace attracts the attention of a second protective spirit. Choose a second type of divine ally and gain its benefits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d3c9515d-8ff8-40ad-bb21-c5f2eaba97c7"), Feats.Instances.DivineAlly.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c12bf318-2ca2-4205-81bc-4e7c832a20af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
