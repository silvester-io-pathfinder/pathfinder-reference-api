using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpandedDomainInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("9ccabdc0-0202-465e-b4e9-4b4d43379b38");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expanded Domain Initiate",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17818384-5754-44fe-81ba-1963da1ad048"), Type = TextBlockType.Text, Text = "You have long venerated one of your deity’s lesser-known aspects. Select one domain from your deity’s alternate domains. You gain access to that domain and an initial domain spell for that domain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4f2c806b-5c93-4428-b586-7ec72b471af1"), Feats.Instances.DomainInitiate.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f04afe3-6ec4-43fa-8b00-9a2181ac1db0"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
