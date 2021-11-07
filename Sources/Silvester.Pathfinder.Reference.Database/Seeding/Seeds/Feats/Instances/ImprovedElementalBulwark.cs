using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedElementalBulwark : Template
    {
        public static readonly Guid ID = Guid.Parse("c09cf95f-a1c6-427b-a10e-a1941de1ae5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Elemental Bulwark",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("186016a8-8b62-4d59-b7d3-a03674218094"), Type = TextBlockType.Text, Text = "You gain resistance 10 from (feat: Elemental Bulwark) instead of 5." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("115f7f24-eb34-45a4-85e6-1a13de2664aa"), Feats.Instances.ElementalBulwark.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0901b095-b072-4d01-b1f1-42d3db1aad6c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
