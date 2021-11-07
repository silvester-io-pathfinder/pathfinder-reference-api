using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossibleSnares : Template
    {
        public static readonly Guid ID = Guid.Parse("6f40da49-9ad1-438a-bd71-5e92186d8022");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Snares",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff60d10b-37d6-4725-86b4-b08b912a1d15"), Type = TextBlockType.Text, Text = "You can create endless shorter-lived snares, protecting your lair or using them against foes. Once per minute, you can (action: Craft) one of the snares you’ve prepared for quick deployment without expending the prepared snare. Once deployed, such a snare lasts for 10 minutes before losing its effectiveness." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("272cefd1-65fd-4a42-a320-6133d0aa1f5c"), Feats.Instances.UbiquitousSnares.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("439062b2-cbde-43ef-b464-f72265f33f1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
