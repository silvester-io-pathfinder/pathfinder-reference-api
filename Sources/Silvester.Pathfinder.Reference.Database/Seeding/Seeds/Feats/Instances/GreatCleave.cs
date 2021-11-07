using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreatCleave : Template
    {
        public static readonly Guid ID = Guid.Parse("9e3c44da-12bb-4a93-b44d-c592657710f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Great Cleave",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c24be7f-9862-4dd5-9251-722c03e0e13e"), Type = TextBlockType.Text, Text = "Your fury carries your weapon through multiple foes. When you (feat: Cleave), if your (action: Strike) also kills or knocks the target unconscious, you can continue to make melee (action: Strikes | Strike) until you make a (action: Strike) that doesn’t kill or knock a creature unconscious, or until there are no creatures adjacent to the most recent creature you attacked while (feat: Cleaving | Cleave), whichever comes first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("79668a97-8ed9-4f1e-bbd4-99bf9afca6e0"), Feats.Instances.Cleave.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44d5e0a9-1832-4f17-803c-7cf66ac1221d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
