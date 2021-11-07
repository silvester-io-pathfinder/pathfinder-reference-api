using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TreeClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("67a3b966-bc7f-49da-86dd-6ffdd736fcb1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tree Climber",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("805b89e8-3161-4416-a95f-39274a47b2bc"), Type = TextBlockType.Text, Text = "Your time in forest or jungle canopies has taught you how to scramble across branches with sure feet. You gain a climb Speed of 10 feet. If you also have the (feat: Cave Climber) ancestry feat, your total climb Speed increases to your land Speed when climbing trees." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("2c12fb42-78b5-428b-9d68-f7e5a6ec37d0"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("9b5a5f71-08fb-4e32-b5c7-f964fbe54a08"), Heritages.Instances.TailedGoblin.ID);
                or.HaveSpecificHeritage(Guid.Parse("02b428c1-b32e-4744-91cf-fa1be7aff95a"), Heritages.Instances.TreedwellerGoblin.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57f789d1-f317-491a-91f7-d1004a3c7be0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
