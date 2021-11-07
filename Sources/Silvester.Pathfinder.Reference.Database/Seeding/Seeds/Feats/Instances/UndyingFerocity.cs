using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UndyingFerocity : Template
    {
        public static readonly Guid ID = Guid.Parse("3d8ba5cc-783c-4b81-b360-c7a9ab216d25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Undying Ferocity",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cfee4151-2277-4799-a018-b307a9be91ab"), Type = TextBlockType.Text, Text = "You resist death&#39;s clutches with supernatural vigor. When you use (feat: Orc Ferocity), you gain temporary Hit Points equal to your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("55101f5c-cb84-4bcb-8a21-8dd3093aa3b2"), Feats.Instances.OrcFerocity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("572d59b9-1b69-4b63-80a0-20a258c773d6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
