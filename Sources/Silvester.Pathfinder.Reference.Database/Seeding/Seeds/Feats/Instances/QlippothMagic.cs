using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QlippothMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("fa3db491-6927-44ff-9cde-8f62e04498c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Qlippoth Magic",
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
            yield return new TextBlock { Id = Guid.Parse("d8d7e76c-95a6-407b-8326-3fca8c40fe4e"), Type = TextBlockType.Text, Text = "You’ve deeply studied the secrets of your blood and can force reality to act against its own wishes. You can cast (spell: blur) and (spell: silence) once per day each as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0adb50a8-4f34-4e12-a255-5cbea440438f"), Feats.Instances.Riftmarked.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("977a7ec4-c5db-429a-a0bb-01dcf7eeb05e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
