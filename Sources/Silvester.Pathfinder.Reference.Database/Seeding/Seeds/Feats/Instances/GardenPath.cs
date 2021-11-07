using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GardenPath : Template
    {
        public static readonly Guid ID = Guid.Parse("3d4bf268-9471-4408-8929-eedf2c675a6f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Garden Path",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccc3e8e3-f992-4f07-841c-9034e5d99934"), Type = TextBlockType.Text, Text = "You can guide your crop to move without notice. When you and any of your crop are (action: Avoiding Notice | Avoid Notice), you can choose one member of your crop to temporarily gain the benefits of the (feat: Quiet Allies) skill feat until the group is no longer (action: Avoiding Notice | Avoid Notice). The group rolls two checks instead of one, using the higher die roll. This is a (trait: fortune) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("620d2108-f35a-4c80-8d22-11c86748c70e"), Feats.Instances.BellflowerTillerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0846f838-0540-42b3-8613-a3c5079f7c51"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
