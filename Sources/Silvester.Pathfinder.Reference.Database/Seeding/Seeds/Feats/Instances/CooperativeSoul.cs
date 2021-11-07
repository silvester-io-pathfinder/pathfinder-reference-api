using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CooperativeSoul : Template
    {
        public static readonly Guid ID = Guid.Parse("3b3ac86a-258b-4792-bb3b-cdf5c68a4d56");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cooperative Soul",
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
            yield return new TextBlock { Id = Guid.Parse("e9cf307a-2ec6-4054-aee8-13770e543dbe"), Type = TextBlockType.Text, Text = "You have developed a soul-deep bond with your comrades and maintain an even greater degree of cooperation with them. If you are at least an expert in the skill you are (action: Aiding | Aid), you get a success on any outcome rolled to (action: Aid) other than a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f18286ac-992c-4bd3-82cf-2fd6e102483c"), Feats.Instances.CooperativeNature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f9107a4-4887-4684-97f7-2f9238ad674d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
