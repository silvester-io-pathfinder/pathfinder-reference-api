using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrowdMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("7c9fcee9-8731-4e42-9480-d2d767a32d77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crowd Mastery",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("567381d9-3aa0-4220-9ab3-c7f7652b9002"), Type = TextBlockType.Text, Text = "You use the crowd to your advantage, diverting your foes’ attention to potential hidden dangers in the crowd. When determining if your foe is flanked, treat all squares occupied by a crowd as if they were occupied by an ally with a melee reach of 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b9d0eb86-7491-4921-85ea-0c63e091b31e"), Feats.Instances.LostInTheCrowd.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f0b114a-b25e-4179-9b7c-000f29f27978"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
