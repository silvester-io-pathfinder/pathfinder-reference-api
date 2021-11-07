using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MobileShotStance : Template
    {
        public static readonly Guid ID = Guid.Parse("38df6b53-d33e-4890-8161-9663954e9edd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mobile Shot Stance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95580dae-3bc4-43b5-a705-0797f889bf8b"), Type = TextBlockType.Text, Text = "Your shots become nimble and deadly. While you’re in this stance, your ranged (action: Strikes | Strike) don’t trigger (feat: Attacks of Opportunity | Attack of Opportunity) or other reactions that are triggered by a ranged attack." };
            yield return new TextBlock { Id = Guid.Parse("ee44f401-7f2b-4da0-b261-91731d792415"), Type = TextBlockType.Text, Text = "If you have (feat: Attack of Opportunity), you can use it with a loaded ranged weapon you’re wielding. The triggering creature must be within 5 feet of you for you to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1d4356cd-b141-4ff5-a870-9b49264dcb29"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03525080-dee5-4e44-acd7-db627244bdb2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
