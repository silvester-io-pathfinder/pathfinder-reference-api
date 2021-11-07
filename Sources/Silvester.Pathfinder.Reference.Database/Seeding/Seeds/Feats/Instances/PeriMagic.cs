using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeriMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("6391b039-4b5e-4e46-8de9-48de99af72d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peri Magic",
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
            yield return new TextBlock { Id = Guid.Parse("0e062dcc-b8cd-4f9f-97cb-67ac42c61e5c"), Type = TextBlockType.Text, Text = "The shimmering embers of the righteous peris crackle at your fingertips. You can cast (spell: glitterdust) and (spell: status) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("73237ba9-806f-498d-9538-7d033c7aefff"), Feats.Instances.Emberkin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f791ac84-dab7-4e3f-bf2c-d6b45847ab26"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
