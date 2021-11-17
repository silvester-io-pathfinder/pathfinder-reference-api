using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FullyFlighted : Template
    {
        public static readonly Guid ID = Guid.Parse("12e5ad3f-3841-4c9e-8f30-53b8b48d4f2f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fully Flighted",
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
            yield return new TextBlock { Id = Guid.Parse("f0573edf-31f8-472d-86ef-7b86dc908ba9"), Type = TextBlockType.Text, Text = "You gain the effects of (feat: Juvenile Flight) at all times, rather than just once per day for 10 minutes. This includes the status bonus to your Speed if you have (feat: Fledgling Flight)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("52a5513e-18d3-44b3-84ab-0ad8eb86a08e"), Feats.Instances.JuvenileFlight.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f42f985-a85c-4fff-8094-61311e6afecb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
