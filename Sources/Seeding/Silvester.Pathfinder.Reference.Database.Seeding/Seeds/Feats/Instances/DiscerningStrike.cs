using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiscerningStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("3a750247-a71f-4a23-8268-202f42423fad");

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
            yield return new TextBlock { Id = Guid.Parse("8d9c2296-0b6e-4bec-8acb-39b80b089d43"), Type = TextBlockType.Text, Text = "Identifying a creature is the first step in finding its weaknesses. Attempt a (action: Strike) against the target; if successful, you deal an additional 1d6 precision damage. If you have succeeded on a (action: Recall Knowledge) check against the target during this combat and their creature type was previously recorded using (feat: Thorough Reports), you also deal 1 point of persistent bleed damage. The creature is then temporarily immune to Discerning Strike for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1fb674dc-9fe1-48b0-8824-9c09a43c2371"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("53ed6564-2444-42f5-b8b8-b2e486d74b8d"), Feats.Instances.ThoroughReports.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b50097a1-2c34-4ea2-9bd5-4274fbdf5351"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
