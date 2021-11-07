using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConceitedMindset : Template
    {
        public static readonly Guid ID = Guid.Parse("a2665d0a-635d-403f-b735-05e286834549");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conceited Mindset",
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
            yield return new TextBlock { Id = Guid.Parse("070ba4f3-1d00-4706-8703-ce784ccd7995"), Type = TextBlockType.Text, Text = "Because you know your mind is superior, you scoff at anyone who would alter your mental state—but this hubris gets the better of you when you’re wrong. You gain a +2 circumstance bonus to saves against (trait: mental) effects. If you succeed at a save against a mental effect, you critically succeed instead; similarly, if you fail at a save against a mental effect, you critically fail instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("00ec1af7-0a26-4ae4-8c94-f7dcf499968a"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91ac326a-8c37-4345-ba12-9708af9493c0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
