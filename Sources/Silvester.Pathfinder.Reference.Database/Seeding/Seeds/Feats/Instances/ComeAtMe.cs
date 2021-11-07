using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ComeAtMe : Template
    {
        public static readonly Guid ID = Guid.Parse("18865105-1fc4-48b3-9401-dbc0fdb0e7ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Come at Me!",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da788e5b-9f73-4ee2-9e64-704198a06ae6"), Type = TextBlockType.Text, Text = "You’re a legendary duelist, welcoming all challengers, enabling you to challenge many foes even while other challenges are active. There is no longer a limit to the number of (feat: Pistolero’s Challenges|Pistolero’s Challenge) you can have in effect at one time." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33ca3016-ed7d-4ec4-9299-2002930f9428"), Feats.Instances.PistolersChallenge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0225b4d9-fc91-4fbf-9b07-c19a2c658fa2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
