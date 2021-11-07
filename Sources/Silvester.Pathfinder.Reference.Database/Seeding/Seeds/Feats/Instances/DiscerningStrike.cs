using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiscerningStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("d9f3cce9-e291-4270-93cf-0e887ac99848");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Discerning Strike",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0287b2a-c3c8-4f70-9bc0-2e5f93059a1c"), Type = TextBlockType.Text, Text = "Identifying a creature is the first step in finding its weaknesses. Attempt a (action: Strike) against the target; if successful, you deal an additional 1d6 precision damage. If you have succeeded on a (action: Recall Knowledge) check against the target during this combat and their creature type was previously recorded using (feat: Thorough Reports), you also deal 1 point of persistent bleed damage. The creature is then temporarily immune to Discerning Strike for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b9fd04e9-67e1-4ae9-ad59-9eb2277dd52f"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("dc9a7b50-865d-4a7f-bf29-faba5391e65c"), Feats.Instances.ThoroughReports.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d03dd3b-3203-4e15-ae72-ac3acee73cc1"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
