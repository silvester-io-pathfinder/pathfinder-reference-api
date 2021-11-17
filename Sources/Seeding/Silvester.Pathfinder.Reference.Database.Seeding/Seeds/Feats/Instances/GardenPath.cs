using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GardenPath : Template
    {
        public static readonly Guid ID = Guid.Parse("e271fafa-4a73-490c-99ce-72cd9e9521bd");

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
            yield return new TextBlock { Id = Guid.Parse("5c688721-e164-45c0-b0a1-b96427c5359a"), Type = TextBlockType.Text, Text = "You can guide your crop to move without notice. When you and any of your crop are (action: Avoiding Notice | Avoid Notice), you can choose one member of your crop to temporarily gain the benefits of the (feat: Quiet Allies) skill feat until the group is no longer (action: Avoiding Notice | Avoid Notice). The group rolls two checks instead of one, using the higher die roll. This is a (trait: fortune) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("05bd0ca9-85e4-4244-9098-8defa66a7dae"), Feats.Instances.BellflowerTillerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef5887bf-6752-482c-a7c8-b29f67ff9b25"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
