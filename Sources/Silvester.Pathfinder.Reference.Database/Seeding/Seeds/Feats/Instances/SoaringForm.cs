using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoaringForm : Template
    {
        public static readonly Guid ID = Guid.Parse("b26a1aaa-3c32-484a-8f36-35f04ef8119d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soaring Form",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0e65490-c05e-415d-8061-e805ee9b5d42"), Type = TextBlockType.Text, Text = "Your wings grow stronger. You gain the effects of (feat: Soaring Flight) at all times." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3330f283-4386-478b-ba32-e1c013492990"), Feats.Instances.SoaringFlight.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c181895-e293-4420-9149-0ee7e7d1893b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
