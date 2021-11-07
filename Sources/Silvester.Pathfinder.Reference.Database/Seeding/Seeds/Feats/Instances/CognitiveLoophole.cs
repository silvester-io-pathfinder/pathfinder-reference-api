using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CognitiveLoophole : Template
    {
        public static readonly Guid ID = Guid.Parse("df5f6ce6-e574-4b55-8e75-7e3d57bf357f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cognitive Loophole",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can use this reaction even if the mental effect is preventing you from using reactions.",
                Trigger = "Your turn ends.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("284cdb5b-8c98-481b-b31b-3a84a1ebd37a"), Type = TextBlockType.Text, Text = "You can find a loophole in a mental effect to temporarily overcome it. Until the end of your next turn, you ignore a single (trait: mental) effect that meets the requirement. You can suppress a particular effect using Cognitive Loophole only once." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("096f60ad-e5d3-475b-9f75-bf857972f560"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d399bb5b-2a33-4a33-864b-b5f2fbf10b97"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
