using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverdriveAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("c9ecb6f5-4268-4a5e-ba8b-be17040b944a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overdrive Ally",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("320cc0d6-41c7-450c-a7c0-a3c9bc1c0c2e"), Type = TextBlockType.Text, Text = "You quickly fling some of your powered-up mechanisms to an ally, sharing your benefits with them briefly. Choose an ally within 30 feet. Until the end of their next turn, that ally’s (action: Strikes | Strike) deal additional damage equal to half your Intelligence modifier, or your full Intelligence modifier if you were in critical overdrive. The ally doesn’t gain the increased damage from expert, master, or legendary overdrive." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b55b7487-13c2-49f7-a26f-603a276559dd"), Feats.Instances.Overdrive.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ab9dfa0-8380-4894-b9b3-27fdd1711dd3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
