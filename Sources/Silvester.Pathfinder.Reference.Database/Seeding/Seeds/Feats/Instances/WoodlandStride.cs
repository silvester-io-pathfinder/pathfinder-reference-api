using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WoodlandStride : Template
    {
        public static readonly Guid ID = Guid.Parse("7020495b-545c-4c11-a5ac-9b0189450e0c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Woodland Stride",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("33a942d1-9d70-46a1-ad08-a6c8c63ccbbf"), Type = TextBlockType.Text, Text = "You can always find a path, almost as if foliage parted before you. You ignore any difficult terrain caused by plants, such as bushes, vines, and undergrowth. Even plants manipulated by magic don’t impede your progress." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("4a44506f-e8d4-4d42-9f10-07b054f5a12b"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01d28363-283e-4f3b-b798-1f0dd0f859cd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
