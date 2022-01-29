using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WoodlandStride : Template
    {
        public static readonly Guid ID = Guid.Parse("7b05eb08-e7ef-4e42-8b01-fcbed2b7fd16");

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
            yield return new TextBlock { Id = Guid.Parse("aa9557e9-5e30-40ad-b886-aa86bb3cca37"), Type = TextBlockType.Text, Text = $"You can always find a path, almost as if foliage parted before you. You ignore any difficult terrain caused by plants, such as bushes, vines, and undergrowth. Even plants manipulated by magic don't impede your progress." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("5d843592-0501-41f9-a3ca-75319e396421"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37fb5217-f651-47c8-89d0-e432d86561aa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
