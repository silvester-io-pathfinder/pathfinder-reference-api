using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Dangle : Template
    {
        public static readonly Guid ID = Guid.Parse("3a43e450-025e-4c8e-a5c7-0aee6cb699ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dangle",
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
            yield return new TextBlock { Id = Guid.Parse("61b51c9e-eed2-4147-a06f-ee0595d7fefe"), Type = TextBlockType.Text, Text = $"You can hang by your tail from any suitable anchor point, such as a tree branch, balcony, or rocky outcropping (subject to the GM's discretion), typically while climbing. While hanging, you have free use of all your other limbs, so you can perform tasks that require both hands, such as firing a bow or swinging a greatsword." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3ae68694-154f-4705-85c3-e3568fff11c4"), Feats.Instances.FlexibleTail.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c59d5aeb-99b5-4c48-b677-8142a455c852"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
