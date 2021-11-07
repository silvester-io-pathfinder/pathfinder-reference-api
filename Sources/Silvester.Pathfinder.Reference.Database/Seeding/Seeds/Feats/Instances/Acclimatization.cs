using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Acclimatization : Template
    {
        public static readonly Guid ID = Guid.Parse("8a4b70f2-05b6-452f-9f6e-71b9cd60af45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acclimatization",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3a93e8e-227a-403c-91ea-cf416b105e8d"), Type = TextBlockType.Text, Text = "Your time spent in the hostile parts of the world has inured you to extreme climates. In your favored terrain, you gain resistance equal to half your level to all environmental damage and are affected by temperature effects as though they were one step less severe (incredible heat or cold becomes extreme, extreme heat or cold becomes severe, and so on). When other creatures (action: Follow the Expert) with you as a guide in your favored terrain, they too treat temperature effects as one step less severe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ba98dc8-d1c3-403f-9a1e-22ea892b661c"), Feats.Instances.HorizonWalkerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f15837f8-6361-44ce-b7e8-32aacdea2c96"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
