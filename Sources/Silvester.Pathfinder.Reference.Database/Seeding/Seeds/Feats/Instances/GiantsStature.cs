using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GiantsStature : Template
    {
        public static readonly Guid ID = Guid.Parse("6dc60c0e-b9d6-405e-84e4-4fed5953ebd8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Giant's Stature",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d161e9c-e26d-403a-90df-9b3699b934ce"), Type = TextBlockType.Text, Text = "You grow to incredible size. You become Large, increasing your reach by 5 feet and gaining the clumsy 1 condition until you stop raging. Your equipment grows with you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("a5ac8818-aca9-41b7-a635-ebda0186ec5c"), Instincts.Instances.GiantInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72fbdc89-4af4-4276-b454-4d15025335e8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
