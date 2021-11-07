using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FastRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("f2f40488-0184-4f88-a9cf-c48e44284358");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fast Recovery",
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
            yield return new TextBlock { Id = Guid.Parse("4568db43-e099-4d35-80cc-b2bf626dd9c8"), Type = TextBlockType.Text, Text = "Your body quickly bounces back from afflictions. You regain twice as many Hit Points from resting. Each time you succeed at a Fortitude save against an ongoing disease or poison, you reduce its stage by 2, or by 1 against a virulent disease or poison. Each critical success you achieve against an ongoing disease or poison reduces its stage by 3, or by 2 against a virulent disease or poison. In addition, you reduce the severity of your drained condition by 2 when you rest for a night instead of by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("068cc269-dea7-4cd7-90b1-bac4af363daa"), requiredStatValue: 14, Stats.Instances.Constitution.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07eb8da0-a3a6-443d-8b28-39cae1fd2353"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
