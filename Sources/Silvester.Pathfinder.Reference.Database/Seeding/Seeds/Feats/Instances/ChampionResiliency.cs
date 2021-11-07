using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChampionResiliency : Template
    {
        public static readonly Guid ID = Guid.Parse("2f78fda3-068a-457b-ac29-86b262b6bf02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Champion Resiliency",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bdaddfa3-6188-4e67-974c-8d136aa0bed0"), Type = TextBlockType.Text, Text = "You gain 3 additional Hit Points for each champion archetype class feat you have. As you continue selecting champion archetype class feats, you continue to gain additional Hit Points in this way." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7104a27d-ee6f-4e86-a148-f4be0a5a7743"), Feats.Instances.ChampionDedication.ID);
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c140ab06-97ac-44b2-b248-69b5aaa6df54"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
