using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Dangle : Template
    {
        public static readonly Guid ID = Guid.Parse("dfa0743a-f9b8-4463-8bf4-4ca707570776");

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
            yield return new TextBlock { Id = Guid.Parse("17051066-fffb-4b4f-bb0e-0213e21ed0dd"), Type = TextBlockType.Text, Text = "You can hang by your tail from any suitable anchor point, such as a tree branch, balcony, or rocky outcropping (subject to the GM’s discretion), typically while climbing. While hanging, you have free use of all your other limbs, so you can perform tasks that require both hands, such as firing a bow or swinging a greatsword." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6bea8300-0ddd-4688-8f29-e4d52c446675"), Feats.Instances.FlexibleTail.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3168f05d-ecda-4978-a7c9-4fce548f0a14"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
