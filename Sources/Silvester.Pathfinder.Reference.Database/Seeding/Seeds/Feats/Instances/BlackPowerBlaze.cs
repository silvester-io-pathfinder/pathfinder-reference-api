using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlackPowerBlaze : Template
    {
        public static readonly Guid ID = Guid.Parse("1ab60951-9578-4366-bf9d-9059be6e4171");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Power Blaze",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80fe495b-35d9-4453-b472-e577e6bbda21"), Type = TextBlockType.Text, Text = "You learn to take advantage of every shot, flying across the battlefield with the help of your weapon’s recoil. (action: Stride) and use (feat: Black Powder Boost). Make a ranged (action: Strike) with the required weapon at any point during the (feat: Black Powder Boost)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0175840b-27f7-4358-8ed5-c7d9716daad2"), Feats.Instances.BlackPowderBoost.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("413782b6-11f4-4c14-a533-1f68de7b6c08"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
