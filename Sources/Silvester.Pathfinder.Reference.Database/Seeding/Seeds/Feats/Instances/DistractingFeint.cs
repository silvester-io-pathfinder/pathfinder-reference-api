using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("c1ec6718-2f37-478f-8336-ba040ca58ac8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Feint",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d8d7c6c-b952-4373-9c25-779c50dbec25"), Type = TextBlockType.Text, Text = "Your (action: Feints | Feint) are far more distracting than normal, drawing your foes’ attention and allowing you and your allies to take greater advantage. While a creature is flat-footed by your (action: Feint), it also takes a -2 circumstance penalty to Perception checks and Reflex saves." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("de79048a-72c0-491d-b3ae-289f01cc403a"), Rackets.Instances.Scoundrel.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5af1982e-ef43-4555-8778-8e84c8635e8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
