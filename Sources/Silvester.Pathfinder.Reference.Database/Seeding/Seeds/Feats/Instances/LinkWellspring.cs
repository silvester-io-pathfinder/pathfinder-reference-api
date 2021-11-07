using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LinkWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("873eac9a-8217-4f52-8723-19d50241a082");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Link Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("925e1fa2-3095-4756-adef-a8c6ef8be4c4"), Type = TextBlockType.Text, Text = "Your bond replenishes your focus. If you have spent at least 3 Focus Points since the last time you (action: Refocused | Refocus), you recover 3 Focus Points when you (action: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e76f418c-c921-4f49-86ab-abfcb66781aa"), Feats.Instances.LinkFocus.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dd7eeda-8ea9-4af7-8d64-0d097592e7e9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
