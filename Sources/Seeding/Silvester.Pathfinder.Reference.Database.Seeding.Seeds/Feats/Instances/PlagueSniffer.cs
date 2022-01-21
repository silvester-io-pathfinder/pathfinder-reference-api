using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlagueSniffer : Template
    {
        public static readonly Guid ID = Guid.Parse("cd2fb9e5-23dc-4088-9c42-fbc9d23b46f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plague Sniffer",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d296eed-25a4-47d4-a04a-bd966325bdea"), Type = TextBlockType.Text, Text = "You can sniff out the pungent tang of disease. When you detect a creature by scent, you can also detect if that creature is suffering from a disease at a non-carrier state. If the disease is particularly subtle, you might need to attempt a Perception check against the disease's DC (subject to the GM's discretion)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("cff340d0-fdfc-47e2-a1c8-0e2017967761"), Heritages.Instances.LongsnoutRat.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83ca92ed-01a8-4b3c-86c4-6c522898d170"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
