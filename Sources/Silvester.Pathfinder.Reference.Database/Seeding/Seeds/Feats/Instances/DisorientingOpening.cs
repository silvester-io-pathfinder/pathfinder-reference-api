using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisorientingOpening : Template
    {
        public static readonly Guid ID = Guid.Parse("85a48837-fa6f-43ab-8c24-53469b57cb5a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disorienting Opening",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eff471f9-4856-4158-97a5-7f3f964afbb9"), Type = TextBlockType.Text, Text = "You use your foes’ openings to expose even greater weaknesses. When you hit a creature as part of an (feat: Attack of Opportunity), that creature becomes flat-footed until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("95b2e3bf-e7a3-44ea-953f-4dcb2e1cbd45"), Feats.Instances.AttackOfOpportunity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfabdcc1-19ea-439f-9407-f3f31fa8b5a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
