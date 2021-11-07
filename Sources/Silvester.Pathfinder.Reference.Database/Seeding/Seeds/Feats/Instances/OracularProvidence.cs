using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OracularProvidence : Template
    {
        public static readonly Guid ID = Guid.Parse("03a98712-704d-4f36-854e-166d801d715b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oracular Providence",
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
            yield return new TextBlock { Id = Guid.Parse("e4ee8897-0a90-44a4-8bd7-27729135ff48"), Type = TextBlockType.Text, Text = "Your mystery grants you access to deep reserves of truly miraculous divine power. You gain an additional 10th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("cdafad29-9b25-42c7-8320-1fef4a740c17"), ClassFeatures.Oracles.OracularClarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d403157-0485-4b9d-b9ec-5286a0c974b3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
