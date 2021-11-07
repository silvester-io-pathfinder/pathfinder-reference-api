using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PredatorsPounce : Template
    {
        public static readonly Guid ID = Guid.Parse("c60e17ae-1197-47a9-b94a-6c5974963615");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Predator's Pounce",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("926c503a-9d57-4ad4-b4fa-a78d24fb2509"), Type = TextBlockType.Text, Text = "You close the distance to your prey in a blur, pouncing on the creature before it can react. You (action: Stride) up to your Speed and make a (action: Strike) at the end of your movement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("60a61a9c-2ba6-4877-a238-38fbffb4a216"), Instincts.Instances.AnimalInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03482b9a-84b3-4708-a5da-2b71a1b20c3d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
