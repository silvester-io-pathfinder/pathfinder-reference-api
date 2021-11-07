using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgathionMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("ba6db3ba-c119-411c-bee5-0e95e6c5d03d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Agathion Magic",
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
            yield return new TextBlock { Id = Guid.Parse("c2080427-1d3a-4346-9da3-7e4019e744ef"), Type = TextBlockType.Text, Text = "The harmonious magic of Nirvana flows through you. You can cast (spell: animal form) and (spell: calm emotions) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7e820025-9028-43fb-b890-2477cb543d23"), Feats.Instances.Idyllkin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0fff2aa-b0c6-4fd3-86dd-dcaa89d009ab"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
