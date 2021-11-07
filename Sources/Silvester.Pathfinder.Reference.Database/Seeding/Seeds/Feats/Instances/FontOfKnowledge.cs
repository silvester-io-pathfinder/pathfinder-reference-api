using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FontOfKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("cfd5706e-4837-420a-92df-b11eea5ad851");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Font of Knowledge",
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
            yield return new TextBlock { Id = Guid.Parse("ffa53af9-df7d-4df7-9a31-b6dfad1c284f"), Type = TextBlockType.Text, Text = "Experience or focused study have granted you mastery of a number of topics. When you know about something, you know about it in great detail. When you succeed at a check to (action: Recall Knowledge), you gain additional information or context. When you critically succeed at a check to (action: Recall Knowledge), at the GM’s discretion, you might gain even more additional information or context than normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f3a8b746-50ec-439f-9921-abf59685568d"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fa6d1f2-6f57-4edc-bf93-9b6e84068cea"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
