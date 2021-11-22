using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConceitedMindset : Template
    {
        public static readonly Guid ID = Guid.Parse("a1cc85f4-5af6-4176-826a-509d41534892");

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
            yield return new TextBlock { Id = Guid.Parse("2476bb81-fb12-4ef1-8022-0963324aa340"), Type = TextBlockType.Text, Text = "Because you know your mind is superior, you scoff at anyone who would alter your mental state—but this hubris gets the better of you when you're wrong. You gain a +2 circumstance bonus to saves against (trait: mental) effects. If you succeed at a save against a mental effect, you critically succeed instead; similarly, if you fail at a save against a mental effect, you critically fail instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("448bed04-3f65-4d19-bb3f-8406a62d599c"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cdcb33fb-74c5-45ff-a8d3-3f25819fe3f7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
