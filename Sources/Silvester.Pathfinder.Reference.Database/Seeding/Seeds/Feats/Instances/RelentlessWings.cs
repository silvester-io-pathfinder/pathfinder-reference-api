using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RelentlessWings : Template
    {
        public static readonly Guid ID = Guid.Parse("5e55b8fa-6977-4325-9730-06bb12604e08");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Relentless Wings",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c637fd07-63df-487d-8248-cb1b6e8a4410"), Type = TextBlockType.Text, Text = "Your wings are now a permanent part of your physiology. You gain the effects of (feat: Fiendish Wings) at all times, rather than just once per day for 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6b0d4f06-9ad2-47b8-87ee-33cae094d3ce"), Feats.Instances.FiendishWings.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6caa043a-eaff-462b-8ffc-25247cd0688e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
