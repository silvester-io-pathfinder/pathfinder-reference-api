using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScaldingSpit : Template
    {
        public static readonly Guid ID = Guid.Parse("f684a4e1-9a75-49d7-86a6-ee556e138415");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scalding Spit",
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
            yield return new TextBlock { Id = Guid.Parse("ff94fab8-e73d-46c9-a7be-ec2599ee9ddb"), Type = TextBlockType.Text, Text = "Your bodily fluids burn with surprising volatility, as if you ran on oil instead of blood. As long as you are taking persistent fire damage, you gain a boiling spit ranged unarmed attack with a range of 30 feet that deals 1d6 fire damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f7bf7f8-5a02-4803-a045-6cb9bbb1bab8"), Feats.Instances.TorchGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6269df88-8fa6-4068-a244-7e24ba495b70"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
