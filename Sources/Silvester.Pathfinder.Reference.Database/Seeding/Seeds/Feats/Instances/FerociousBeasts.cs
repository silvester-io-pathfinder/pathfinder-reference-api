using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FerociousBeasts : Template
    {
        public static readonly Guid ID = Guid.Parse("ef761649-c55c-4ec4-ab20-ff08528c0374");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ferocious Beasts",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c368621-4941-40f3-a2c9-34732e110a96"), Type = TextBlockType.Text, Text = "Since ancient times, the mightiest orc beast tamers would draw out the true fighting spirit of their companion beasts by feeding the creatures a draft incorporating the orc&#39;s own blood. Animal companions or bonded animals you have gain the (feat: Orc Ferocity) feat, and they gain a reaction they can use only for (feat: Orc Ferocity). If you have the (feat: Undying Ferocity) ancestry feat, all animal companions or bonded animals you have also gain the benefits of that feat when using the (feat: Orc Ferocity) reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("1b92d985-2d14-4f4d-95cd-2bef3ea1a715"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("0b06ca1b-e233-4ea8-89ae-e8c47359116a"), Feats.Instances.BeastTrainer.ID);
                or.HaveSpecificFeat(Guid.Parse("e8237d70-c5da-4c54-ac2b-74e64276e1dc"), Feats.Instances.AnimalCompanion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("a7107c5e-56cd-4b76-b27f-dbf0011c03df"), Feats.Instances.OrcFerocity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb8b3237-aee3-4d4f-b08e-398d9beab936"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
